using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiscaleModeling.Model;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MultiscaleModeling.Controller.FileIO.Export
{
    class JSONSaver : ISaver
    {

        #region ATTRIBUTES - ADDITIONAL INFO
        public int? NucleonAmout;
        public string Neighbourhood;
        public string BoundaryCondition;
        #endregion

        public JSONSaver()
        {
            NucleonAmout = null;
            Neighbourhood = null;
            BoundaryCondition = null;
        }

        public JSONSaver(int? nucleonAmout, string neighbourhood, string boundaryCondition)
        {
            this.NucleonAmout = nucleonAmout;
            this.Neighbourhood = neighbourhood;
            this.BoundaryCondition = boundaryCondition;
        }

        public void Save(Grid grid)
        {
            JObject JSONToSave = PrepareJSON(grid);

            SaveFileDialog saveJSONDialog = new SaveFileDialog();
            saveJSONDialog.Filter = "JSON file|*.json";
            saveJSONDialog.Title = "Save JSON file";
            saveJSONDialog.ShowDialog();

            if (saveJSONDialog.FileName != "")
            {
                File.WriteAllText(saveJSONDialog.FileName, JSONToSave.ToString());
                using (StreamWriter file = File.CreateText(saveJSONDialog.FileName))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    JSONToSave.WriteTo(writer);
                }
            }
        }

        private JObject PrepareJSON(Grid grid)
        {
            dynamic JSONToSave = new JObject();

            JSONToSave.Size = new JObject(
                                new JProperty("width", Grid.SizeX),
                                new JProperty("height", Grid.SizeY)
                            );

            JSONToSave.caProperties = new JObject(
                                new JProperty("nucleonAmout", this.NucleonAmout),
                                new JProperty("Neighbourhood", this.Neighbourhood),
                                new JProperty("boundaryCondition", BoundaryCondition)
                            );

            JArray points = new JArray();

            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    if (grid.Cells[x, y].State != 0)
                        points.Add(new JObject(
                            new JProperty("x", x),
                            new JProperty("y", y),
                            new JProperty("id", grid.Cells[x, y].Id)
                            )
                        );
                }
            }

            JSONToSave.Grid = points;

            return JSONToSave;
        }
    }
}
