using System;
using System.Collections.Generic;
using MultiscaleModeling.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiscaleModeling.Model.Neighbourhood;

namespace MultiscaleModeling.Model.Inclusions
{
    abstract class InclusionManager
    {
        
        public bool GenerateInclusions(ref Grid grid, int amount, int value, Neighbourhood.Neighbourhood neighbourhood, BoundaryCondition boundaryCondition)
        {
            ChangeGridCellsToInclusion(ref grid, amount, value, GetInclusionStartPointsOnBoundaries(grid, amount, neighbourhood, boundaryCondition));
            return true;
        }

        public abstract void ChangeGridCellsToInclusion(ref Grid grid, int amount, int value, List<Point> list);

        List<Point> GetInclusionStartingPointsAtBegining(Grid grid, int amount)
        {
            List <Point> inclusionsStartingPoints = new List<Point>();
            Point buffer;
            int gridSize = Grid.SizeX * Grid.SizeY;
            Random r = new Random();
            for (int i = 0; i < amount;)
            {
                buffer = new Point(r.Next(0, Grid.SizeX), r.Next(0, Grid.SizeY));
                if (!inclusionsStartingPoints.Contains<Point>(buffer))
                {
                    inclusionsStartingPoints.Add(buffer);
                    i++;
                }
            }

            return inclusionsStartingPoints;
        }

        List<Point> GetInclusionStartPointsOnBoundaries(Grid grid, int amount, Neighbourhood.Neighbourhood neighbourhood, BoundaryCondition boundaryCondition)
        {
            List<Point> inclusionsStartingPoints = new List<Point>();
            List<Point> neighbourhoodPoints = new List<Point>();

            for(int x = 0; x < Grid.SizeX; x++)
            {
                for(int y = 0; y < Grid.SizeY;y++)
                { 
                    neighbourhoodPoints = neighbourhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, boundaryCondition);

                    if(neighbourhoodPoints.Any(p =>
                        (grid.Cells[p.X, p.Y].Id != grid.Cells[x, y].Id
                        || grid.Cells[p.X, p.Y].State == 0) && grid.Cells[x,y].Id != 2
                        )
                    )
                    {
                        inclusionsStartingPoints.Add(new Point(x, y));
                    }
                    
                }
            }

            Shuffle(inclusionsStartingPoints);
            return inclusionsStartingPoints.Take(amount).ToList();
        }

        void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
