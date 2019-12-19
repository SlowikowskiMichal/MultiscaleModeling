using System;
using System.Collections.Generic;
using System.Linq;
using MultiscaleModeling.Model;
using System.Threading;
using MultiscaleModeling.Model.Neighbourhood;
using MultiscaleModeling.Model.Inclusions;

namespace MultiscaleModeling.Controller
{
    class GridController
    {
        #region ATTRIBUTES

        #region THREADING
        readonly static object synLock = new object();
        bool running;
        #endregion

        #region GRID
        Grid currentGrid;
        Grid nextStepGrid;
        public int emptyCount { get; private set; }
        #endregion

        #region NUCLEONS
        int nucleonsPopulation;
        public int CurrentNucleonID { get; private set; }
        public int ProbabilityOfChange;
        int maxEnergy = 1;
        int minEnergy = 0;
        #endregion

        #region INCLUSIONS
        InclusionManager InclusionManager;
        #endregion

        #region B/N CONDITIONS
        public Neighbourhood Neighbourhood { get; private set; }
        public BoundaryCondition BoundaryCondition { get; private set; }
        #endregion

        #region MONTECARLO
        MonteCarloEngine mcEngine;
        #endregion

        #region RECRYSTALLIZATION
        RecrystallizationEngine rcEngine;
        #endregion


        #endregion

        #region GETTERS SETTERS
        public void SetNeighbourhood(Neighbourhood neighbourhood)
        {
            this.Neighbourhood = neighbourhood;
        }
        public void SetBoundaryCondition(BoundaryCondition boundaryCondition)
        {
            this.BoundaryCondition = boundaryCondition;
        }
        public int GetNucleonsPopulation()
        {
            return nucleonsPopulation;
        }
        #endregion

        #region METHODS
        #region CONSTRUCTORS

        public GridController()
        {
            currentGrid = new Grid();
            nextStepGrid = new Grid();
            nucleonsPopulation = 1;
            CurrentNucleonID = 0;
            emptyCount = Grid.SizeX * Grid.SizeY;
            ProbabilityOfChange = 100;
            mcEngine = new MonteCarloEngine();
            rcEngine = new RecrystallizationEngine();
        }
        public GridController(int gridWidth, int gridHeight)
        {
            currentGrid = new Grid(gridWidth, gridHeight);
            nextStepGrid = new Grid(gridWidth, gridHeight);
            nucleonsPopulation = 1;
            CurrentNucleonID = 0;
            emptyCount = Grid.SizeX * Grid.SizeY;
            ProbabilityOfChange = 100;
            mcEngine = new MonteCarloEngine();
            rcEngine = new RecrystallizationEngine();
        }
        public GridController(int gridWidth, int gridHeight, int nucleonsPopulation)
        {
            currentGrid = new Grid(gridWidth, gridHeight);
            nextStepGrid = new Grid(gridWidth, gridHeight);
            this.nucleonsPopulation = nucleonsPopulation;
            CurrentNucleonID = 0;
            emptyCount = Grid.SizeX * Grid.SizeY;
            ProbabilityOfChange = 100;
            mcEngine = new MonteCarloEngine();
            rcEngine = new RecrystallizationEngine();
        }
        #endregion
        /// <summary>
        /// Returns true if cell is aggregaded
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int GetCurrentGridCellState(int x, int y)
        {
            return currentGrid.Cells[x, y].State;
        }

        public int GetCurrentGridCellId(int x, int y)
        {
            return currentGrid.Cells[x, y].Id;
        }
        public void ResizeGrid(int width, int height)
        {
            mcEngine.ResetCurrentIteration();
            rcEngine.ResetCurrentIteration();
            currentGrid.Resize(width, height);
            nextStepGrid.Resize(width, height);
            emptyCount = Grid.SizeX * Grid.SizeY;
            minEnergy = 0;
            maxEnergy = 1;
        }
        public void ClearGrid()
        {
            mcEngine.ResetCurrentIteration();
            rcEngine.ResetCurrentIteration();
            currentGrid.Clear();
            nextStepGrid.Clear();
            emptyCount = Grid.SizeX * Grid.SizeY;
            minEnergy = 0;
            maxEnergy = 1;
        }

