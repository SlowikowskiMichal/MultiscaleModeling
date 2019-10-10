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
        #endregion

        #endregion

        #region METHODS
        #region CONSTRUCTORS

        public GridController()
        {
            currentGrid = new Grid();
            nextStepGrid = new Grid();
            nucleonsPopulation = 1;
        }
        public GridController(int gridWidth, int gridHeight)
        {
            currentGrid = new Grid(gridWidth,gridHeight);
            nextStepGrid = new Grid(gridWidth, gridHeight);
            nucleonsPopulation = 1;
        }
        public GridController(int gridWidth, int gridHeight, int nucleonsPopulation)
        {
            currentGrid = new Grid(gridWidth, gridHeight);
            nextStepGrid = new Grid(gridWidth, gridHeight);
            this.nucleonsPopulation = nucleonsPopulation;
        }
        #endregion

        public int GetCurrentGridCellState(int x, int y)
        {
            return currentGrid.Cells[x, y].State;
        }

        public bool ResizeGrid(int width, int height)
        {
            return currentGrid.Resize(width, height) && nextStepGrid.Resize(width, height);
        }

        public void ClearGrid()
        {
            currentGrid.Clear();
            nextStepGrid.Clear();
        }

        #endregion

    }
}
