using RatGambling.Desktop.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RatGambling.Desktop.startingPage
{
    public partial class ChangeProfilePic : Form
    {
        private AccountForm parent = new();
        private bool _pBExitHover = false;
        private string imagePath;
        private Image originalImage;
        private float zoomFactor = 1f;
        public ChangeProfilePic(AccountForm parent, string imagePath)
        {
            InitializeComponent();
            this.parent = parent;

            this.imagePath = imagePath;
        }
        public ChangeProfilePic()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 2;
            Color borderColor = Color.Purple;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                Rectangle rect = new Rectangle(
                    borderWidth / 2,
                    borderWidth / 2,
                    this.ClientSize.Width - borderWidth,
                    this.ClientSize.Height - borderWidth);

                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void ChangeProfilePic_Deactivate(object sender, EventArgs e)
        {
            parent?.glassPanelBackground.Dispose();
            parent.changePW = false;

            if (parent != null)
            {
                parent.WindowState = FormWindowState.Normal;
                parent.BringToFront();
                parent.Activate();
                parent.Focus();
            }
            Close();
        }

        private void pBExit_Click(object sender, EventArgs e)
        {
            parent?.glassPanelBackground.Dispose();
            parent.changePW = false;

            if (parent != null)
            {
                parent.WindowState = FormWindowState.Normal;
                parent.BringToFront();
                parent.Activate();
                parent.Focus();
            }
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

        private void ChangeProfilePic_Load(object sender, EventArgs e)
        {
            // Bild in die PictureBox laden
            if (File.Exists(imagePath))
            {
                // Das Bild in die PictureBox laden
                pBChangePfP.Image = new Bitmap(imagePath);
                originalImage = pBChangePfP.Image;
            }
        }

        private void bFinishEdit_Click(object sender, EventArgs e)
        {
            SaveImageToDatabase();
            this.Close();
            if (pBChangePfP.Image != null)
            {
                MainForm mainForm = this.Owner as MainForm;
                if (parent != null)
                {
                    parent.SetImageToOtherForm(pBChangePfP.Image);
                }
            }
        }
        private void SaveImageToDatabase()
        {
            //Do it
        }

        private void trBZoomPFP_Scroll(object sender, EventArgs e)
        {
            zoomFactor = trBZoomPFP.Value / 100f;
            UpdateImageDisplay();
        }
        private void UpdateImageDisplay()
        {
            if (originalImage != null)
            {
                int newWidth = (int)(originalImage.Width * zoomFactor);
                int newHeight = (int)(originalImage.Height * zoomFactor);
                Bitmap scaledImage = new Bitmap(originalImage, newWidth, newHeight);

                // Bild rund zuschneiden
                Bitmap roundImage = new Bitmap(scaledImage.Width, scaledImage.Height);
                using (Graphics g = Graphics.FromImage(roundImage))
                {
                    g.Clear(Color.Transparent);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddEllipse(0, 0, scaledImage.Width, scaledImage.Height);
                        g.SetClip(path);
                        g.DrawImage(scaledImage, 0, 0);
                    }
                }

                // Bild in PictureBox anzeigen
                pBChangePfP.Image = roundImage;
            }
        }
    }
}
