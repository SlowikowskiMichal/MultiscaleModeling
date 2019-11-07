using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model
{
    static public class GrainBoundary
    {
        static public Grid GenerateAllGrainBoundaries(Grid grid, int size)
        {
            Grid bufferGrid = new Grid(Grid.SizeX,Grid.SizeY);
            bufferGrid.Copy(grid);

            int currentID = -1;

            int minX;
            int maxX;
            int minY;
            int maxY;
            int maxGridXIndex = Grid.SizeX - 1;
            int maxGridYIndex = Grid.SizeY - 1;
            for (int y = 0; y < Grid.SizeY; y++)
            {
                for(int x = 0; x < Grid.SizeX; x++)
                {
                    currentID = grid.Cells[x, y].Id;

                    minX = Math.Max(0, x - size);
                    minY = Math.Max(0, y - size);
                    maxX = Math.Min(maxGridXIndex, x + size);
                    maxY = Math.Min(maxGridYIndex, y + size);


                    for(int i = minX; i < maxX; i++)
                    {
                        for(int j = minY; j < maxY; j++)
                        {
                            if(grid.Cells[i,j].Id != currentID && grid.Cells[i, j].State != 2)
                            {
                                grid.Cells[x, y].State = 2;
                                grid.Cells[x, y].Id = -1;
                            }
                        }
                    }
                }
            }

            return grid;
        }
    }
}
