using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiscaleModeling.Model;
using MultiscaleModeling.Model.Neighbourhood;
using MultiscaleModeling.Controller;
using MultiscaleModeling.Controller.FileIO.Export;
using MultiscaleModeling.Controller.FileIO.Import;

namespace MultiscaleModeling
{
    public partial class Form1 : Form
    {
        readonly static object synLock = new object();
        delegate void DrawDelegate(ref Bitmap imageToDrawOn);
        DrawDelegate DrawFunction;

        #region ATTRIBUTES
        #region GRID
        GridController gridController;
        CelluralAutomataProperties celluralAutomataProperties;

        const int sizeX = 1;
        const int sizeY = 1;
        float cellXSize;
        float cellYSize;
        int currentPositionX = 0;
        int currentPositionY = 0;
        #endregion
        #region IMAGE
        readonly Neighbourhood[] implementedNeighborhood = {new MooresNeighbourhood()};
        Color BackgroundColor = Color.White;
        Bitmap nextImage;
        SolidBrush brush;
        #endregion
        #region GRID VIEW
        int zoom;
        bool drawGrid;
        #endregion
        //SIMULATION
        int mcStep = 0;
        bool running = false;
        bool mcRunning = false;
        //Label
        string errMsg = "";
        #region IMPORT EXPORT
        ISaver Saver;
        ILoader Loader;
        #endregion
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

            DrawFunction = DrawGridOnImage;

            gridController.SetBoundaryCondition(celluralAutomataProperties.GetBoundaryCondition());
            gridController.SetNeighbourhood(celluralAutomataProperties.GetNeighbourhood());

            setEnergyModePropertiesMonteCarloComboBox.SelectedIndex = 0;

            //IMAGE
            brush = new SolidBrush(Color.White);
            selectionTypeSubstructureComboBox.SelectedIndex = 0;

            //GRID OPTIONS
            boundaryConditionCAPropertiesComboBox.SelectedIndex = 0;
            neighbourhoodCAPropertiesComboBox.SelectedIndex = 0;
            typeInclusionsComboBox.SelectedIndex = 0;
            viewPictureBox.Size = viewPanel.Size;
            SetImageSize();

            selectionModePropertiesGrainBoundariesComboBox.SelectedIndex = 0;
            //GRID VIEW
            zoom = 1;//viewZoomTrackBar.Value;
            cellXSize = sizeX * zoom;
            cellYSize = sizeY * zoom;
            drawGrid = false;//viewGridCheckBox.Checked;
            grainViewPropertiesRadioButton.Checked = true;
        }


