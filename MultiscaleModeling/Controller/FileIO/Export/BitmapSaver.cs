using MultiscaleModeling.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiscaleModeling.Controller.FileIO.Export
{
    class BitmapSaver : ISaver
    {
        public BitmapSaver()
        {
        }

        public void Save(Grid grid)
        {
            Bitmap imageToSave = DrawGridOnImage(grid);
            SaveFileDialog saveBitmapDialog = new SaveFileDialog();
            saveBitmapDialog.Filter = "Bitmap Image|*.bmp";
            saveBitmapDialog.Title = "Save an Image File";
            saveBitmapDialog.ShowDialog();

            if (saveBitmapDialog.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveBitmapDialog.OpenFile();
                imageToSave.Save(fs,
                  System.Drawing.Imaging.ImageFormat.Bmp);

                fs.Close();
            }
        }

        private unsafe Bitmap DrawGridOnImage(Grid grid)
        {
            int width = Grid.SizeX;
            int height = Grid.SizeY;
            Bitmap imageToSave = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            BitmapData bitmapData = imageToSave.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite,
                imageToSave.PixelFormat
            );

            int PixelSize = 4;

            for (int y = 0; y < height; y++)
            {

                byte* row = (byte*)bitmapData.Scan0 + (y * bitmapData.Stride);
                for (int x = 0; x < width; x++)
                {
                    Color color = grid.Cells[x, y].State == 0 ? Color.White :
                        System.Drawing.ColorTranslator.FromHtml(ColorManager.indexcolors[grid.Cells[x, y].Id % ColorManager.indexcolors.Count()]);


                    row[x * PixelSize] = color.B;   //Blue  0-255
                    row[x * PixelSize + 1] = color.G; //Green 0-255
                    row[x * PixelSize + 2] = color.R;   //Red   0-255
                    row[x * PixelSize + 3] = color.A;  //Alpha 0-255
                }
            }
            imageToSave.UnlockBits(bitmapData);

            return imageToSave;
        }

        void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
