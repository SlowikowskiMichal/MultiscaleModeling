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
        #region ATTRIBUTES
        string[] NeighbourhoodNames = new string[] { "Moore" };
        readonly Neighbourhood[] implementedNeighborhood = { new MooresNeighbourhood() };
        int currentNeighborhood;

        readonly string[] BoundaryConditionsNames = new string[] { "Periodic" };
        int currentBoundaryCondition;
        #endregion

        #region METHODS
        #region CONSTRUCTORS

        public CelluralAutomataProperties()
        {
            currentNeighborhood = 0;
            currentBoundaryCondition = 0;
        }

        public CelluralAutomataProperties(int currentNeighborhood, int currentBoundaryCondition)
        {
            this.currentNeighborhood = currentNeighborhood;
            this.currentBoundaryCondition = currentBoundaryCondition;
        }

        #endregion
        #endregion
    }
}
