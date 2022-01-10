using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minesweeper.Core
{
    public class Board
    {
        public int MinesAround;
        public Minesweeper Minesweeper { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int NumMines { get; set; }
        public Cell[,] Cells { get; set; }
        public int Clicks { get; set; }

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
        }

        private void Cell_MouseClick(object sender, MouseEventArgs e)
        {
            var cell = (Cell)sender;

            if (cell.CellState == CellState.Opened)
                return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    cell.OnClick();
                    IfMineDisableClick(cell);
                    break;

                case MouseButtons.Right:
                    if (FlaggedOrFlaggedMine(cell))
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
            var bombsNeeded = NumMines;
            var bombs = new List<int>();
            Random randomNumber = new Random();
            for (int i = 0; i < bombsNeeded; i++)
            {
                var randomBomb = randomNumber.Next(0, Width * Height);
                if (bombs.Contains(randomBomb))
                {
                    bombsNeeded++;
                    continue;
                }

                bombs.Add(randomBomb);
            }

            return bombs;
        }

        public void SetupCell(int i, int j, CellType type)
        {
            var c = new Cell
            {
                XLoc = i,
                YLoc = j,
                CellState = CellState.Closed,
                CellType = type,
                CellSize = 50,
                Board = this
            };

            c.SetupDesign();
            c.MouseDown += Cell_MouseClick;
            this.Cells[i, j] = c;
            this.Minesweeper.Controls.Add(c);
        }

        private void IfMineDisableClick(Cell cell)
        {
            if (cell.CellType == CellType.Mine)
                foreach (var item in Cells)
                {
                    item.MouseDown -= Cell_MouseClick;
                }
        }

        public bool FlaggedOrFlaggedMine(Cell cell)
        {
            return cell.CellType == CellType.Flagged || cell.CellType == CellType.FlaggedMine;
        }
    }
}
