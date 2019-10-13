using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Controller.FileIO.Import
{
    class BitmapLoader : ILoader
    {
        public void Load(string filePath, ref GridController gridController)
        {
            Bitmap loadedImage = null;
            using (var image = new Bitmap(filePath))
            {
                loadedImage = new Bitmap(image);
            }

            gridController.ResizeGrid(loadedImage.Width, loadedImage.Height);

            gridController.SetGridFromPointsDictionary(GetGrainInformationFromImage(loadedImage));
        }

        private Dictionary<int, List<MultiscaleModeling.Model.Point>> GetGrainInformationFromImage(Bitmap image)
        {
            Dictionary<int, List<MultiscaleModeling.Model.Point>> grains = new Dictionary<int, List<MultiscaleModeling.Model.Point>>();

            for (int y = 0;y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    int color = image.GetPixel(x, y).ToArgb();
                    if (color != -1)
                    {
                    if (!grains.ContainsKey(color))
                        {
                            grains.Add(color, new List<Model.Point>());
                        }
                        grains[color].Add(new Model.Point(x, y));
                    }
                }
            }
            return grains;
        }
    }
}
