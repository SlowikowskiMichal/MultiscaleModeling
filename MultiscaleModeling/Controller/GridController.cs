﻿using System;
using System.Collections.Generic;
using System.Linq;
using MultiscaleModeling.Model;
using System.Threading;
using MultiscaleModeling.Model.Neighbourhood;
using System.Windows.Forms;
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
        #endregion

        #region INCLUSIONS
        InclusionManager InclusionManager;
        #endregion

        #region B/N CONDITIONS
        public Neighbourhood Neighbourhood { get; private set; }
        public BoundaryCondition BoundaryCondition { get; private set; }
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
        }
        public GridController(int gridWidth, int gridHeight)
        {
            currentGrid = new Grid(gridWidth, gridHeight);
            nextStepGrid = new Grid(gridWidth, gridHeight);
            nucleonsPopulation = 1;
            CurrentNucleonID = 0;
            emptyCount = Grid.SizeX * Grid.SizeY;
            ProbabilityOfChange = 100;
        }
        public GridController(int gridWidth, int gridHeight, int nucleonsPopulation)
        {
            currentGrid = new Grid(gridWidth, gridHeight);
            nextStepGrid = new Grid(gridWidth, gridHeight);
            this.nucleonsPopulation = nucleonsPopulation;
            CurrentNucleonID = 0;
            emptyCount = Grid.SizeX * Grid.SizeY;
            ProbabilityOfChange = 100;
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
            currentGrid.Resize(width, height);
            nextStepGrid.Resize(width, height);
            emptyCount = Grid.SizeX * Grid.SizeY;
        }
        public void ClearGrid()
        {
            currentGrid.Clear();
            nextStepGrid.Clear();
            emptyCount = Grid.SizeX * Grid.SizeY;
        }

        internal void selectGrainForDP(int cellPosX, int cellPosY, int selectionType)
        {
            if (currentGrid.Cells[cellPosX, cellPosY].State == 2)
            {
                return;
            }

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
        void CalculateNextStep(int startX, int startY, int endX, int endY)
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

        internal void SetNucleonsPopulationDecimal(int v)
        {
            nucleonsPopulation = v;
        }

        public void Continue(IProgress<int> progress)
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

            while (running && emptyCount > 0)
            {
                calculations[0] = new Thread(() => CalculateNextStep(0, 0, halfSizeX, halfSizeY));
                calculations[1] = new Thread(() => CalculateNextStep(halfSizeX, 0, Grid.SizeX, halfSizeY));
                calculations[2] = new Thread(() => CalculateNextStep(0, halfSizeY, halfSizeX, Grid.SizeY));
                calculations[3] = new Thread(() => CalculateNextStep(halfSizeX, halfSizeY, Grid.SizeX, Grid.SizeY));
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
            running = false;
        }

        public void StopExecution()
        {
            lock (synLock)
            {
                running = false;
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
        }

        internal string GetBoundaryPercentSize()
        {
            string output = "";
            int gbSize = 0;
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
            int percent = gbSize/(Grid.SizeX * Grid.SizeY);
            output = string.Format($"{0}%", percent);

            return output;
        }

        internal void GeneratePointBoundaries(int x, int y)
        {
            throw new NotImplementedException();
        }

        internal void GenerateAllBoundaries(int size)
        {
            currentGrid = GrainBoundary.GenerateAllGrainBoundaries(currentGrid, size);
        }

        internal void ClearUnselectedGrains()
        {
            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if (currentGrid.Cells[x, y].State != 3 && currentGrid.Cells[x, y].State != 2 && currentGrid.Cells[x, y].State != 4)
                    {
                        currentGrid.ChangeCellValue(x, y, 0, 0);
                    }
                }
            }
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
        #endregion

    }
}
