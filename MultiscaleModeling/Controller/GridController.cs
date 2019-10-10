using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiscaleModeling.Model;
namespace MultiscaleModeling.Controller
{
    class GridController
    {
        //GRID
        const int sizeX = 1;
        const int sizeY = 1;
        float cellXSize;
        float cellYSize;
        Grid currentGrid;
        Grid nextStepGrid;
        int emptyCount = 0;
        int currentPositionX = 0;
        int currentPositionY = 0;
    }
}
