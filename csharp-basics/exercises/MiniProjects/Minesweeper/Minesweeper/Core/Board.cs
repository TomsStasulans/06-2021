using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Core
{
    public class Board
    {
        public int MinesAroundCell;
        public Minesweeper Minesweeper { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int NumMines { get; set; }
        public Cell[,] Cells { get; set; }

        public Board(Minesweeper minesweeper, int width, int height, int mines)
        {
            this.Minesweeper = minesweeper;
            this.Width = width;
            this.Height = height;
            this.NumMines = mines;
            this.Cells = new Cell[width, height];
        }

        public void SetupBoard()
        {
            var bombs = GetBombs(NumMines);
            var cellCounter = 0;
            for (int i = 0; i < Width; i++)
            {

                for (int j = 0; j < Height; j++)
                {
                    if (bombs.Contains(cellCounter))
                    {
                        SetupCell(i, j, CellType.Mine);
                    }
                    else
                    {
                        SetupCell(i, j, CellType.Regular);
                    }

                    cellCounter++;
                }
            }

            var cc = Cells;
            
        }

        private void Cell_MouseClick(object sender, MouseEventArgs e)
        {
            var cell = (Cell)sender;

            if (cell.CellState == CellState.Opened)
                return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    MinesAroundCell = MinesAround(Cells, cell);
                    //Cells.GetValue(cell);
                    cell.OnClick();
                    
                    break;

                case MouseButtons.Right:
                    if (cell.CellType == CellType.Flagged)
                        cell.OffFlag();
                    else
                        cell.OnFlag();
                    break;

                default:
                    return;
            }
        }

        public IList GetBombs(int NumMines)
        {
            var bombs = new List<int>();
            Random randomBomb = new Random();
            for (int i = 0; i < NumMines; i++)
            {
                bombs.Add(randomBomb.Next(0, Width * Height));
            }

            return bombs;
        }

        public void SetupCell(int i, int j, CellType type)
        {
            var c = new Cell
            {
                CellState = CellState.Closed,
                CellType = type,
                CellSize = 50,
                Board = this
            };

            c.SetupDesign(i, j);
            c.MouseDown += Cell_MouseClick;
            this.Cells[i, j] = c;
            this.Minesweeper.Controls.Add(c);
        }

        public int MinesAround(Cell[,] Cells, Cell cell)
        {
            int mine = 0;
            // if (cell[i, j].CellType == CellType.Mine)
                mine++;

            return mine;
        }
    }
}
