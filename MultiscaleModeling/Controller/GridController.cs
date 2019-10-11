using System;
using System.Collections.Generic;
using System.Linq;
using MultiscaleModeling.Model;
using System.Threading;
using MultiscaleModeling.Model.Neighbourhood;

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
        int emptyCount = 0;
        #endregion

        #region NUCLEONS
        int nucleonsPopulation;
        public int CurrentNucleonID { get; private set; }
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
        }
        public GridController(int gridWidth, int gridHeight)
        {
            currentGrid = new Grid(gridWidth,gridHeight);
            nextStepGrid = new Grid(gridWidth, gridHeight);
            nucleonsPopulation = 1;
            CurrentNucleonID = 0;
            emptyCount = Grid.SizeX * Grid.SizeY;
        }
        public GridController(int gridWidth, int gridHeight, int nucleonsPopulation)
        {
            currentGrid = new Grid(gridWidth, gridHeight);
            nextStepGrid = new Grid(gridWidth, gridHeight);
            this.nucleonsPopulation = nucleonsPopulation;
            CurrentNucleonID = 0;
            emptyCount = Grid.SizeX * Grid.SizeY;
        }
        #endregion
        /// <summary>
        /// Returns true if cell is aggregaded
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool GetCurrentGridCellState(int x, int y)
        {
            return currentGrid.Cells[x, y].State != 0;
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
            ClearGrid();

            List<Model.Point> freePoints = new List<Model.Point>();
            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    freePoints.Add(new Model.Point(x, y));
                }
            }

            List<Model.Point> start = new List<Model.Point>();

            Random r = new Random();
            for (int i = 0; i < nucleonsPopulation;)
            {

                int index = r.Next(0, freePoints.Count());

                start.Add(freePoints[index]);
                freePoints.RemoveAt(index);
                i++;
            }
            Populate(start, nucleonsPopulation);
        }
        void Populate(List<Model.Point> start, int nPopulation)
        {
            foreach (Model.Point p in start)
            {
                currentGrid.ChangeCellValue(p.X, p.Y);
                currentGrid.Cells[p.X, p.Y].Id = CurrentNucleonID;
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
                            nextStepGrid.Cells[x, y].ChangeState();
                            nextStepGrid.Cells[x, y].Id = k;
                        }
                    }
                }
            }
        }

        public void Continue(IProgress<string> progress)
        {
            int nThreads = 4;
            Thread[] calculations = new Thread[nThreads];
            int x = Grid.SizeX / 2;
            int y = Grid.SizeY / 2;

            running = true;

            long current = DateTime.Now.Ticks;
            while (running && emptyCount > 0)
            {
                calculations[0] = new Thread(() => CalculateNextStep(0, 0, x, y));
                calculations[1] = new Thread(() => CalculateNextStep(x, 0, Grid.SizeX, y));
                calculations[2] = new Thread(() => CalculateNextStep(0, y, x, Grid.SizeY));
                calculations[3] = new Thread(() => CalculateNextStep(x, y, Grid.SizeX, Grid.SizeY));
                foreach (Thread task in calculations)
                {
                    task.Start();
                }
                foreach (Thread task in calculations)
                {
                    task.Join();
                }
                currentGrid.Copy(nextStepGrid);

            }
            running = false;
        }
        #endregion

    }
}
