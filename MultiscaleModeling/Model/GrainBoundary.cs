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
                                bufferGrid.Cells[x, y].State = 2;
                                bufferGrid.Cells[x, y].Id = -1;
                            }
                        }
                    }
                }
            }

            return bufferGrid;
        }

        internal static Grid GenerateSelectedGrainCellBoundary(Grid grid, int x, int y, int size)
        {
            Grid bufferGrid = new Grid(Grid.SizeX, Grid.SizeY);
            bufferGrid.Copy(grid);
            Neighbourhood.Neighbourhood neighbourhood = new Neighbourhood.MooresNeighbourhood();
            int minX;
            int maxX;
            int minY;
            int maxY;
            int maxGridXIndex = Grid.SizeX - 1;
            int maxGridYIndex = Grid.SizeY - 1;

            int cellID = grid.Cells[x, y].Id;
            int top = y;
            List<Point> listOfPoints = new List<Point>();

            for (int j = 0; j < Grid.SizeY; j++)
            {
                for (int i = 0; i < Grid.SizeX; i++)
                {
                    if(grid.Cells[i, j].Id == cellID)
                    {
                        listOfPoints.Add(new Point(i, j));
                    }
                }
            }
            foreach(Point p in listOfPoints)
            {
                List<Point> n = neighbourhood.GetNeighborhood(p.X,p.Y,Grid.SizeX,Grid.SizeY,Neighbourhood.BoundaryCondition.Periodic);
                foreach(Point c in n.Where(a => grid.Cells[a.X,a.Y].Id != cellID && grid.Cells[a.X, a.Y].State != 2))
                {
                    minX = Math.Max(0, c.X - size);
                    minY = Math.Max(0, c.Y - size);
                    maxX = Math.Min(maxGridXIndex, c.X + size);
                    maxY = Math.Min(maxGridYIndex, c.Y + size);
                    for (int i = minX; i < maxX; i++)
                    {
                        for (int j = minY; j < maxY; j++)
                        {
                            bufferGrid.Cells[i, j].State = 2;
                            bufferGrid.Cells[i, j].Id = -1;
                        }
                    }
                }
            }

            return bufferGrid;
        }
    }
}
