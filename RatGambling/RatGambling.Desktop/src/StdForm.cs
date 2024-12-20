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
        private static bool _dragging = false;
        private bool _pBExitHover = false;
        private bool _pBMinHover = false;
        private (int X, int Y) _mouseposition;
        public StdForm()
        {
            InitializeComponent();
        }

        private void pBExit_Click(object sender, EventArgs e)
        {
            Close();
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

                pb.BackColor = _pBExitHover ? Color.FromArgb(0xBE, 0, 0) : pTopBorder.BackColor;


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
            _pBExitHover = true;
            pictureBox?.Invalidate();
        }

        private void pBExit_MouseLeave(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;
            _pBExitHover = false;
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

                pb.BackColor = _pBMinHover ? Color.FromArgb(0xEF, 0x20, 0x56) : Color.FromArgb(0xE4, 0x15, 0x4B);


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
            _pBMinHover = false;
            pictureBox?.Invalidate();
        }

        private void pBMin_MouseEnter(object sender, EventArgs e)
        {
            PictureBox? pictureBox = sender as PictureBox;
            _pBMinHover = true;
            pictureBox?.Invalidate();
        }

        private void pBMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pTopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _mouseposition.X = e.X;
            _mouseposition.Y = e.Y;
        }

        private void pTopBorder_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pTopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                SetDesktopLocation(MousePosition.X - _mouseposition.X, MousePosition.Y - _mouseposition.Y);
            }
        }

        private void pTopBorder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CenterToScreen();
        }
    }
}
