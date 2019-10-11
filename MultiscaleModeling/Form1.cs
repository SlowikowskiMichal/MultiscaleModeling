using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiscaleModeling.Model;
using MultiscaleModeling.Model.Neighbourhood;
using MultiscaleModeling.Controller;

namespace MultiscaleModeling
{
    public partial class Form1 : Form
    {
        readonly static object synLock = new object();

        #region ATTRIBUTES
        #region GRID
        GridController gridController;
        CelluralAutomataProperties celluralAutomataProperties;

        const int sizeX = 1;
        const int sizeY = 1;
        float cellXSize;
        float cellYSize;
        Grid currentGrid;
        Grid nextStepGrid;
        int emptyCount = 0;
        int currentPositionX = 0;
        int currentPositionY = 0;
        #endregion
        #region IMAGE
        List<string> knownColors = Enum.GetNames(typeof(KnownColor)).ToList();
        readonly Neighbourhood[] implementedNeighborhood = {new MooresNeighbourhood()};
        Color BackgroundColor = Color.White;
        Bitmap nextImage;
        SolidBrush brush;
        #endregion
        #region GRID VIEW
        int zoom;
        bool drawGrid;
        #endregion
        #region GRID OPTIONS
        BoundaryCondition boundaryCondition;
        Neighbourhood neighborhood;
        #endregion
        //FILL
        int idZiarno = 0;
        int nPopulation;
        //SIMULATION
        int mcStep = 0;
        bool running = false;
        bool mcRunning = false;
        //Label
        string errMsg = "";
        #endregion

        public Form1()
        {
            InitializeComponent();

            //GRID
            gridController = new GridController(
                int.Parse(widthSizeGridPropertiesNumericUpDown.Text),
                int.Parse(heightSizeGridPropertiesNumericUpDown.Text),
                int.Parse(nucleonAmoutCAPropertiesNumericUpDown.Text)
            );

            celluralAutomataProperties = new CelluralAutomataProperties();

            gridController.SetBoundaryCondition(celluralAutomataProperties.GetBoundaryCondition());
            gridController.SetNeighbourhood(celluralAutomataProperties.GetNeighbourhood());
            
            //IMAGE
            knownColors.RemoveAll(color => color == "White" || color == "Black"
                    || color == "Transparent");
            Shuffle(knownColors);
            brush = new SolidBrush(Color.White);
            //GRID VIEW
            zoom = viewZoomTrackBar.Value;
            cellXSize = sizeX * zoom;
            cellYSize = sizeY * zoom;
            drawGrid = viewGridCheckBox.Checked;


            //GRID OPTIONS
            boundaryConditionCAPropertiesComboBox.SelectedIndex = 0;
            boundaryCondition = (BoundaryCondition)boundaryConditionCAPropertiesComboBox.SelectedIndex;
            neighbourhoodCAPropertiesComboBox.SelectedIndex = 0;
            neighborhood = implementedNeighborhood[neighbourhoodCAPropertiesComboBox.SelectedIndex];
            //FILL
            nPopulation = (int)nucleonAmoutCAPropertiesNumericUpDown.Value;
            //populateComboBox.SelectedIndex = 0;
            viewPictureBox.Size = viewPanel.Size;
            SetImageSize();
        }

        //GUI METHODS
        //PICTURE BOX METHODS
        #region GUI ACTIONS
        private void ViewPictureBox_Click(object sender, EventArgs e)
        {
            if (running || mcRunning)
            {
                return;
            }
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                //Calculate pictureBox click position to grid position
                int x = (int)(me.X / cellXSize) + currentPositionX;
                int y = (int)(me.Y / cellYSize) + currentPositionY;
 /*               if (x >= Grid.SizeX || x < 0
                    || y >= Grid.SizeY || y < 0)
                {
                    return;
                }
*/             
                if(gridController.ChangeGridValue(x, y))
                {
                    FillCell(x, y, Color.FromName(knownColors[gridController.CurrentNucleonID % knownColors.Count()]));
                }
                else
                {
                    emptyCount++;
                    FillCell(x, y, BackgroundColor);
                }
            }
            else
            {
                gridController.ChangeCurrentNucleonID();
            }

