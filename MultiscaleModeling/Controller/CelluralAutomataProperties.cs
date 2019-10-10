using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiscaleModeling.Model.Neighbourhood;

namespace MultiscaleModeling.Controller
{
    class CelluralAutomataProperties
    {
        string[] BoundaryConditionsNames = new string[] { "Moore" };
        readonly Neighbourhood[] implementedNeighborhood = { new MooresNeighbourhood() };
        int currentNeighborhood = 0;
        BoundaryConditions boundaryCondition = new ;
    }
}
