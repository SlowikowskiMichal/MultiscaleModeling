using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiscaleModeling.Model.Neighbourhood;

namespace MultiscaleModeling.Model
{
    public class MonteCarloEngine
    {
        public int currentIteration { get; private set; }

        public MonteCarloEngine()
        {
            currentIteration = 0;
        }

        public void ResetCurrentIteration()
        {
            currentIteration = 0;
        }

        public void NextIteration()
        {
            currentIteration++;
        }

        internal void Run(ref Grid currentGrid)
        {
            Neighbourhood.Neighbourhood n = new MooresNeighbourhood();

            Random r = new Random();

            List<Point> listOfPoints = ShuffleCells(Grid.SizeX,Grid.SizeY, currentGrid);


            foreach (Point c in listOfPoints)
            {
                List<Point> buff = n.GetNeighborhood(c.X, c.Y, Grid.SizeX, Grid.SizeY);

                List<Point> nCoord = new List<Point>();

                foreach (Point p in buff)
                {
                    if (currentGrid.Cells[p.X, p.Y].State == 1)
                    {
                        nCoord.Add(new Point(p.X, p.Y));
                    }
                }

                if (nCoord.Count == 0)
                {
                    break;
                }

                int currentId = currentGrid.Cells[c.X, c.Y].Id;
                int currentEnergy = 0;
                int afterEnergy = 0;

                foreach (Point p in nCoord)
                {
                    if (currentGrid.Cells[p.X, p.Y].Id != currentId && currentGrid.Cells[p.X, p.Y].State == 1)
                    {
                        currentEnergy++;
                    }
                }
                int newCoordIndex = r.Next(0, nCoord.Count);
                currentGrid.Cells[c.X, c.Y].Id = currentGrid.Cells[nCoord[newCoordIndex].X, nCoord[newCoordIndex].Y].Id;

                foreach (Point p in nCoord)
                {
                    if (currentGrid.Cells[p.X, p.Y].Id != currentGrid.Cells[c.X, c.Y].Id && currentGrid.Cells[p.X, p.Y].State == 1)
                    {
                        afterEnergy++;
                    }
                }
                if (afterEnergy > currentEnergy)
                {
                    currentGrid.Cells[c.X, c.Y].Id = currentId;
                }
                else
                {
                    currentGrid.Cells[c.X, c.Y].Energy = currentGrid.Cells[nCoord[newCoordIndex].X, nCoord[newCoordIndex].Y].Energy;
                }
            }
        }

        private List<Point> ShuffleCells(int sizeX, int sizeY, Grid grid)
        {
            List<Point> pointsToReturn = new List<Point>();

            for(int x = 0; x < sizeX; x++)
            {
                for(int y = 0; y < sizeY; y++)
                {
                    if (grid.Cells[x, y].State == 1)
                    {
                        pointsToReturn.Add(new Point(x, y));
                    }
                }
            }

            Shuffle(pointsToReturn);


            return pointsToReturn;
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
