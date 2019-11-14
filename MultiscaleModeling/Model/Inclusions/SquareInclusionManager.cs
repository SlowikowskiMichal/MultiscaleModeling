using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model.Inclusions
{
    class SquareInclusionManager : InclusionManager
    {
        public override void ChangeGridCellsToInclusion(ref Grid grid, int amount, int value, List<Point> inclusionPoints)
        {
            foreach (Point p in inclusionPoints)
            {
                for (int x = Math.Max(p.X - value, 0); x < Math.Min(p.X + value, Grid.SizeX); x++)
                {
                    for (int y = Math.Max(p.Y - value, 0); y < Math.Min(p.Y + value, Grid.SizeY); y++)
                    {
                        grid.Cells[x, y].State = 2;
                        grid.Cells[x, y].Id = -1;
                    }
                }
            }
        }
    }
}
