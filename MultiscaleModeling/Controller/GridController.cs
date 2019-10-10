using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MultiscaleModeling.Model;
namespace MultiscaleModeling.Controller
{
    class GridController
    {
        #region ATTRIBUTES

        readonly static object synLock = new object();

        #region GRID
        Grid currentGrid;
        Grid nextStepGrid;
        int emptyCount = 0;
        #endregion

        #region NUCLEONS
        int nucleonsPopulation;
        public int CurrentNucleonID { get; private set; }
        #endregion

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

        #endregion

    }
}
