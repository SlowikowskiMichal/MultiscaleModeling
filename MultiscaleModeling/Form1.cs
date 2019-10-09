using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiscaleModeling.Model;
using MultiscaleModeling.Model.Neighborhood;

namespace MultiscaleModeling
{
    public partial class Form1 : Form
    {
        readonly static object synLock = new object();
        //GRID
        const int sizeX = 1;
        const int sizeY = 1;
        float cellXSize;
        float cellYSize;
        Grid currentGrid;
        Grid nextStepGrid;
        int emptyCount = 0;
        //IMAGE
        List<string> knownColors = Enum.GetNames(typeof(KnownColor)).ToList();
        readonly Neighborhood[] implementedNeighborhood = {new NeumannNeighborhood()};
        Color BackgroundColor = Color.White;
        Bitmap nextImage;
        //GRID VIEW
        int speed;
        int zoom;
        bool drawGrid;
        //GRID OPTIONS
        BoundaryConditions boundaryCondition;
        Neighborhood neighborhood;
        //FILL
        int idZiarno = 0;
        int nPopulation;
        //SIMULATION
        bool running = false;
        bool mcRunning = false;
        int mcStep = 0;
        //Label
        string errMsg = "";

        public Form1()
        {
            InitializeComponent();

            //GRID
            currentGrid = new Grid();
            nextStepGrid = new Grid();
            widthSizeGridPropertiesNumericUpDown.Text = Grid.SizeX.ToString();
            heightSizeGridPropertiesNumericUpDown.Text = Grid.SizeY.ToString();
            //IMAGE
            knownColors.RemoveAll(color => color == "White" || color == "Black"
                    || color == "Transparent");
            Shuffle(knownColors);
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

            nextImage = new Bitmap((int)cellXSize * Grid.SizeX, (int)cellYSize * Grid.SizeY);
            viewPictureBox.Image = nextImage;
            InitializeGrid();
            viewPictureBox.Refresh();
        }

        void InitializeGrid()
        {
            mcStep = 0;
            emptyCount = Grid.SizeX * Grid.SizeY;
            lock (synLock)
            {
                Graphics.FromImage(nextImage).Clear(Color.Black);
            }
            for (int i = 0; i < Grid.SizeX; i++)
            {
                for (int j = 0; j < Grid.SizeY; j++)
                {
                    if (currentGrid.Cells[i, j].State != 0)
                    {
                        FillCell(i, j, Color.FromName(knownColors[currentGrid.Cells[i, j].Id % knownColors.Count()]));
                    }
                    else
                    {
                        FillCell(i, j, Color.White);
                    }
                }
            }
        }

        void FillCell(int x, int y, Color color)
        {
            lock (synLock)
            {
                SolidBrush brush = new SolidBrush(color);

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
                brush.Dispose();
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
    }
}
