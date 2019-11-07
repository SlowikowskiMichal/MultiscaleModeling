using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModeling.Model
{
    public class Grid
    {
        public Cell[,] Cells { get; private set; }
        public static int SizeX { get => _sizeX; }
        public static int SizeY { get => _sizeY; }

        static private int _sizeX = 300;
        static private int _sizeY = 300;

        public Grid()
        {
            Cells = new Cell[_sizeX, _sizeY];
            for (int i = 0; i < _sizeX; i++)
            {
                for (int j = 0; j < _sizeY; j++)
                {
                    Cells[i, j] = new Cell();
                }
            }
        }

        public Grid(int X, int Y)
        {
            if (X > 0 && Y > 0)
            {
                _sizeX = X;
                _sizeY = Y;
            }
            Cells = new Cell[_sizeX, _sizeY];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    Cells[i, j] = new Cell();
                }
            }
        }

        public bool Resize(int X, int Y)
        {
            if (X > 0 && Y > 0)
            {
                _sizeX = X;
                _sizeY = Y;
                Cells = new Cell[_sizeX, _sizeY];
                for (int i = 0; i < X; i++)
                {
                    for (int j = 0; j < Y; j++)
                    {
                        Cells[i, j] = new Cell();
                    }
                }
            }
            return false;
        }

        public void ChangeCellValue(int x, int y)
        {
            if (x < _sizeX && y < _sizeY && x >= 0 && y >= 0)
            {
                Cells[x, y].ChangeState();
            }
        }

        public void ChangeCellValue(int x, int y, int value)
        {
            if (x < _sizeX && y < _sizeY && x >= 0 && y >= 0)
            {
                Cells[x, y].ChangeState();
                Cells[x, y].Id = value;
            }
        }

        public void ChangeCellValue(int x, int y, int value, int state)
        {
            if (x < _sizeX && y < _sizeY && x >= 0 && y >= 0)
            {
                Cells[x, y].ChangeState(state);
                Cells[x, y].Id = value;
            }
        }

        public void Clear()
        {
            foreach (Cell c in Cells)
            {
                c.Reset();
            }
        }

        public void ClearRec()
        {
            foreach (Cell c in Cells)
            {
                c.Recrystallized = false;
            }
        }

        internal void Copy(Grid other)
        {
            for (int i = 0; i < Grid.SizeX; i++)
            {
                for (int j = 0; j < Grid.SizeY; j++)
                {
                    if (this.Cells[i, j].State != other.Cells[i, j].State)
                    {
                        this.Cells[i, j].ChangeState(other.Cells[i, j].State);
                        this.Cells[i, j].Id = other.Cells[i, j].Id;
                    }
                }
            }
        }

        internal void Copy(Grid other, int startX, int startY, int endX, int endY)
        {
            for (int i = startX; i < endX; i++)
            {
                for (int j = startY; j < endY; j++)
                {
                    if (this.Cells[i, j].State != other.Cells[i, j].State)
                    {
                        this.Cells[i, j].ChangeState(other.Cells[i, j].State);
                        this.Cells[i, j].Id = other.Cells[i, j].Id;
                    }
                }
            }
        }

        internal void Copy(Grid other, List<Point> cellsToCopy)
        {
            foreach (Point p in cellsToCopy)
            {
                if (this.Cells[p.X, p.Y].State != other.Cells[p.X, p.Y].State)
                {
                    this.Cells[p.X, p.Y].ChangeState(other.Cells[p.X, p.Y].State);
                    this.Cells[p.X, p.Y].Id = other.Cells[p.X, p.Y].Id;
                }
            }
        }
    }
}