        public int DeterminateClickOnPictureBoxMode()
        {
            string beg = "Mouse mode: ";
            if (running || mcRunning)
            {
                mouseModeLabel.Text = beg+"CA is running, can't click on grid";
                return 0;
            }
            //Calculate pictureBox click position to grid position

            if (selectionModePropertiesGrainBoundariesComboBox.SelectedIndex == 1)
            {
                mouseModeLabel.Text = beg + "Selected grain boundary";
                return 4;
            }
            else
            {
                if (gridController.emptyCount == 0)
                {
                    if(selectionTypeSubstructureComboBox.SelectedIndex == 0)
                    {
                        mouseModeLabel.Text = beg + "Select Substructure";
                        return 2;
                    }
                    else
                    {
                        mouseModeLabel.Text = beg + "Select DP";
                        return 3;
                    }
                    
                }
                else
                {
                    mouseModeLabel.Text = beg + "Drawing on grid";
                    return 1;
                }
            }
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
            //Calculate pictureBox click position to grid position
            int x = (int)(me.X / cellXSize) + currentPositionX;
            int y = (int)(me.Y / cellYSize) + currentPositionY;
            if (x >= Grid.SizeX || x < 0
                || y >= Grid.SizeY || y < 0)
            {
                return;
            }
            if(selectionModePropertiesGrainBoundariesComboBox.SelectedIndex == 1)
            {
                gridController.GenerateCellBoundary(x, y, decimal.ToInt32(sizePropertiesGrainBoundariesNumericUpDown.Value));
                gbPercentTextBox.Text = gridController.GetBoundaryPercentSize();

                DrawFunction(ref nextImage);
                viewPictureBox.Refresh();

            }
            else
            {
                if (me.Button == MouseButtons.Left)
                {

                    if (gridController.emptyCount == 0)
                    {
                        gridController.selectGrainForDP(x, y, selectionTypeSubstructureComboBox.SelectedIndex);
                        DrawFunction(ref nextImage);
                    }
                    else
                    {
                        if (gridController.ChangeGridValue(x, y))
                        {
                            FillCell(x, y, nextImage, ColorTranslator.FromHtml(ColorManager.indexcolors[gridController.CurrentNucleonID % ColorManager.indexcolors.Count()]));
                        }
                        else
                        {
                            FillCell(x, y, nextImage, BackgroundColor);
                        }
                    }
                }
                else
                {
                    gridController.ChangeCurrentNucleonID();
                }
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
            nextImage = new Bitmap(sizeX, sizeY);
            gridController.ResizeGrid(sizeX, sizeY);

            SetImageSize();
            DeterminateClickOnPictureBoxMode();
        }
        private void ClearSizeGridPropertiesButton_Click(object sender, EventArgs e)
        {
            gridController.ClearGrid();
            DrawFunction(ref nextImage);
            currentIterationNumberMonteCarloTextBox.Text = "0";

            viewPictureBox.Image = nextImage;
            viewPictureBox.Refresh();
            DeterminateClickOnPictureBoxMode();
        }
        private void RandomPlacementButton_Click(object sender, EventArgs e)
        {
            gridController.RandomPopulate((int)nucleonAmoutCAPropertiesNumericUpDown.Value);
            DrawFunction(ref nextImage);
            viewPictureBox.Refresh();
        }
        private async void RunCAExecutionButton_Click(object sender, EventArgs e)
        {
            if (running)
            {
                return;
            }
            running = true;
            var progress = new Progress<int>(v =>
            {
                caExecutionProgressBar.Value = Math.Abs(v);
            });
            int rule = neighbourhoodCAPropertiesComboBox.SelectedIndex;
            SetGuiAsEnabled(false);
            await Task.Factory.StartNew(() => gridController.Continue(progress,rule),
                            TaskCreationOptions.LongRunning);
            this.DrawFunction(ref nextImage);
            viewPictureBox.Refresh();
            running = false;
            SetGuiAsEnabled(true);
            DeterminateClickOnPictureBoxMode();
        }
        private void StopCAExecutionButton_Click(object sender, EventArgs e)
        {
            gridController.StopExecution();
            SetGuiAsEnabled(!running);
        }
        private void NucleonAmoutCAPropertiesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            gridController.SetNucleonsPopulationDecimal(Decimal.ToInt32(nucleonAmoutCAPropertiesNumericUpDown.Value));
        }
        private void BitmapSaveFileMenuItem_Click(object sender, EventArgs e)
        {
            Saver = new BitmapSaver();
            Saver.Save(gridController.GetCurrentGrid());
        }
        private void SetGuiAsEnabled(bool flag)
        {
            viewGroupBox.Enabled = flag;
            gridPropertiesGroupBox.Enabled = flag;
            caGroupBox.Enabled = flag;
        }
        public void DrawGridOnImage(ref Bitmap imageToDrawOn)
        {
            if(imageToDrawOn == null)
            {
                imageToDrawOn = nextImage;
            }
            int endPositionX = Math.Min(currentPositionX + imageToDrawOn.Width, Grid.SizeX);
            int endPositionY = Math.Min(currentPositionY + imageToDrawOn.Height, Grid.SizeY);

            Graphics.FromImage(imageToDrawOn).Clear(Color.Black);

            for (int x = currentPositionX; x < endPositionX; x++)
            {
                for (int y = currentPositionY; y < endPositionY; y++)
                {
                    if (gridController.GetCurrentGridCellState(x, y) == 1 || gridController.GetCurrentGridCellState(x, y) == 4)
                    {
                        int color = gridController.GetCurrentGridCellId(x, y);
                        FillCell(x, y, imageToDrawOn, ColorTranslator.FromHtml(ColorManager.indexcolors[color % ColorManager.indexcolors.Count()]));
                    }
                    else if (gridController.GetCurrentGridCellState(x, y) == 2)
                    {
                        FillCell(x, y, imageToDrawOn, Color.Black);
                    }
                    else if (gridController.GetCurrentGridCellState(x, y) == 3)
                    {
                        FillCell(x, y, imageToDrawOn, ColorTranslator.FromHtml(ColorManager.dpColor));
                    }
                    else
                    {
                        FillCell(x, y, imageToDrawOn, Color.White);
                    }
                }
            }
            DeterminateClickOnPictureBoxMode();
            viewPictureBox.Image = nextImage;
            viewPictureBox.Refresh();
        }
        #endregion
        #region DO ZAOURANIA
        void FillCell(int x, int y, Bitmap imageToDrawOn, Color color)
        {
            brush.Color = color;

            if (drawGrid)
            {
                Graphics.FromImage(imageToDrawOn).
                    FillRectangle(brush,
                    x * cellXSize + 1, y * cellYSize + 1,
                    cellXSize - 2, cellYSize - 2);
            }
            else
            {
                Graphics.FromImage(imageToDrawOn).
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
            DrawFunction(ref nextImage);
            viewPictureBox.Refresh();
        }
        #endregion

        private void jsonSaveFileMenuItem_Click(object sender, EventArgs e)
        {
            int nPopulation;
            int.TryParse(nucleonAmoutCAPropertiesNumericUpDown.Text, out nPopulation);
            Saver = new JSONSaver(nPopulation,
                neighbourhoodCAPropertiesComboBox.Text,
                boundaryConditionCAPropertiesComboBox.Text);
            
            Saver.Save(gridController.GetCurrentGrid());
        }

        private void bitmapOpenFileMenuItem_Click(object sender, EventArgs e)
        {
            Loader = new BitmapLoader();
            OpenFileDialog openBitmapDialog = new OpenFileDialog();
            openBitmapDialog.Filter = "Bitmap Image|*.bmp";
            openBitmapDialog.Title = "Open an Image File";
            openBitmapDialog.ShowDialog();
            if (openBitmapDialog.FileName != String.Empty) {
                Loader.Load(openBitmapDialog.FileName, ref gridController);

                widthSizeGridPropertiesNumericUpDown.Text = Grid.SizeX.ToString();
                heightSizeGridPropertiesNumericUpDown.Text = Grid.SizeY.ToString();
                nextImage = new Bitmap(Grid.SizeX, Grid.SizeY);
                nucleonAmoutCAPropertiesNumericUpDown.Text = gridController.GetNucleonsPopulation().ToString();
            }
            this.DrawFunction(ref nextImage);
            viewPictureBox.Refresh();
        }
        public void StopCalculations()
        {
            lock (synLock)
            {
                running = false;
            }
        }

        private void JsonOpenFileMenuItem_Click(object sender, EventArgs e)
        {
            Loader = new JSONLoader();
            OpenFileDialog openJSONDialog = new OpenFileDialog();
            openJSONDialog.Filter = "JSON file|*.json";
            openJSONDialog.Title = "Open JSON file";
            openJSONDialog.ShowDialog();
            if (openJSONDialog.FileName != String.Empty)
            {
                Loader.Load(openJSONDialog.FileName, ref gridController);

                widthSizeGridPropertiesNumericUpDown.Text = Grid.SizeX.ToString();
                heightSizeGridPropertiesNumericUpDown.Text = Grid.SizeY.ToString();
                nextImage = new Bitmap(Grid.SizeX, Grid.SizeY);
                nucleonAmoutCAPropertiesNumericUpDown.Text = gridController.GetNucleonsPopulation().ToString();
            }
            this.DrawFunction(ref nextImage);
        }

        private void TypeInclusionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeInclusionsComboBox.SelectedIndex)
            {
                case 0:
                    valueInclusionsLabel.Text = "Length:";
                    break;
                case 1:
                    valueInclusionsLabel.Text = "Diameter:";
                    break;
            }
                
            
        }

        private void GenerateInclusionsButton_Click(object sender, EventArgs e)
        {
            gridController.GenerateInclusions(typeInclusionsComboBox.SelectedIndex, 
                Decimal.ToInt32(valueInclusionsNumericUpDown.Value), 
                Decimal.ToInt32(amountInsclusionsNumericUpDown.Value)
            );

            DrawFunction(ref nextImage);
            viewPictureBox.Refresh();
        }

        private void ProbabilityCAPropertiesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            gridController.ProbabilityOfChange = Decimal.ToInt32(probabilityCAPropertiesNumericUpDown.Value);
        }

        private void ClearSubstructureButton_Click(object sender, EventArgs e)
        {
            gridController.ClearUnselectedGrains();
            DrawFunction(ref nextImage);
            viewPictureBox.Refresh();
        }

        private void GeneratePropertiesGrainBoundariesButtonButton_Click(object sender, EventArgs e)
        {
            if(selectionModePropertiesGrainBoundariesComboBox.SelectedIndex == 0)
            {
                gridController.GenerateAllBoundaries(decimal.ToInt32(sizePropertiesGrainBoundariesNumericUpDown.Value));
            }

            gbPercentTextBox.Text = gridController.GetBoundaryPercentSize();

            DrawFunction(ref nextImage);
            viewPictureBox.Refresh();
        }

        private void SelectionModePropertiesGrainBoundariesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectionModePropertiesGrainBoundariesComboBox.SelectedIndex)
            {
                case 0:
                    generatePropertiesGrainBoundariesButtonButton.Enabled = true;
                    break;
                case 1:
                    generatePropertiesGrainBoundariesButtonButton.Enabled = false;
                    break;
            }
            DeterminateClickOnPictureBoxMode();
        }

        private void selectionTypeSubstructureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeterminateClickOnPictureBoxMode();
        }

        private void RandomStatesMonteCarloButton_Click(object sender, EventArgs e)
        {
            {
                gridController.RandomAllPopulate((int)stateMonteCarloNumericUpDown.Value);
                DrawFunction(ref nextImage);
                viewPictureBox.Refresh();
            }
        }

        private async void RunIterationsMonteCarloButton_Click(object sender, EventArgs e)
        {
            if (running)
            {
                return;
            }
            running = true;
            var progress = new Progress<string>(v =>
            {
                currentIterationNumberMonteCarloTextBox.Text = v;
            });
            
            SetGuiAsEnabled(false);
            await Task.Factory.StartNew(() => gridController.RunIterationsMonteCarlo(progress, decimal.ToInt32(iterationsNumberNumericUpDown.Value)),
                            TaskCreationOptions.LongRunning);

            this.DrawFunction(ref nextImage);
            viewPictureBox.Refresh();
            running = false;
            SetGuiAsEnabled(true);
            DeterminateClickOnPictureBoxMode();
        }

        private async void RunMonteCarloButton_Click(object sender, EventArgs e)
        {
            if (running)
            {
                return;
            }
            running = true;


            SetGuiAsEnabled(false);
            await Task.Factory.StartNew(() => gridController.RunMonteCarlo(),
                            TaskCreationOptions.LongRunning);
            
            currentIterationNumberMonteCarloTextBox.Text = gridController.GetMonteCarloIteration().ToString();
            this.DrawFunction(ref nextImage);
            viewPictureBox.Refresh();

            running = false;
            SetGuiAsEnabled(true);
            DeterminateClickOnPictureBoxMode();
        }

        private void StopMonteCarloButton_Click(object sender, EventArgs e)
        {
            gridController.StopExecution();
            SetGuiAsEnabled(!running);
        }

        private void energyViewPropertiesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(grainViewPropertiesRadioButton.Checked)
            {
                DrawFunction = DrawGridOnImage;
            }
            else if(energyViewPropertiesRadioButton.Checked)
            {
                DrawFunction = DrawEnergyOnImage;
            }
            else
            {
                DrawFunction = DrawEnergyWithNeighborhoodOnImage;
            }
            DrawFunction(ref nextImage);
        }

        private void DrawEnergyWithNeighborhoodOnImage(ref Bitmap imageToDrawOn)
        {
            if (imageToDrawOn == null)
            {
                imageToDrawOn = nextImage;
            }
            int endPositionX = Math.Min(currentPositionX + imageToDrawOn.Width, Grid.SizeX);
            int endPositionY = Math.Min(currentPositionY + imageToDrawOn.Height, Grid.SizeY);

            Graphics.FromImage(imageToDrawOn).Clear(Color.Black);

            int colorsCount = ColorManager.energyColors.Count() - 1;

            for (int x = currentPositionX; x < endPositionX; x++)
            {
                for (int y = currentPositionY; y < endPositionY; y++)
                {
                    if (gridController.GetCurrentGridCellState(x, y) == 1 || gridController.GetCurrentGridCellState(x, y) == 4)
                    {
                        int color = gridController.GetCurrentGridCellEnergy(x, y, true);
                        FillCell(x, y, imageToDrawOn, ColorTranslator.FromHtml(ColorManager.energyColors[Math.Min(color,colorsCount)]));
                    }
                    else if (gridController.GetCurrentGridCellState(x, y) == 2)
                    {
                        FillCell(x, y, imageToDrawOn, Color.Black);
                    }
                    else if (gridController.GetCurrentGridCellState(x, y) == 3)
                    {
                        FillCell(x, y, imageToDrawOn, ColorTranslator.FromHtml(ColorManager.dpColor));
                    }
                    else
                    {
                        FillCell(x, y, imageToDrawOn, Color.White);
                    }
                }
            }
            DeterminateClickOnPictureBoxMode();
            viewPictureBox.Image = nextImage;
            viewPictureBox.Refresh();
        }

        private void DrawEnergyOnImage(ref Bitmap imageToDrawOn)
        {
            if (imageToDrawOn == null)
            {
                imageToDrawOn = nextImage;
            }
            int endPositionX = Math.Min(currentPositionX + imageToDrawOn.Width, Grid.SizeX);
            int endPositionY = Math.Min(currentPositionY + imageToDrawOn.Height, Grid.SizeY);

            Graphics.FromImage(imageToDrawOn).Clear(Color.Black);

            int colorsCount = ColorManager.energyColors.Count();

            for (int x = currentPositionX; x < endPositionX; x++)
            {
                for (int y = currentPositionY; y < endPositionY; y++)
                {
                    if (gridController.GetCurrentGridCellState(x, y) == 1 || gridController.GetCurrentGridCellState(x, y) == 4)
                    {
                        int color = gridController.GetCurrentGridCellEnergy(x, y);
                        FillCell(x, y, imageToDrawOn, ColorTranslator.FromHtml(ColorManager.energyColors[color % colorsCount]));
                    }
                    else if (gridController.GetCurrentGridCellState(x, y) == 2)
                    {
                        FillCell(x, y, imageToDrawOn, Color.Black);
                    }
                    else if (gridController.GetCurrentGridCellState(x, y) == 3)
                    {
                        FillCell(x, y, imageToDrawOn, ColorTranslator.FromHtml(ColorManager.dpColor));
                    }
                    else
                    {
                        FillCell(x, y, imageToDrawOn, Color.White);
                    }
                }
            }
            DeterminateClickOnPictureBoxMode();
            viewPictureBox.Image = nextImage;
            viewPictureBox.Refresh();
        }

        private void setEnergyValueButton_Click(object sender, EventArgs e)
        {
            if (setEnergyModePropertiesMonteCarloComboBox.SelectedIndex == 2)
            {
                gridController.SetEnergyOnBoundaries(decimal.ToInt32(gbSizePropertiesMonteCarloNumericUpDown.Value),
                    decimal.ToInt32(energyValuePropertiesMonteCarloNumericUpDown.Value));
            }else if(setEnergyModePropertiesMonteCarloComboBox.SelectedIndex == 1)
            {
                gridController.SetEnergyOnInside(decimal.ToInt32(gbSizePropertiesMonteCarloNumericUpDown.Value),
                                    decimal.ToInt32(energyValuePropertiesMonteCarloNumericUpDown.Value));
            }
            else if(setEnergyModePropertiesMonteCarloComboBox.SelectedIndex == 0)
            {
                gridController.SetEnergyAll(decimal.ToInt32(decimal.ToInt32(energyValuePropertiesMonteCarloNumericUpDown.Value)));
            }

            DrawFunction(ref nextImage);
        }
    }
}
