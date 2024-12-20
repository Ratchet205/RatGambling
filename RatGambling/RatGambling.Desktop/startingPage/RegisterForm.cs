using RatGambling.Desktop.src.classes;
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
        private readonly MainForm parent = new();
        private float currentRotationAngle = 0;
        private System.Windows.Forms.Timer rotationTimer = new();
        private bool isRotating = false;
        public event EventHandler<string>? OptionSelected;
        string? selectedLink;
        private int rotationDirection = 1;
        private readonly Random random = new();
        private readonly Bitmap buttonImage;
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
            buttonImage = new Bitmap(pBSubmit.Image);
        }
        private void TextBox_TextChanged(object? sender, EventArgs e)
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

            using Pen pen = new(borderColor, borderWidth);
            Rectangle rect = new(
                borderWidth / 2,
                borderWidth / 2,
                this.ClientSize.Width - borderWidth,
                this.ClientSize.Height - borderWidth);

            e.Graphics.DrawRectangle(pen, rect);
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
            rotationTimer = new()
            {
                Interval = 10
            };
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
            Point clickLocation = e.Location;
            if (IsTransparentPixel.Check(buttonImage, clickLocation, pBSubmit.Width, pBSubmit.Height))
            {
                return;
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

                //Close();
            }
        }
        void UpdateLabelPosition()
        {
            lLoginError.AutoSize = true;
            lLoginError.Left = (this.ClientSize.Width - lLoginError.Width) / 2;
        }

        private static bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Passwort-Validierung
        private static bool IsValidPassword(string password)
        {
            // Mindestens ein Großbuchstabe, eine Zahl und ein Sonderzeichen
            var passwordPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        private void pBSubmit_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = pBSubmit.PointToClient(Cursor.Position);

            if (IsTransparentPixel.Check(buttonImage, mousePosition, pBSubmit.Width, pBSubmit.Height))
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
                cBOver18Request.ForeColor = Color.FromArgb(0, 200, 71);
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
                cBAccountRemember.ForeColor = Color.FromArgb(0x0c, 0x7a, 0xe0);
            }
            else
            {
                cBAccountRemember.ForeColor = Color.Black;
            }
        }
    }
}
