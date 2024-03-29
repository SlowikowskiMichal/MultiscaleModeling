﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model.Neighbourhood
{
    class MooresNeighbourhood : Neighbourhood
    {
        override public List<Point> GetNeighborhood(int CellX, int CellY, int SizeX, int SizeY, BoundaryCondition condition)
        {
            List<Point> cellNeighborIndexes = new List<Point>();

            cellNeighborIndexes.Add(new Point(CellX - 1, CellY - 1));
            cellNeighborIndexes.Add(new Point(CellX - 1, CellY));
            cellNeighborIndexes.Add(new Point(CellX - 1, CellY + 1));
            cellNeighborIndexes.Add(new Point(CellX, CellY - 1));
            cellNeighborIndexes.Add(new Point(CellX, CellY + 1));
            cellNeighborIndexes.Add(new Point(CellX + 1, CellY - 1));
            cellNeighborIndexes.Add(new Point(CellX + 1, CellY));
            cellNeighborIndexes.Add(new Point(CellX + 1, CellY + 1));

            CheckForBoundaryCondition(cellNeighborIndexes, SizeX, SizeY, condition);
            return cellNeighborIndexes;
        }
    }
}
