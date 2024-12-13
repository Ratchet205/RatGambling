using System;
using System.Drawing;
using System.Windows.Forms;
using BCrypt.Net;

namespace RatGambling.Desktop.startingPage
{
    public partial class LoginForm : Form
    {
        private MainForm parent;
        private float currentRotationAngle = 0;
        private System.Windows.Forms.Timer rotationTimer;
        private bool isRotating = false;

        public LoginForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            InitializeSubmitButtonRotation();
        }

        public LoginForm()
        {
            InitializeComponent();
            InitializeSubmitButtonRotation();
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
            parent?.glassPanel.Dispose();
            Close();
        }

        private void Log_RegForm_Load(object sender, EventArgs e)
        {
            Location = new Point(
                parent.Location.X + parent.Width / 2 - Width / 2,
                parent.Location.Y + parent.Height / 2 - Height / 2);
        }

        private void pBSubmit_Click(object sender, EventArgs e)
        {
            string email = tBEmail.Text;
            string password = tBPassword.Text;
            string hashedPW = BCrypt.Net.BCrypt.HashPassword(password);

            // Übergeben an DB
            throw new NotImplementedException();
            // Close(); // Aktivieren, nachdem die Datenbankimplementierung abgeschlossen ist
        }

        private void InitializeSubmitButtonRotation()
        {
            rotationTimer = new System.Windows.Forms.Timer();
            rotationTimer.Interval = 10; // Geschwindigkeit der Rotation (10ms)
            rotationTimer.Tick += RotationTimer_Tick;
        }

        private void RotationTimer_Tick(object? sender, EventArgs e)
        {
            if (!isRotating) return;

            currentRotationAngle = (currentRotationAngle + 2) % 360; // Rotiert um 2 Grad pro Tick
            pBSubmit.Invalidate(); // Aktualisiert den Button
        }

        private void pBSubmit_MouseEnter(object sender, EventArgs e)
        {
            isRotating = true;
            rotationTimer.Start();
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

            // Speichere den aktuellen Zustand von Graphics
            var state = g.Save();

            // Zentrum setzen und rotieren
            g.TranslateTransform(pBSubmit.Width / 2, pBSubmit.Height / 2);
            g.RotateTransform(currentRotationAngle);
            g.TranslateTransform(-pBSubmit.Width / 2, -pBSubmit.Height / 2);

            // Bild zeichnen, falls vorhanden
            if (pBSubmit.Image != null)
            {
                g.DrawImage(pBSubmit.Image, new Rectangle(0, 0, pBSubmit.Width, pBSubmit.Height));
            }

            // Zustand wiederherstellen
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
        }
    }
}
