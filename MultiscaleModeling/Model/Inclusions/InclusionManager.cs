using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model.Inclusions
{
    interface InclusionManager
    {
        bool GenerateInclusions(ref Grid grid, int amount, int value);
    }
}
