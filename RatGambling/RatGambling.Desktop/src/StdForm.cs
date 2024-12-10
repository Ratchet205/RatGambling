using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatGambling.Desktop.src
{
    public partial class StdForm : Form
    {
        private bool pBExitHover = false;
        private bool pBMinHover = false;
        public StdForm()
        {
            InitializeComponent();
        }
        private void pBExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pBExit_Paint(object sender, PaintEventArgs e)
        {
            if (sender is PictureBox pb)
            {
                Graphics g;
                int x = pb.Width;
                int y = pb.Height;

                (int X, int Y) middle = (x / 2, y / 2);

                g = e.Graphics;

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                pb.BackColor = pBExitHover ? Color.FromArgb(0xBE, 0, 0) : pTopBorder.BackColor;


                using Pen pen = new(Color.FromArgb(0xbe, 0xbe, 0xbe), 1.6f)
                {
                    StartCap = System.Drawing.Drawing2D.LineCap.Round,
                    EndCap = System.Drawing.Drawing2D.LineCap.Round
                };
                const int armLength = 5;
                g.DrawLine(pen, middle.X - armLength, middle.Y + armLength, middle.X + armLength, middle.Y - armLength);
                g.DrawLine(pen, middle.X + armLength, middle.Y + armLength, middle.X - armLength, middle.Y - armLength);
            }
        }

        private void pBExit_MouseEnter(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;
            pBExitHover = true;
            pictureBox?.Invalidate();
        }

        private void pBExit_MouseLeave(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;
            pBExitHover = false;
            pictureBox?.Invalidate();
        }

        private void pBMin_Paint(object sender, PaintEventArgs e)
        {
            PictureBox? pb = sender as PictureBox;
            if (pb != null)
            {
                Graphics g;
                int x = pb.Width;
                int y = pb.Height;

                (int X, int Y) middle = (x / 2, y / 2);

                g = e.Graphics;

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                pb.BackColor = pBMinHover ? Color.FromArgb(0xEF2056) : pTopBorder.BackColor;


                using Pen pen = new(Color.FromArgb(0xbe, 0xbe, 0xbe), 1.6f)
                {
                    StartCap = System.Drawing.Drawing2D.LineCap.Round,
                    EndCap = System.Drawing.Drawing2D.LineCap.Round
                };
                const int armLength = 5;
                g.DrawLine(pen, middle.X - armLength, middle.Y, middle.X + armLength, middle.Y);
            }
        }

        private void pBMin_MouseLeave(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;
            pBMinHover = false;
            pictureBox?.Invalidate();
        }

        private void pBMin_MouseEnter(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;
            pBMinHover = true;
            pictureBox?.Invalidate();
        }

        private void pBMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
