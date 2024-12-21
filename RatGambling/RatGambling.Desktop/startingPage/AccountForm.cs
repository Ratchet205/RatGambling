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
            dTPBirthday.MaxDate = DateTime.Now.AddYears(-18);
            dTPBirthday.MinDate = DateTime.Now.AddYears(-200);
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
        private void DrawLabelBorder(PaintEventArgs e, Label label)
        {
            Graphics g = e.Graphics;
            Color borderColor = Color.Black;
            int borderWidth = 4;
            g.DrawRectangle(new Pen(borderColor, borderWidth),
                            label.ClientRectangle.X,
                            label.ClientRectangle.Y,
                            label.ClientRectangle.Width,
                            label.ClientRectangle.Height);
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
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Bildpfad erhalten
                string imagePath = openFileDialog.FileName;

                // Bild an ChangeProfilePic übergeben und öffnen
                ChangeProfilePic changeProfilePic = new ChangeProfilePic(this, imagePath);
                changeProfilePic.Show();
            }
            else if (result == DialogResult.Cancel)
            {
                glassPanelBackground.Dispose();
                changePW = false;
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

        private void lUsername_Click(object sender, EventArgs e)
        {

        }

        private void pUserName_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pUsername);
        }

        private void dTPBirthday_ValueChanged(object sender, EventArgs e)
        {
            tBBirthday.Text = dTPBirthday.Value.ToString("dd.MM.yyyy");
        }

        private void pBSavePISettings_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(tBBirthday.Text, "dd.MM.yyyy",
                               System.Globalization.CultureInfo.InvariantCulture,
                               System.Globalization.DateTimeStyles.None,
                               out DateTime parsedDate))
            {
                dTPBirthday.Value = parsedDate;
            }
            else
            {
                tBBirthday.Focus();
            }
        }

        private void tBBirthday_TextChanged(object sender, EventArgs e)
        {
            // Entferne alle Punkte, um die Formatierung neu anzuwenden
            string input = tBBirthday.Text.Replace(".", "");

            // Begrenze die Eingabe auf maximal 8 Zeichen
            if (input.Length > 8)
            {
                input = input.Substring(0, 8);
            }

            // Füge Punkte direkt nach dem zweiten und fünften Zeichen ein
            if (input.Length > 2)
                input = input.Insert(2, ".");
            if (input.Length > 5)
                input = input.Insert(5, ".");

            // Aktualisiere die TextBox ohne den Cursor zu verschieben
            tBBirthday.Text = input;
            tBBirthday.SelectionStart = input.Length; // Cursor ans Ende setzen
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dTPBirthday.Focus();
        }

        private void pEmail_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pEmail);
        }

        private void pPhonenumber_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pPhonenumber);
        }

        private void pBirthday_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pBirthday);
        }

        private void lSaveChangesPI_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            string username = tBUsername.Text;
            string email = tBEmail.Text;
            string phoneNumber = tBPhonenumber.Text;
            string birthday = tBBirthday.Text;

            bool hasUsernameError = string.IsNullOrEmpty(username);
            bool hasEmailError = string.IsNullOrEmpty(email) || !IsValidEmail(email);
            bool hasPhoneError = !string.IsNullOrEmpty(phoneNumber) && !IsValidPhoneNumber(phoneNumber);
            bool hasBirthdayError = !string.IsNullOrEmpty(birthday) && !IsValidBirthday(birthday);

            if (hasUsernameError && hasEmailError)
            {
                errorMessage = "Benutzername und E-Mail müssen angegeben werden.";
            }
            else if (hasUsernameError)
            {
                errorMessage = "Benutzername muss angegeben werden.";
            }
            else if (hasEmailError)
            {
                errorMessage = "E-Mail ist im falschen Format.";
            }
            else if (hasPhoneError)
            {
                errorMessage = "Telefonnummer ist im falschen Format.";
            }
            else if (hasBirthdayError)
            {
                errorMessage = "Geburtsdatum ist im falschen Format.";
            }

            lError.Text = errorMessage;
            CenterLabelHorizontally(lError);
            if (errorMessage == "")
            {
                throw new NotImplementedException(); //PersonalInformations in DB schreiben
            }
        }


        private void CenterLabelHorizontally(Label label)
        {
            int parentWidth = label.Parent.Width;
            int labelWidth = label.Width;
            int newX = (parentWidth - labelWidth) / 2;

            label.Location = new Point(newX, label.Location.Y);
        }

        private bool IsValidEmail(string email)
        {
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^\+?[0-9]{1,3}?[-.\s]?[0-9]+$");
            return regex.IsMatch(phoneNumber);
        }

        private bool IsValidBirthday(string birthday)
        {
            DateTime parsedDate;
            return DateTime.TryParseExact(birthday, "dd.MM.yyyy",
                                          System.Globalization.CultureInfo.InvariantCulture,
                                          System.Globalization.DateTimeStyles.None,
                                          out parsedDate);
        }




        private void lSaveChangesPI_Paint(object sender, PaintEventArgs e)
        {
            DrawLabelBorder(e, lSaveChangesPI);
        }

        private void pSecurity_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pSecurity);
        }

        private void pChangePassword_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pChangePassword);
        }

        private void p2FA_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, p2FA);
        }

        private void lSaveChangesS_Paint(object sender, PaintEventArgs e)
        {
            DrawLabelBorder(e, lSaveChangesS);
        }

        private void lSaveChangesS_Click(object sender, EventArgs e)
        {

        }

        private void pOther_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pOther);
        }

        private void pCommunication_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pCommunication);
        }
    }
}