            viewPictureBox.Image = nextImage;
        }
        private void ViewPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(nextImage, 0, 0, nextImage.Width, nextImage.Height);
        }
        private void ResizeSizeGridPropertiesButton_Click(object sender, EventArgs e)
        {
            int sizeX;
            int sizeY;
            int.TryParse(widthSizeGridPropertiesNumericUpDown.Text, out sizeX);
            int.TryParse(heightSizeGridPropertiesNumericUpDown.Text, out sizeY);

            gridController.ResizeGrid(sizeX, sizeY);

            SetImageSize();
        }
        private void ClearSizeGridPropertiesButton_Click(object sender, EventArgs e)
        {
            gridController.ClearGrid();
            DrawGridOnImage();

            viewPictureBox.Image = nextImage;
            viewPictureBox.Refresh();
        }
        private void RandomPlacementButton_Click(object sender, EventArgs e)
        {
            gridController.RandomPopulate((int)nucleonAmoutCAPropertiesNumericUpDown.Value);
            DrawGridOnImage();
            viewPictureBox.Refresh();
        }
        private async void RunCAExecutionButton_Click(object sender, EventArgs e)
        {
            if (running)
                return;
            running = true;
            var progress = new Progress<string>();
            SetGuiAsEnabled(!running);
            await Task.Factory.StartNew(() => gridController.Continue(progress),
                            TaskCreationOptions.LongRunning);
            this.DrawGridOnImage();
            viewPictureBox.Refresh();
        }
        private void StopCAExecutionButton_Click(object sender, EventArgs e)
        {
            running = false;
            SetGuiAsEnabled(!running);
        }
        private void NucleonAmoutCAPropertiesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(nucleonAmoutCAPropertiesNumericUpDown.Text, out nPopulation);
        }
        private void BitmapSaveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveBitmapDialog = new SaveFileDialog();
            saveBitmapDialog.Filter = "Bitmap Image|*.bmp";
            saveBitmapDialog.Title = "Save an Image File";
            saveBitmapDialog.ShowDialog();

            if (saveBitmapDialog.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveBitmapDialog.OpenFile();

                viewPictureBox.Image.Save(fs,
                  System.Drawing.Imaging.ImageFormat.Bmp);

                fs.Close();
            }
        }
        private void SetGuiAsEnabled(bool flag)
        {
            viewGroupBox.Enabled = flag;
            gridPropertiesGroupBox.Enabled = flag;
            caGroupBox.Enabled = flag;
        }
        public void DrawGridOnImage()
        {
            int endPositionX = Math.Min(currentPositionX + nextImage.Width, Grid.SizeX);
            int endPositionY = Math.Min(currentPositionY + nextImage.Height, Grid.SizeY);

            Graphics.FromImage(nextImage).Clear(Color.Black);

            for (int x = currentPositionX; x < endPositionX; x++)
            {
                for (int y = currentPositionY; y < endPositionY; y++)
                {
                    if (gridController.GetCurrentGridCellState(x, y))
                    {
                        FillCell(x, y, Color.FromName(knownColors[gridController.GetCurrentGridCellId(x, y) % knownColors.Count()]));
                    }
                    else
                    {
                        FillCell(x, y, Color.White);
                    }
                }
            }
        }
        private void DrawGridOnViewPictureBox(int startPositionX, int startPositionY, int endPositionX, int endPositionY)
        {
            endPositionX = Math.Min(endPositionX, Grid.SizeX);
            endPositionY = Math.Min(endPositionY, Grid.SizeY);

            for (int y = startPositionY; y < endPositionY; y++)
            {
                for (int x = startPositionX; x < endPositionX; x++)
                {
                    FillCell(x, y, Color.FromName(knownColors[nextStepGrid.Cells[x, y].Id % knownColors.Count()]));
                }
            }
            viewPictureBox.Refresh();
        }
        #endregion
        #region DO ZAOURANIA

        void FillCell(int x, int y, Color color)
        {
            brush.Color = color;

            if (drawGrid)
            {
                Graphics.FromImage(nextImage).
                    FillRectangle(brush,
                    x * cellXSize + 1, y * cellYSize + 1,
                    cellXSize - 2, cellYSize - 2);
            }
            else
            {
                Graphics.FromImage(nextImage).
                    FillRectangle(brush,
                    x * cellXSize, y * cellYSize,
                    cellXSize, cellYSize);
            }
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
        private void SetImageSize()
        {
            nextImage = new Bitmap(
                Math.Min(viewPanel.Size.Width, Grid.SizeX),
                Math.Min(viewPanel.Size.Height, Grid.SizeY)
            );


            viewPictureBox.Image = nextImage;
            DrawGridOnImage();
            viewPictureBox.Refresh();
        }
        #endregion
    }
}
