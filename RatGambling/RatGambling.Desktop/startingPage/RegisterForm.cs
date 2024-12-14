using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RatGambling.Desktop.startingPage
{
    public partial class RegisterForm : Form
    {
        private MainForm parent = new();
        private float currentRotationAngle = 0;
        private System.Windows.Forms.Timer rotationTimer = new();
        private bool isRotating = false;
        public event EventHandler<string> OptionSelected;
        string? selectedLink;
        private int rotationDirection = 1;
        private Random random = new Random();
        private Bitmap buttonImage;
        public RegisterForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            InitializeSubmitButtonRotation();
            buttonImage = new Bitmap(pBSubmit.Image);

            tBEmail.TextChanged += TextBox_TextChanged;
            tBPassword.TextChanged += TextBox_TextChanged;
            tBConfirmPassword.TextChanged += TextBox_TextChanged;
            tBName.TextChanged += TextBox_TextChanged;
            cBAccountRemember.CheckStateChanged += TextBox_TextChanged;
            cBOver18Request.CheckStateChanged += TextBox_TextChanged;
            tBEmail.Enter += TextBox_TextChanged;
            tBPassword.Enter += TextBox_TextChanged;
            tBConfirmPassword.Enter += TextBox_TextChanged;
            tBName.Enter += TextBox_TextChanged;
            cBAccountRemember.Enter += TextBox_TextChanged;
            cBOver18Request.Enter += TextBox_TextChanged;

        }
        public RegisterForm()
        {
            InitializeComponent();
            InitializeSubmitButtonRotation();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            tBEmail.TabStop = true;
            tBPassword.TabStop = true;
            tBConfirmPassword.TabStop = true;
            tBName.TabStop = true;
            cBAccountRemember.TabStop = true;
            cBOver18Request.TabStop = true;
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
        private void RegisterForm_Deactivate(object sender, EventArgs e)
        {
            if (selectedLink == null)
            {
                parent?.glassPanel.Dispose();
                Close();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

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
            // Prüfen, ob der angeklickte Pixel transparent ist
            Point clickLocation = e.Location; // Die Klickposition relativ zur PictureBox
            if (IsTransparentPixel(clickLocation))
            {
                return; // Klick ignorieren, wenn es ein transparenter Bereich ist
            }

            string name = tBName.Text;
            string email = tBEmail.Text;
            string password = tBPassword.Text;
            string confirmPassword = tBConfirmPassword.Text;
            bool over18 = cBOver18Request.Checked;

            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(password))
            {
                lLoginError.Text = "Email and password are required.";
                UpdateLabelPosition();
            }
            else if (string.IsNullOrWhiteSpace(email))
            {
                lLoginError.Text = "The email field is required.";
                UpdateLabelPosition();
            }
            else if (!IsValidEmail(email))
            {
                lLoginError.Text = "The email address is not in a valid format.";
                UpdateLabelPosition();
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                lLoginError.Text = "The password field is required.";
                UpdateLabelPosition();
            }
            else if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                lLoginError.Text = "Please confirm your password.";
                UpdateLabelPosition();
            }
            else if (tBPassword.Text != tBConfirmPassword.Text)
            {
                lLoginError.Text = "Passwords do not match.";
                UpdateLabelPosition();
            }
            else if (!over18)
            {
                lLoginError.Text = "You must be over 18 to sign in.";
                UpdateLabelPosition();
            }
            else
            {
                string hashedPW = BCrypt.Net.BCrypt.HashPassword(password);
                bool keepLogin = cBAccountRemember.Checked;
                if (string.IsNullOrWhiteSpace(name))
                {
                    name = "User1";
                }

                throw new NotImplementedException(); //In DB reinschreiben danach anmelden

                Close();
            }
        }
        void UpdateLabelPosition()
        {
            lLoginError.AutoSize = true;
            lLoginError.Left = (this.ClientSize.Width - lLoginError.Width) / 2;
        }

        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Passwort-Validierung
        private bool IsValidPassword(string password)
        {
            // Mindestens ein Großbuchstabe, eine Zahl und ein Sonderzeichen
            var passwordPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }


        private bool IsTransparentPixel(Point clickLocation)
        {
            // Konvertiere die Klickkoordinaten in die Bildkoordinaten
            float scaleX = (float)buttonImage.Width / pBSubmit.Width;
            float scaleY = (float)buttonImage.Height / pBSubmit.Height;

            int imageX = (int)(clickLocation.X * scaleX);
            int imageY = (int)(clickLocation.Y * scaleY);

            // Sicherstellen, dass die Koordinaten im gültigen Bereich sind
            if (imageX < 0 || imageX >= buttonImage.Width || imageY < 0 || imageY >= buttonImage.Height)
                return true; // Klick außerhalb des Bildes behandeln wie "transparent"

            // Farbe des Pixels prüfen
            Color pixelColor = buttonImage.GetPixel(imageX, imageY);

            // Wenn der Pixel transparent ist (Alpha = 0), zurückgeben
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

        private void cBOver18Request_CheckedChanged(object sender, EventArgs e)
        {
            if (cBOver18Request.Checked)
            {
                cBOver18Request.ForeColor = Color.GreenYellow;
            }
            else
            {
                cBOver18Request.ForeColor = Color.Red;
            }
        }

        private void cBAccountRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAccountRemember.Checked)
            {
                cBAccountRemember.ForeColor = Color.GreenYellow;
            }
            else
            {
                cBAccountRemember.ForeColor = Color.Black;
            }
        }
    }
}
