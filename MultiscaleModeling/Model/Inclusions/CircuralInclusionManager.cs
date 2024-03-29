﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model.Inclusions
{
    class CircuralInclusionManager : InclusionManager
    {
        public override void ChangeGridCellsToInclusion(ref Grid grid, int amount, int value, List<Point> inclusionPoints)
        {
            foreach (Point p in inclusionPoints)
            {
                for (int x = Math.Max(p.X - value, 0); x < Math.Min(p.X + value, Grid.SizeX - 1); x++)
                {
                    for (int y = Math.Max(p.Y - value, 0); y < Math.Min(p.Y + value, Grid.SizeY - 1); y++)
                    {
                        if (Math.Sqrt(Math.Pow(p.X-x,2) + Math.Pow(p.Y-y,2)) < value)
                        {
                            grid.Cells[x, y].State = 2;
                            grid.Cells[x, y].Id = -1;
                        }
                    }
                }
            }
        }
    }
}
