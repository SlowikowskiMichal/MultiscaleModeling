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
        BoundaryConditions boundaryCondition;
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

            celluralAutomataProperties = new CelluralAutomataProperties(
                neighbourhoodCAPropertiesComboBox.SelectedIndex,
                boundaryConditionCAPropertiesComboBox.SelectedIndex
            );
            
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
            boundaryCondition = (BoundaryConditions)boundaryConditionCAPropertiesComboBox.SelectedIndex;
            neighbourhoodCAPropertiesComboBox.SelectedIndex = 0;
            neighborhood = implementedNeighborhood[neighbourhoodCAPropertiesComboBox.SelectedIndex];
            //FILL
            nPopulation = (int)nucleonAmoutCAPropertiesNumericUpDown.Value;
            //populateComboBox.SelectedIndex = 0;
            viewPictureBox.Size = viewPanel.Size;
            SetImageSize();
        }

        void DrawGridOnImage()
        {
            int endPositionX = currentPositionX + nextImage.Width;
            int endPositionY = currentPositionY + nextImage.Height;

            Graphics.FromImage(nextImage).Clear(Color.Black);
 
            for (int x = currentPositionX; x < endPositionX; x++)
            {
                for (int y = currentPositionY; y < endPositionY; y++)
                {
                    if (gridController.GetCurrentGridCellState(x,y))
                    {
                        FillCell(x, y, Color.FromName(knownColors[currentGrid.Cells[x, y].Id % knownColors.Count()]));
                    }
                    else
                    {
                        FillCell(x, y, Color.White);
                    }
                }
            }
        }
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


        //GUI METHODS
        //PICTURE BOX METHODS
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

        private void RandomPlacementButton_Click(object sender, EventArgs e)
        {
            RandomPopulate((int)nucleonAmoutCAPropertiesNumericUpDown.Value);         
            viewPictureBox.Refresh();
        }

        void RandomPopulate(int nPopulation)
        {
            if (nPopulation > Grid.SizeX * Grid.SizeY || nPopulation <= 0)
            {
                return;
            }

            currentGrid.Clear();
            nextStepGrid.Clear();
            DrawGridOnImage();

            List<Model.Point> freePoints = new List<Model.Point>();
            for (int x = 0; x < Grid.SizeX; x++)
            {
                for (int y = 0; y < Grid.SizeY; y++)
                {
                    freePoints.Add(new Model.Point(x, y));
                }
            }

            List<Model.Point> start = new List<Model.Point>();

            Random r = new Random();
            for (int i = 0; i < nPopulation;)
            {

                int index = r.Next(0, freePoints.Count());

                start.Add(freePoints[index]);
                freePoints.RemoveAt(index);
                i++;
            }
            Populate(start, nPopulation);
        }
        void Populate(List<Model.Point> start, int nPopulation)
        {
            lock (synLock)
            {
                foreach (Model.Point p in start)
                {
                    currentGrid.ChangeCellValue(p.X, p.Y);
                    idZiarno = idZiarno % nPopulation;
                    currentGrid.Cells[p.X, p.Y].Id = idZiarno;
                    FillCell(p.X, p.Y, Color.FromName(knownColors[idZiarno % knownColors.Count()]));
                    idZiarno++;
                    emptyCount--;
                }
            }
        }

        private void RunCAExecutionButton_Click(object sender, EventArgs e)
        {
            if (running)
                return;
            running = true;
            SetGuiOnExecution(!running);
            Thread calculations = new Thread(Continue);
            calculations.Start();
        }

        void CalculateNextStep(int startX, int startY, int endX, int endY)
        {
            Random r = new Random();
            nextStepGrid.Copy(currentGrid, startX, startY, endX, endY);
            List<Model.Point> n;
            List<int> a = new List<int>();

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    if (currentGrid.Cells[x, y].State != 0)
                    {
                        continue;
                    }

                    n = neighborhood.GetNeighborhood(x, y, Grid.SizeX, Grid.SizeY, boundaryCondition);
                    a.Clear();

                    n.FindAll(p => currentGrid.Cells[p.X, p.Y].State == 1).ForEach(p => a.Add(currentGrid.Cells[p.X, p.Y].Id));

                    Dictionary<int, int> counts = a.GroupBy(v => v)
                                      .ToDictionary(g => g.Key,
                                                    g => g.Count());
                    int max = 0;
                    int k = 0;
                    foreach (int key in counts.Keys)
                    {
                        if (max < counts[key])
                        {
                            max = counts[key];
                            k = key;
                        }
                        else if (max == counts[key] && r.NextDouble() > 0.5)
                        {
                            k = key;
                        }
                    }

                    if (max > 0)
                    {
                        lock (synLock)
                        {
                            emptyCount--;
                            nextStepGrid.Cells[x, y].ChangeState();
                            nextStepGrid.Cells[x, y].Id = k;
                        }

                        //FillCell(x, y, Color.FromName(knownColors[nextStepGrid.Cells[x, y].Id % knownColors.Count()]));
                    }
                }
            }
        }

        void Continue()
        {
            int nThreads = 4;
            Thread[] calculations = new Thread[nThreads];
            int x = Grid.SizeX / 2;
            int y = Grid.SizeY / 2;

            long current = DateTime.Now.Ticks;
            while (running && emptyCount > 0)
            {
                calculations[0] = new Thread(() => CalculateNextStep(0, 0, x, y));
                calculations[1] = new Thread(() => CalculateNextStep(x, 0, Grid.SizeX, y));
                calculations[2] = new Thread(() => CalculateNextStep(0, y, x, Grid.SizeY));
                calculations[3] = new Thread(() => CalculateNextStep(x, y, Grid.SizeX, Grid.SizeY));
                foreach (Thread task in calculations)
                {
                    task.Start();
                }
                foreach (Thread task in calculations)
                {
                    task.Join();
                }
                currentGrid.Copy(nextStepGrid);

                //Drawing each frame
                //this.Invoke((MethodInvoker)delegate
                //{
                //    viewPanel.Refresh();
                //});

            }
            running = false;
            this.Invoke((MethodInvoker)delegate
            {
                SetGuiOnExecution(!running);
                DrawGridOnViewPictureBox(currentPositionX,currentPositionY,viewPictureBox.Size.Width,viewPictureBox.Size.Height);
            });
        }

        private void DrawGridOnViewPictureBox(int startPositionX, int startPositionY, int endPositionX, int endPositionY)
        {
            endPositionX = Math.Min(endPositionX, Grid.SizeX);
            endPositionY = Math.Min(endPositionY, Grid.SizeY);

            for(int y = startPositionY; y < endPositionY; y++)
            {
                for (int x = startPositionX; x < endPositionX; x++)
                {
                    FillCell(x, y, Color.FromName(knownColors[nextStepGrid.Cells[x, y].Id % knownColors.Count()]));
                }
            }
            viewPictureBox.Refresh();
        }

        private void SetGuiOnExecution(bool flag)
        {
            viewGroupBox.Enabled = flag;
            gridPropertiesGroupBox.Enabled = flag;
            caGroupBox.Enabled = flag;
        }

        private void StopCAExecutionButton_Click(object sender, EventArgs e)
        {
            running = false;
            SetGuiOnExecution(!running);
        }

        private void NucleonAmoutCAPropertiesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int.TryParse(nucleonAmoutCAPropertiesNumericUpDown.Text, out nPopulation);
        }

        //MAIN MENU

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
    }
}