        internal void selectGrainForDP(int cellPosX, int cellPosY, int selectionType)
        {
            if (currentGrid.Cells[cellPosX, cellPosY].State == 2)
            {
                return;
            }

            bool recalculateEnergy = currentGrid.Cells[cellPosX, cellPosY].Energy == minEnergy ||
                currentGrid.Cells[cellPosX, cellPosY].Energy == maxEnergy;
            int idToChange = currentGrid.Cells[cellPosX, cellPosY].Id;
            int stateToChangeTo = 3;
            int idToChangeTo = -2;
            if (selectionType == 0)
            {
                idToChangeTo = idToChange;
                stateToChangeTo = 4;
            }
            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if (currentGrid.Cells[x, y].Id == idToChange)
                    {
                        currentGrid.Cells[x, y].ChangeState(stateToChangeTo);
                        currentGrid.Cells[x, y].Id = idToChangeTo;
                    }
                }
            }
            if (recalculateEnergy)
            {
                CalculateMinMaxEnergy();
            }
        }

        internal void GenerateCellBoundary(int x, int y, int size)
        {
            nextStepGrid.Copy(currentGrid);
            currentGrid = GrainBoundary.GenerateSelectedGrainCellBoundary(nextStepGrid, x,y, size);
        }

        /// <summary>
        /// Return true if cell changed status to aggregaded
        /// </summary>
        /// <param name="x">Column number of cell to change</param>
        /// <param name="y">Row number of cell to change</param>
        /// <returns></returns>
        public bool ChangeGridValue(int x, int y)
        {
            currentGrid.ChangeCellValue(x, y);
            currentGrid.Cells[x, y].Id = CurrentNucleonID;
            CalculateMinMaxEnergy();
            if (currentGrid.Cells[x, y].State == 0)
            {
                emptyCount++;
                return false;
            }
            else
            {
                emptyCount--;
                return true;
            }
        }

        public bool ChangeGridValue(int x, int y, int id)
        {
            currentGrid.ChangeCellValue(x, y, id);
            CalculateMinMaxEnergy();
            if (currentGrid.Cells[x, y].State == 0)
            {
                emptyCount++;
                return false;
            }
            else
            {
                emptyCount--;
                return true;
            }
        }

        public void ChangeCurrentNucleonID()
        {
            CurrentNucleonID++;
            CurrentNucleonID = CurrentNucleonID % nucleonsPopulation;
        }

        public void RandomPopulate(int nPopulation)
        {
            if (nPopulation > Grid.SizeX * Grid.SizeY || nPopulation <= 0)
            {
                return;
            }
            nucleonsPopulation = nPopulation;
            //ClearGrid();
            int gridSize = Grid.SizeX * Grid.SizeY;
            List<Model.Point> start = new List<Model.Point>();
            Point buff;
            Random r = new Random();
            int failedCounter = 0;
            for (int i = 0; i < nucleonsPopulation;)
            {
                buff = new Point(r.Next(0, Grid.SizeX), r.Next(0, Grid.SizeY));
                if (currentGrid.Cells[buff.X,buff.Y].State == 0)
                {
                    start.Add(buff);
                    i++;
                    failedCounter = 0;
                }
                else
                {
                    failedCounter++;
                    if(failedCounter > 10)
                    {
                        break;
                    }
                }
            }
            Populate(start, nucleonsPopulation);
            CalculateMinMaxEnergy();
        }
        void Populate(List<Model.Point> start, int nPopulation)
        {
            foreach (Model.Point p in start)
            {
                currentGrid.ChangeCellValue(p.X, p.Y, CurrentNucleonID, 1);
                CurrentNucleonID++;
                CurrentNucleonID = CurrentNucleonID % nPopulation;
                emptyCount--;
            }

        }
        void CalculateNextStepWithFourMooreRules(int startX, int startY, int endX, int endY)
        {
            Random r = new Random();
            nextStepGrid.Copy(currentGrid, startX, startY, endX, endY);
            List<Model.Point> n;
            Dictionary<int, int> cellIDCount = new Dictionary<int, int>();
            bool changeValue = false;
            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    changeValue = false;
                    if (currentGrid.Cells[x, y].State != 0)
                    {
                        continue;
                    }

                    n = Neighbourhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, BoundaryCondition);

                    int cellID = 0;

                    Dictionary<int, int> counts = n.FindAll(p => currentGrid.Cells[p.X, p.Y].State == 1)
                        .GroupBy(p => currentGrid.Cells[p.X, p.Y].Id)
                        .ToDictionary(v => v.Key, v => v.Count());

                    if(counts.Count == 0)
                    {
                        continue;
                    }

                    if (counts.Any(e => e.Value > 5)) //RULE 1
                    {
                        changeValue = true;
                        cellID = counts.Aggregate((l, v) => l.Value > v.Value ? l : v).Key;
                    }
                    else // RULE 2
                    {
                        counts = n.Where((p, i) => i == 1 || i == 3 || i == 4 || i == 6)
                            .ToList().FindAll(p => currentGrid.Cells[p.X, p.Y].State == 1)
                            .GroupBy(p => currentGrid.Cells[p.X, p.Y].Id)
                            .ToDictionary(v => v.Key, v => v.Count());

                        if (counts.Any(e => e.Value > 3))
                        {
                            changeValue = true;
                            cellID = counts.Aggregate((l, v) => l.Value > v.Value ? l : v).Key;
                        }
                        else // RULE 3
                        {
                            counts = n.Where((p, i) => i == 0 || i == 2 || i == 5 || i == 7)
                                .ToList().FindAll(p => currentGrid.Cells[p.X, p.Y].State == 1)
                                .GroupBy(p => currentGrid.Cells[p.X, p.Y].Id)
                                .ToDictionary(v => v.Key, v => v.Count());
                            if (counts.Any(e => e.Value > 3))
                            {
                                changeValue = true;
                                cellID = counts.Aggregate((l, v) => l.Value > v.Value ? l : v).Key;
                            }
                            else // RULE 4
                            {
                                counts = n.FindAll(p => currentGrid.Cells[p.X, p.Y].State == 1)
                                    .GroupBy(p => currentGrid.Cells[p.X, p.Y].Id)
                                    .ToDictionary(v => v.Key, v => v.Count());
                                if (ProbabilityOfChange >= r.Next(100) && counts.Count > 0)
                                {
                                    changeValue = true;
                                    cellID = counts.Aggregate((l, v) => l.Value > v.Value ? l : v).Key;
                                }
                            }
                        }
                    }

                    if (changeValue)
                    {
                        lock (synLock)
                        {
                            emptyCount--;
                            nextStepGrid.Cells[x, y].ChangeState(1);
                            nextStepGrid.Cells[x, y].Id = cellID;
                        }
                    }
                }
            }
        }

        internal bool GetCurrentGridCellRecrystallized(int x, int y)
        {
            return currentGrid.Cells[x, y].Recrystallized;
        }

        void CalculateNextStepStandard(int startX, int startY, int endX, int endY)
        {
            Random r = new Random();
            nextStepGrid.Copy(currentGrid, startX, startY, endX, endY);
            List<Point> n;
            List<int> a = new List<int>();

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    if (currentGrid.Cells[x, y].State != 0)
                    {
                        continue;
                    }

                    n = Neighbourhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, BoundaryCondition);
                    a.Clear();

                    n.FindAll(p => currentGrid.Cells[p.X, p.Y].State == 1).ForEach(p => a.Add(currentGrid.Cells[p.X, p.Y].Id));

                    Dictionary<int, int> counts = a.GroupBy(v => v)
                                      .ToDictionary(g => g.Key,
                                                    g => g.Count());
                    int max = 0;
                    int k = 0;
                    foreach (int key in counts.Keys)
                    {
                        if (max < counts[key])
                        {
                            max = counts[key];
                            k = key;
                        }
                        else if (max == counts[key] && r.NextDouble() > 0.5)
                        {
                            k = key;
                        }
                    }

                    if (max > 0)
                    {
                        lock (synLock)
                        {
                            emptyCount--;
                            nextStepGrid.Cells[x, y].ChangeState(1);
                            nextStepGrid.Cells[x, y].Id = k;
                        }
                    }
                }
            }
        }
        internal void SetNucleonsPopulationDecimal(int v)
        {
            nucleonsPopulation = v;
        }

        public void Continue(IProgress<int> progress, int rule)
        {
            int nThreads = 4;
            Thread[] calculations = new Thread[nThreads];
            int halfSizeX = Grid.SizeX / 2;
            int halfSizeY = Grid.SizeY / 2;
            int gridSize = Grid.SizeX * Grid.SizeY;
            running = true;

            emptyCount = Grid.SizeX * Grid.SizeY;

            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if (currentGrid.Cells[x, y].State != 0)
                    {
                        emptyCount--;
                    }
                }
            }

            Action<int, int, int, int> calculation;
            if(rule == 0)
            {
                calculation = CalculateNextStepStandard;
            }
            else
            {
                calculation = CalculateNextStepWithFourMooreRules;
            }

            while (running && emptyCount > 0)
            {
                calculations[0] = new Thread(() => calculation(0, 0, halfSizeX, halfSizeY));
                calculations[1] = new Thread(() => calculation(halfSizeX, 0, Grid.SizeX, halfSizeY));
                calculations[2] = new Thread(() => calculation(0, halfSizeY, halfSizeX, Grid.SizeY));
                calculations[3] = new Thread(() => calculation(halfSizeX, halfSizeY, Grid.SizeX, Grid.SizeY));
                foreach (Thread task in calculations)
                {
                    task.Start();
                }
                foreach (Thread task in calculations)
                {
                    task.Join();
                }
                currentGrid.Copy(nextStepGrid);
                progress.Report((gridSize - emptyCount) * 100 / gridSize);
            }

            CalculateMinMaxEnergy();
            running = false;
        }

        public void StopExecution()
        {
            lock (synLock)
            {
                running = false;
                CalculateMinMaxEnergy();
            }
        }

        public Grid GetCurrentGrid()
        {
            return currentGrid;
        }
        /// <summary>
        /// Method constructs grid from Dictionary of UInt32 Keys (Grain ID)
        /// and list of point in this grain.
        /// </summary>
        /// <param name="grains"></param>
        public void SetGridFromPointsDictionary(Dictionary<int, List<Point>> grains)
        {
            emptyCount = Grid.SizeX * Grid.SizeY;
            int currentID = 0;
            bool inclusionsPresent = false;
            
            int grainState;

            foreach (int key in grains.Keys)
            {
                grainState = key == -16777216 ? 2 : 1; //If black color then it is inclusion
                grainState = key != -256 ? grainState : 3;

                if(grainState == 2)
                {
                    inclusionsPresent = true;
                }
                foreach (Point p in grains[key])
                {
                    currentGrid.ChangeCellValue(p.X, p.Y, currentID, grainState);
                    emptyCount--;
                }
                currentID++;
            }

            if(inclusionsPresent)
            {
                this.nucleonsPopulation = grains.Keys.Count-1 > 0 ? grains.Keys.Count-1 : 1;
            }
            else
            {
                this.nucleonsPopulation = grains.Keys.Count > 0 ? grains.Keys.Count : 1;
            }
            CalculateMinMaxEnergy();
        }

        internal string GetBoundaryPercentSize()
        {
            string output = "";
            float gbSize = 0f;
            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if(currentGrid.Cells[x,y].State == 2)
                    {
                        gbSize++;
                    }
                }
            }
            gbSize *= 100;
            float percent = gbSize/(float)(Grid.SizeX * Grid.SizeY);
            output = string.Format((int)percent+"%");

            return output;
        }

        internal void RandomAllPopulate(int statesAmount)
        {
            Random r = new Random();
            for(int x = 0; x < Grid.SizeX; x++)
            {
                for(int y = 0; y < Grid.SizeY; y++)
                {
                    if (currentGrid.Cells[x, y].State == 0)
                    {
                        currentGrid.Cells[x, y].Id = r.Next(0, statesAmount);
                        currentGrid.Cells[x, y].State = 1;
                    }
                }
            }
            emptyCount = 0;
            nextStepGrid.Copy(nextStepGrid);
            CalculateMinMaxEnergy();
        }

        internal void GenerateAllBoundaries(int size)
        {
            List<Point> gbPoints = GrainBoundary.GenerateAllGrainBoundaries(currentGrid, size);
            foreach(Point p in gbPoints)
            {
                currentGrid.Cells[p.X, p.Y].State = 2;
                currentGrid.Cells[p.X, p.Y].Id = -1;
            }
        }

        internal void SetEnergyOnBoundaries(int size, int energyValue)
        {
            List<Point> gbPoints = GrainBoundary.GenerateAllGrainBoundaries(currentGrid, size);
            foreach (Point p in gbPoints)
            {
                currentGrid.Cells[p.X, p.Y].Energy = energyValue;
            }

            maxEnergy = maxEnergy < energyValue ? energyValue : maxEnergy;
            CalculateMinMaxEnergy();
        }
        internal void SetEnergyOnInside(int size, int energyValue)
        {
            List<Point> gbPoints = GrainBoundary.GenereteAllGrainWithoutBoundaries(currentGrid, size);

            foreach(Point p in gbPoints)
            {
                currentGrid.Cells[p.X, p.Y].Energy = energyValue;
            }
            CalculateMinMaxEnergy();
        }

        internal void ClearUnselectedGrains()
        {
            emptyCount = Grid.SizeX * Grid.SizeY;

            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if (currentGrid.Cells[x, y].State != 3 && currentGrid.Cells[x, y].State != 2 && currentGrid.Cells[x, y].State != 4)
                    {
                        currentGrid.ChangeCellValue(x, y, 0, 0);
                        emptyCount--;
                    }
                }
            }
        }

        internal int GetMonteCarloIteration()
        {
            return mcEngine.currentIteration;
        }

        internal void RunIterationsMonteCarlo(IProgress<string> progress, int maxIterations)
        {
            Thread t = new Thread(() => RunMonteCarlo());
            running = true;
            while (running && mcEngine.currentIteration < maxIterations)
            {
                t = new Thread(() => RunMonteCarlo());
                t.Start();
                t.Join();
                progress.Report(mcEngine.currentIteration.ToString());
            }

        }

        internal int NumberOfDifferendNeighbors(int x, int y)
        {
            return Neighbourhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, BoundaryCondition)
                .Where(p => currentGrid.Cells[x, y].Id != currentGrid.Cells[p.X, p.Y].Id).Count();
        }

        internal void RunMonteCarlo()
        {
            mcEngine.Run(ref currentGrid);
            mcEngine.NextIteration();
        }

        /// <summary>
        /// Generates inclusions which don't take part in growth process
        /// </summary>
        /// <param name="selectedIndex">0 - Square, 1 - Circle</param>
        /// <param name="value">Length/Radius of inclusion</param>
        /// <param name="amount">Amount of inclusions</param>
        internal void GenerateInclusions(int selectedIndex, int value, int amount)
        {

            if (selectedIndex == 0)
            {
                InclusionManager = new SquareInclusionManager();
            }
            else if (selectedIndex == 1)
            {
                InclusionManager = new CircuralInclusionManager();
            }
            InclusionManager.GenerateInclusions(ref currentGrid, amount, value, Neighbourhood, BoundaryCondition);
        }

        internal int GetCurrentGridCellEnergy(int x, int y, bool withNeighboors = false)
        {
            int grainEnergy = currentGrid.Cells[x, y].Energy; 
            if(withNeighboors)
            {
                grainEnergy += NumberOfDifferendNeighbors(x, y);
            }
            grainEnergy *= 100;
            return (grainEnergy) / (maxEnergy + 4);
        }

        private void CalculateMinMaxEnergy()
        {
            int tempMin = 0;
            int tempMax = 0;

            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if (currentGrid.Cells[x, y].State == 1)
                    {
                        int energy = currentGrid.Cells[x, y].Energy;
                        if (energy < tempMin)
                        {
                            tempMin = energy;
                        }
                        else if (energy > tempMax)
                        {
                            tempMax = energy;
                        }
                    }
                }
            }
            maxEnergy = tempMax + 1;
            minEnergy = tempMin;
        }

        internal void SetEnergyAll(int energyValue)
        {
            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    currentGrid.Cells[x, y].Energy = energyValue;
                }
            }

            CalculateMinMaxEnergy();
        }

        internal void RandomPlacementRecrystallizationAnywhere(int nucleonsCount)
        {
            int maxIterationsCount = 50;
            int currentIterationCount = 0;

            Random r = new Random();

            for(int i = 0; i < nucleonsCount; )
            {
                int x = r.Next(0, Grid.SizeX);
                int y = r.Next(0, Grid.SizeY);

                if (!currentGrid.Cells[x, y].Recrystallized &&
                    currentGrid.Cells[x,y].State == 1 )
                {
                    currentGrid.Cells[x, y].Recrystallized = true;
                    currentGrid.Cells[x, y].Id = i;
                    currentIterationCount = 0;
                }
                else
                {
                    currentIterationCount++;
                    
                    if(currentIterationCount < maxIterationsCount)
                    {
                        continue;
                    }

                    break;
                }

                i++;
            }

        }

        internal void RandomPlacementRecrystallizationGrainBoundries(int nucleonsCount, int gbSize)
        {
            List<Point> gbPoints = GrainBoundary.GenerateAllGrainBoundaries(currentGrid, gbSize);

            gbPoints = gbPoints.Where(p => !currentGrid.Cells[p.X, p.Y].Recrystallized).ToList();

            if(gbPoints.Count > 0)
            {
                int gbCount = Math.Min(gbPoints.Count, nucleonsCount);
                gbPoints.Shuffle();
                for(int i = 0; i < gbCount; i++)
                {
                    currentGrid.Cells[gbPoints[i].X, gbPoints[i].Y].Recrystallized = true;
                    currentGrid.Cells[gbPoints[i].X, gbPoints[i].Y].Id = i;
                }
            }
        }

        internal void RemoveRecrystallizationStatus()
        {
            for(int x = 0; x < Grid.SizeX; x++)
            {
                for(int y = 0; y < Grid.SizeY; y++)
                {
                    currentGrid.Cells[x, y].Recrystallized = false;
                }
            }
            rcEngine.ResetCurrentIteration();
        }

        public void RunIterationsRecrystallization(IProgress<string> progress, int maxIterations, 
            int nucleonsCount = 0, int gbSize = 0,int applayMode = 2,int applayPlace = 0)
        {

            Thread t = new Thread(() => RunRecrystallization(nucleonsCount,gbSize,applayMode,applayPlace));
            running = true;
            while (running && rcEngine.currentIteration < maxIterations)
            {
                t = new Thread(() => RunRecrystallization(nucleonsCount, gbSize, applayMode, applayPlace));
                t.Start();
                t.Join();
                progress.Report(rcEngine.currentIteration.ToString());
            }
        }

        public void RunRecrystallization(int nucleonsCount = 0, int gbSize = 0, int applayMode = 2, int applayPlace = 0)
        {
            if(applayMode == 0)
            {
                
                if(applayPlace == 0)
                {
                    RandomPlacementRecrystallizationAnywhere(nucleonsCount);
                }
                else if(applayPlace == 1)
                {
                    RandomPlacementRecrystallizationGrainBoundries(nucleonsCount,gbSize);
                }
            }
            else if(applayMode==1)
            {
                nucleonsCount *= (rcEngine.currentIteration + 1);
                if (applayPlace == 0)
                {
                    RandomPlacementRecrystallizationAnywhere(nucleonsCount);
                }
                else if (applayPlace == 1)
                {
                    RandomPlacementRecrystallizationGrainBoundries(nucleonsCount, gbSize);
                }
            }
            rcEngine.Run(ref currentGrid);
            rcEngine.NextIteration();
        }

        internal int GetRecrystallizationIteration()
        {
            return rcEngine.currentIteration; 
        }

        #endregion
    }
}
