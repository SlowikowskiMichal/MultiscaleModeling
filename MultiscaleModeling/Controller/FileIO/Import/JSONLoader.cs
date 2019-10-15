using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Controller.FileIO.Import
{
    class JSONLoader : ILoader
    {
        public void Load(string filePath, ref GridController gridController)
        {
            JObject jsonObject = JObject.Parse(File.ReadAllText(filePath));


            int width = jsonObject["Size"]["width"].Value<int>();
            int height = jsonObject["Size"]["height"].Value<int>();

            gridController.ResizeGrid(width, height);
            gridController.SetNucleonsPopulationDecimal(jsonObject["caProperties"]["nucleonAmout"].Value<int>());

            Dictionary<int, List<MultiscaleModeling.Model.Point>> points = new Dictionary<int, List<Model.Point>>();

            foreach(var cell in jsonObject["Grid"])
            {
                gridController.ChangeGridValue(cell["x"].Value<int>(), cell["y"].Value<int>(), cell["id"].Value<int>());
            }
        }
    }
}
