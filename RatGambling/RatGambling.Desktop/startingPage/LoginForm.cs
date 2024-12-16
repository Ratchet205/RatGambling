using System;
using System.Drawing;
using System.Windows.Forms;
using BCrypt.Net;
using System.Text.RegularExpressions;

namespace RatGambling.Desktop.startingPage
{
    public partial class LoginForm : Form
    {
        public event EventHandler<string>? OptionSelected;
        private MainForm parent = new();
        private float currentRotationAngle = 0;
        private System.Windows.Forms.Timer rotationTimer = new();
        private bool isRotating = false;
        string? selectedLink;
        private int rotationDirection = 1;
        private Random random = new Random();
        private Bitmap buttonImage;

        public LoginForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            InitializeSubmitButtonRotation();
            buttonImage = new Bitmap(pBSubmit.Image);
        }

        public LoginForm()
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

        private void Log_RegForm_Deactivate(object sender, EventArgs e)
        {
            if (selectedLink == null)
            {
                parent?.glassPanel.Dispose();
            }
            Close();
        }

        private void Log_RegForm_Load(object sender, EventArgs e)
        {
            Location = new Point(
                parent.Location.X + parent.Width / 2 - Width / 2,
                parent.Location.Y + parent.Height / 2 - Height / 2);
        }
        void UpdateLabelPosition()
        {
            lLoginError.AutoSize = true;
            lLoginError.Left = (this.ClientSize.Width - lLoginError.Width) / 2;
        }

        private void pBSubmit_Click(object sender, EventArgs e)
        {

        }
        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsCorrectUsernameOrPassword(string email, string password)
        {
            throw new NotImplementedException(); // Implementiere DB-Passwort Überprüfung
        }

        private void SaveToDatabase(string email, string hashedPassword, bool keepLogin)
        {
            throw new NotImplementedException(); // Implementiere DB-Logik hier
        }

        private void InitializeSubmitButtonRotation()
        {
            rotationTimer = new System.Windows.Forms.Timer();
            rotationTimer.Interval = 10;
            rotationTimer.Tick += RotationTimer_Tick;
        }

        private void RotationTimer_Tick(object? sender, EventArgs e)
        {
            if (!isRotating) return;

            currentRotationAngle = (currentRotationAngle + rotationDirection * 2) % 360;

            pBSubmit.Invalidate();
        }

        private void pBSubmit_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pBSubmit_MouseLeave(object sender, EventArgs e)
        {
            isRotating = false;
            rotationTimer.Stop();
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

        private void tBPassword_Validated(object sender, EventArgs e)
        {
            Focus();
        }

        private void tBEmail_TextChanged(object sender, EventArgs e)
        {
            tBEmail.TabStop = true;
            tBPassword.TabStop = true;
            cBAccountRemember.TabStop = true;
            lLPWReset.TabStop = false;
            lLRegister.TabStop = false;
        }

        private void lLPWReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedLink = "Reset";
            this.Close();
            OptionSelected?.Invoke(this, "PWReset");
            selectedLink = null;
        }

        private void lLRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedLink = "Register";
            this.Close();
            OptionSelected?.Invoke(this, "Register");
            selectedLink = null;
        }

        private void pBSubmit_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsTransparentPixel(e.Location))
            {
                return;
            }

            string email = tBEmail.Text;
            string password = tBPassword.Text;

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
            else if (!IsCorrectUsernameOrPassword(email, password))
            {
                lLoginError.Text = "Incorrect username or password.";
                UpdateLabelPosition();
            }
            else
            {
                string hashedPW = BCrypt.Net.BCrypt.HashPassword(password);
                bool keepLogin = cBAccountRemember.Checked;

                SaveToDatabase(email, hashedPW, keepLogin);
                Close();
            }
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

        private void tBEmail_Enter(object sender, EventArgs e)
        {
            tBEmail.TabStop = true;
            tBPassword.TabStop = true;
            cBAccountRemember.TabStop = true;
            lLPWReset.TabStop = false;
            lLRegister.TabStop = false;
        }

        private void tBPassword_Enter(object sender, EventArgs e)
        {
            tBEmail.TabStop = true;
            tBPassword.TabStop = true;
            cBAccountRemember.TabStop = true;
            lLPWReset.TabStop = false;
            lLRegister.TabStop = false;
        }

        private void tBPassword_TextChanged(object sender, EventArgs e)
        {
            tBEmail.TabStop = true;
            tBPassword.TabStop = true;
            cBAccountRemember.TabStop = true;
            lLPWReset.TabStop = false;
            lLRegister.TabStop = false;
        }

        private void cBAccountRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAccountRemember.Checked)
            {
                cBAccountRemember.ForeColor = Color.FromArgb(0x0c,0x7a,0xe0);
            }
            else
            {
                cBAccountRemember.ForeColor = Color.Black;
            }
        }
    }
}
