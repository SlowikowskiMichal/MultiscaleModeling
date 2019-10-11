using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model.Neighbourhood
{
    enum BoundaryCondition { Periodic = 0, Reflective = 1 };

    abstract class Neighbourhood
    {
        public abstract List<Point> GetNeighborhood(int CellX, int CellY, int SizeX, int SizeY, BoundaryCondition condition);

        protected void CheckForBoundaryCondition(List<Point> cellNeighborIndexes, int SizeX, int SizeY, BoundaryCondition boundary)
        {

            Func<int, int, int> lessThanZero;
            Func<int, int, int> moreThanSize;


            if (boundary == BoundaryCondition.Periodic)
            {
                lessThanZero = PeriodicLessThanZero;
                moreThanSize = PeriodicMoreThanZero;
            }
            else if (boundary == BoundaryCondition.Reflective)
            {
                lessThanZero = ReflectiveLessThanZero;
                moreThanSize = ReflectiveMoreThanZero;
            }
            else
            {
                lessThanZero = FixedLessThanZero;
                moreThanSize = FixedMoreThanZero;

            }
            foreach (Point p in cellNeighborIndexes)
            {
                if (p.X < 0)
                {
                    p.X = lessThanZero(p.X, SizeX);
                }
                else if (p.X >= SizeX)
                {
                    p.X = moreThanSize(p.X, SizeX);
                }

                if (p.Y < 0)
                {
                    p.Y = lessThanZero(p.Y, SizeY);
                }
                else if (p.Y >= SizeY)
                {
                    p.Y = moreThanSize(p.Y, SizeY);
                }
            }
        }

        private int FixedLessThanZero(int p, int size)
        {
            return -1;
        }

        private int FixedMoreThanZero(int p, int size)
        {
            return -1;
        }

        protected int PeriodicLessThanZero(int p, int size)
        {
            int b;
            if (size == 1)
            {
                b = 0;
            }
            else
            {
                b = size - (Math.Abs(p) % size);
            }

            return b;
        }

        protected int PeriodicMoreThanZero(int p, int size)
        {
            return p % size;
        }
        protected int ReflectiveLessThanZero(int p, int size)
        {
            return 0;
        }

        protected int ReflectiveMoreThanZero(int p, int size)
        {
            return size - 1;
        }

    }
}
