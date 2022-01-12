using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper.Core
{
    public enum CellType
    {
        Regular, Mine, Flagged, FlaggedMine
    }

    public enum CellState
    {
        Opened, Closed
    }

    public class Cell : Button
    {
        public int XLoc { get; set; }
        public int YLoc { get; set; }
        public int CellSize { get; set; }
        public CellState CellState { get; set; }
        public CellType CellType { get; set; }
        public int NumMines { get; set; }
        public Board Board { get; set; }
        public int mines { get; set; }

        public void SetupDesign()
        {
            this.BackColor = SystemColors.ButtonFace;
            this.Location = new Point(XLoc * CellSize, YLoc * CellSize);
            this.Size = new Size(CellSize, CellSize);
            this.UseVisualStyleBackColor = false;
            this.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
        }

        public void OnFlag()
        {
            if (CellType == CellType.Mine)
            {
                CellType = CellType.FlaggedMine;
            }
            else
            {
                CellType = CellType.Flagged;
            }

            Text = "?";
        }

        public void OffFlag()
        {
            if (CellType == CellType.FlaggedMine)
            {
                CellType = CellType.Mine;
            }
            else
            {
                CellType = CellType.Regular;
            }

            Text = "";
        }

        public void OnClick(bool recursiveCall = false)
        {
            Board.Clicks++;

            if (Board.Clicks == 1 && CellType == CellType.Mine)
            {
                CellType = CellType.Regular;
                GetRandomRegularCell().CellType = CellType.Mine;
            }

            if (CellType == CellType.Flagged || CellType == CellType.FlaggedMine)
                return;

            CellState = CellState.Opened;

            if (CellType == CellType.Mine)
            {
                RevealMines();
                LooserMessage();
            }
            else
            {
                Text = MinesAroundCell().ToString();
                ForeColor = GetCellColor();

                if (MinesAroundCell() == 0)
                {
                    OpenCellsAround();
                }
            }

            if (OpenedCells() == CellsWithNoMines())
            {
                RevealMines();
                WinnerMessage();
            }
        }

        private Color GetCellColor()
        {
            switch (this.mines)
            {
                case 1:
                    return ColorTranslator.FromHtml("0x0000FE"); // 1
                case 2:
                    return ColorTranslator.FromHtml("0x186900"); // 2
                case 3:
                    return ColorTranslator.FromHtml("0xAE0107"); // 3
                case 4:
                    return ColorTranslator.FromHtml("0x000177"); // 4
                case 5:
                    return ColorTranslator.FromHtml("0x8D0107"); // 5
                case 6:
                    return ColorTranslator.FromHtml("0x007A7C"); // 6
                case 7:
                    return ColorTranslator.FromHtml("0x902E90"); // 7
                case 8:
                    return ColorTranslator.FromHtml("0x000000"); // 8
                default:
                    return ColorTranslator.FromHtml("0xffffff");
            }
        }

        private int MinesAroundCell()
        {
            mines = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int xAxe = XLoc + i;
                    int yAxe = YLoc + j;

                    if (IsOutside(xAxe, yAxe))
                        continue;

                    if (IsMine(xAxe, yAxe))
                        mines++;
                }
            }

            return mines;
        }

        private void OpenCellsAround()
        {
            int x = XLoc;
            int y = YLoc;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int xAxe = x + i;
                    int yAxe = y + j;

                    if (IsOutside(xAxe, yAxe)
                        || Board.Cells[xAxe, yAxe].CellState == CellState.Opened
                        || Board.Cells[xAxe, yAxe].CellType == CellType.FlaggedMine
                        || Board.Cells[xAxe, yAxe].CellType == CellType.Flagged)
                        continue;

                    Board.Cells[xAxe, yAxe].OnClick();
                }
            }
        }

        private void RevealMines()
        {
            foreach (var cell in Board.Cells)
            {
                if (cell.CellType == CellType.Mine || cell.CellType == CellType.FlaggedMine)
                {
                    cell.Image = System.Drawing.Image.FromFile("c:\\miniMine.jpg");
                    cell.Text = "";
                }
            }
        }

        public bool IsOutside(int aroundX, int aroundY)
        {
            return aroundX < 0 || aroundY < 0 || aroundX >= Board.Width || aroundY >= Board.Height;
        }

        private bool IsMine(int xAxe, int yAxe)
        {
            return Board.Cells[xAxe, yAxe].CellType == CellType.Mine || Board.Cells[xAxe, yAxe].CellType == CellType.FlaggedMine;
        }

        private Cell GetRandomRegularCell()
        {
            Random randomCoordinate = new Random();
            var x = randomCoordinate.Next(0, 9);
            var y = randomCoordinate.Next(0, 9);

            if (Board.Cells[x, y].CellType == CellType.Regular)
            {
                return Board.Cells[x, y];
            }

            return GetRandomRegularCell();
        }

        private void LooserMessage()
        {
            MessageBox.Show("You Loose!", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageDialoge();
        }

        private void WinnerMessage()
        {
            MessageBox.Show("You Win!", "Nice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageDialoge();
        }

        private void MessageDialoge()
        {
            DialogResult dialogResult = MessageBox.Show(@"Restart?", @"Your options", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private int OpenedCells()
        {
            var openedCells = 0;
            foreach (var cell in Board.Cells)
            {
                if (cell.CellState == CellState.Opened)
                {
                    openedCells++;
                }
            }

            return openedCells;
        }

        private int CellsWithNoMines()
        {
            return Board.Cells.Length - Board.NumMines;
        }
    }
}
