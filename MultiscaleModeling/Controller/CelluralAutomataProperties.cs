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
        public int currentNeighborhood { private get; set; }

        readonly string[] BoundaryConditionsNames = new string[] { "Periodic" };
        public int currentBoundaryCondition { private get; set; }
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

        public Neighbourhood GetNeighbourhood()
        {
            return implementedNeighborhood[currentNeighborhood];
        }

        public BoundaryCondition GetBoundaryCondition()
        {
            return (BoundaryCondition)currentBoundaryCondition;
        }
        #endregion
    }
}
