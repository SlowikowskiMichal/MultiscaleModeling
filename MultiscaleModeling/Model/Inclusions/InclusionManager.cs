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
        
        public bool GenerateInclusions(ref Grid grid, int amount, int value)
        {
            throw new NotImplementedException();
        }

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
            Point buffer;

            for(int x = 0; x < Grid.SizeX; x++)
            {
                for(int y = 0; y < Grid.SizeY;y++)
                {

                    neighbourhoodPoints = neighbourhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, boundaryCondition);
                }
            }
            throw new NotImplementedException();
        }
    }
}
