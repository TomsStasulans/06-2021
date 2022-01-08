using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void SetupDesign(int XLoc, int YLoc)
        {
            this.BackColor = SystemColors.ButtonFace;
            this.Location = new Point(XLoc * CellSize, YLoc * CellSize);
            this.Size = new Size(CellSize, CellSize);
            this.UseVisualStyleBackColor = false;
            this.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
        }

        public void SetupBombDesign(int XLoc, int YLoc)
        {
            this.BackColor = SystemColors.ButtonFace;
            this.Location = new Point(XLoc * CellSize, YLoc * CellSize);
            this.Size = new Size(CellSize, CellSize);
            this.UseVisualStyleBackColor = false;
            this.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
        }

        public void OnFlag()
        {
            CellType = CellType.Flagged;
            Text = "?";
        }

        public void OffFlag()
        {
            CellType = CellType.Regular;
            Text = "";
        }

        public void OnClick(bool recursiveCall = false)
        {
            if (CellType == CellType.Flagged)
                return;

            CellState = CellState.Opened;
            if (CellType == CellType.Mine)
            {
                Image = System.Drawing.Image.FromFile("c:\\miniMine.jpg");
                MessageBox.Show("You Lost", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                Text = Board.MinesAroundCell.ToString();
            }
        }

        /// <summary>
        /// Return the color code associated with the number of surrounding mines
        /// </summary>
        /// <returns></returns>
        private Color GetCellColor()
        {
            switch (this.NumMines)
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
    }
}
