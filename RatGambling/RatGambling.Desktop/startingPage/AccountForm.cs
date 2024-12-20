using RatGambling.Desktop.Properties;
using RatGambling.Desktop.src.classes;
using RatGambling.Desktop.src.customControl;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace RatGambling.Desktop.startingPage
{
    public partial class AccountForm : Form
    {
        private MainForm parent = new();
        private readonly Bitmap userProfileBitmap;
        DarkenPanel glassPanelpfp;
        public DarkenPanel glassPanelBackground;
        bool isGray = false;
        public bool changePW = false;
        public AccountForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;

            glassPanelpfp = new DarkenPanel
            {
                Location = pBUserProfile.Location,  // Position relativ zu 'pPersonalInformation'
                Size = pBUserProfile.Size,  // Gleiche Größe wie das Profilbild
                Opacity = 0.7f,
                BackColor = Color.FromArgb(0, 0, 0),
                Visible = false  // Standardmäßig unsichtbar
            };
            pPersInformation.Controls.Add(glassPanelpfp);
            glassPanelpfp.BringToFront();

            glassPanelpfp.Region = new Region(new Rectangle(0, 0, glassPanelpfp.Width, glassPanelpfp.Height));
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, glassPanelpfp.Width, glassPanelpfp.Height);
                glassPanelpfp.Region = new Region(path);
            }
            userProfileBitmap = MainFormResources.standartUser;
            glassPanelpfp.MouseLeave += glassPanel_MouseLeave;
            glassPanelpfp.Click += glassPanel_Click;
        }
        public AccountForm()
        {
            InitializeComponent();
            userProfileBitmap = MainFormResources.standartUser;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            Location = new Point(
                parent.Location.X + parent.Width / 2 - Width / 2,
                parent.Location.Y + parent.Height / 2 - Height / 2);

            pMainPanel.Size = new System.Drawing.Size(this.ClientSize.Width - 10, this.ClientSize.Height - 10);
            pMainPanel.Location = new System.Drawing.Point(5, 5);

            pMainPanel.AutoScroll = true;

            pMainPanel.VerticalScroll.Visible = false;
            pMainPanel.HorizontalScroll.Visible = false;
        }



        private void pPersInformations_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pPersInformation);
        }

        private void DrawPanelBorder(PaintEventArgs e, Panel panel)
        {
            Graphics g = e.Graphics;
            Color borderColor = Color.Black;
            int borderWidth = 4;
            g.DrawRectangle(new Pen(borderColor, borderWidth),
                            panel.ClientRectangle.X,
                            panel.ClientRectangle.Y,
                            panel.ClientRectangle.Width,
                            panel.ClientRectangle.Height);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 2;
            Color borderColor = Color.FromArgb(0xc3, 0x3f, 0x3f);

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

        private void AccountForm_Deactivate(object sender, EventArgs e)
        {
            if (changePW == false && !IsOtherFormActive())
            {
                parent?.glassPanel.Dispose();
                Close();
            }
        }
        private bool IsOtherFormActive()
        {
            // Überprüfen, ob eines der Forms aktiv ist
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Focused && form != this)
                {
                    return true;
                }
            }
            return false;
        }
        private void glassPanel_MouseLeave(object sender, EventArgs e)
        {
            glassPanelpfp.Visible = false;
            glassPanelpfp.Invalidate();
            isGray = false;
        }

        private void glassPanel_Click(object sender, EventArgs e)
        {
            glassPanelBackground = new DarkenPanel
            {
                Dock = DockStyle.Fill,
                Opacity = 0.7f,
                BackColor = Color.FromArgb(0, 0, 0),
            };
            pMainPanel.Controls.Add(glassPanelBackground);
            glassPanelBackground.BringToFront();

            changePW = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Wählen Sie ein Profilbild aus";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Bildpfad erhalten
                string imagePath = openFileDialog.FileName;

                // Bild an ChangeProfilePic übergeben und öffnen
                ChangeProfilePic changeProfilePic = new ChangeProfilePic(this, imagePath);
                changeProfilePic.Show();
            }
        }

        private void pBUserProfile_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = pBUserProfile.PointToClient(Cursor.Position);

            bool isOverVisibleArea = !IsTransparentPixel.Check(userProfileBitmap, mousePosition, pBUserProfile.Width, pBUserProfile.Height);

            if (isOverVisibleArea && isGray == false)
            {
                isGray = true;
                ShowPannel();
            }
            else if (!isOverVisibleArea)
            {
                isGray = false;
                glassPanelpfp.Visible = false;
                glassPanelpfp.Invalidate();
            }
        }
        private void ShowPannel()
        {
            glassPanelpfp.Visible = true;
            glassPanelpfp.Invalidate();
        }
        public void SetImageToOtherForm(System.Drawing.Image image)
        {
            pBUserProfile.Image = image;
        }
    }
}
