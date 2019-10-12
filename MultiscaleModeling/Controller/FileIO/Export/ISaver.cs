using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiscaleModeling.Model;


namespace MultiscaleModeling.Controller.FileIO.Export
{
    interface ISaver
    {
        void Save(Grid grid);
    }
}
