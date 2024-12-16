using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RatGambling.Desktop.startingPage
{
    public partial class ResetPasswordForm : Form
    {
        private MainForm parent = new();
        private float currentRotationAngle = 0;
        private System.Windows.Forms.Timer rotationTimer = new();
        private bool isRotating = false;
        public event EventHandler<string>? OptionSelected;
        string? selectedLink;
        private int rotationDirection = 1;
        private Random random = new Random();
        private Bitmap buttonImage;

        public ResetPasswordForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            InitializeSubmitButtonRotation();
            TextBox txtPWRequest = new TextBox();
            buttonImage = new Bitmap(pBSubmit.Image);
        }

        public ResetPasswordForm()
        {
            InitializeComponent();
            InitializeSubmitButtonRotation();
            buttonImage = new Bitmap(pBSubmit.Image);
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

        private void ResetPasswordForm_Deactivate(object sender, EventArgs e)
        {
            if (selectedLink == null)
            {
                parent?.glassPanel.Dispose();
                Close();
            }
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            Location = new Point(
                parent.Location.X + parent.Width / 2 - Width / 2,
                parent.Location.Y + parent.Height / 2 - Height / 2);

        }

        private void pBSubmit_Click(object sender, EventArgs e)
        {

        }

        private void RotationTimer_Tick(object? sender, EventArgs e)
        {
            if (!isRotating) return;

            currentRotationAngle = (currentRotationAngle + rotationDirection * 2) % 360;

            pBSubmit.Invalidate();
        }

        private void pBSubmit_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            var state = g.Save();

            g.TranslateTransform(pBSubmit.Width / 2, pBSubmit.Height / 2);
            g.RotateTransform(currentRotationAngle);
            g.TranslateTransform(-pBSubmit.Width / 2, -pBSubmit.Height / 2);

            if (pBSubmit.Image != null)
            {
                g.DrawImage(pBSubmit.Image, new Rectangle(0, 0, pBSubmit.Width, pBSubmit.Height));
            }

            g.Restore(state);
        }
        private void InitializeSubmitButtonRotation()
        {
            rotationTimer = new System.Windows.Forms.Timer();
            rotationTimer.Interval = 10;
            rotationTimer.Tick += RotationTimer_Tick;
        }
        private void pBBackToLogin_Click(object sender, EventArgs e)
        {
            selectedLink = "back";
            OptionSelected?.Invoke(this, "ProcessRepeat");
            this.Close();
            selectedLink = null;
        }

        private void pBSubmit_MouseDown(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBEmail.Text))
            {
                lLoginError.Text = "Das E-Mail-Feld darf nicht leer sein.";
                UpdateLabelPosition();
            }
            else if (!IsValidEmail(tBEmail.Text))
            {
                lLoginError.Text = "Die eingegebene E-Mail-Adresse hat ein ungültiges Format.";
                UpdateLabelPosition();
            }
            else
            {
                throw new NotImplementedException(); //Email senden
            }
        }
        void UpdateLabelPosition()
        {
            lLoginError.AutoSize = true;

            lLoginError.Left = (this.ClientSize.Width - lLoginError.Width) / 2;

            lLoginError.Top = tBEmail.Bottom + 10;
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }


        private bool IsTransparentPixel(Point clickLocation)
        {
            float scaleX = (float)buttonImage.Width / pBSubmit.Width;
            float scaleY = (float)buttonImage.Height / pBSubmit.Height;

            int imageX = (int)(clickLocation.X * scaleX);
            int imageY = (int)(clickLocation.Y * scaleY);

            if (imageX < 0 || imageX >= buttonImage.Width || imageY < 0 || imageY >= buttonImage.Height)
                return true;

            Color pixelColor = buttonImage.GetPixel(imageX, imageY);

            return pixelColor.A == 0;
        }

        private void pBSubmit_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = pBSubmit.PointToClient(Cursor.Position);

            if (IsTransparentPixel(mousePosition))
            {
                if (isRotating)
                {
                    isRotating = false;
                    rotationTimer.Stop();
                    pBSubmit.Invalidate();
                }
                return;
            }

            if (!isRotating)
            {
                rotationDirection = random.Next(0, 2) == 0 ? -1 : 1;
                isRotating = true;
                rotationTimer.Start();
            }
        }

        private void pBSubmit_MouseLeave(object sender, EventArgs e)
        {
            isRotating = false;
            rotationTimer.Stop();
            pBSubmit.Invalidate();
        }
    }

}
