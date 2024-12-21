using RatGambling.Desktop.src.customControl;
using System.Drawing.Drawing2D;

namespace RatGambling.Desktop.startingPage
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pPersInformation = new Panel();
            lError = new Label();
            lSaveChangesPI = new Label();
            lPersInformation = new Label();
            pBirthday = new Panel();
            pictureBox1 = new PictureBox();
            lBirthday = new Label();
            dTPBirthday = new DateTimePicker();
            tBBirthday = new TextBox();
            pPhonenumber = new Panel();
            tBPhonenumber = new TextBox();
            lPhonenumber = new Label();
            pEmail = new Panel();
            tBEmail = new TextBox();
            lEmail = new Label();
            pUsername = new Panel();
            tBUsername = new TextBox();
            lUsername = new Label();
            pBUserProfile = new PictureBox();
            pMainPanel = new ScrollablePanel();
            pOther = new Panel();
            label3 = new Label();
            label4 = new Label();
            lOther = new Label();
            pCommunication = new Panel();
            cBCommunication = new CheckBox();
            lCommunication = new Label();
            pSecurity = new Panel();
            p2FA = new Panel();
            l2FA = new Label();
            label1 = new Label();
            lSaveChangesS = new Label();
            lSecurity = new Label();
            pChangePassword = new Panel();
            tBConfirmNewPWD = new TextBox();
            tBNewPWD = new TextBox();
            tBLatestPW = new TextBox();
            lChangePassword = new Label();
            pPersInformation.SuspendLayout();
            pBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pPhonenumber.SuspendLayout();
            pEmail.SuspendLayout();
            pUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBUserProfile).BeginInit();
            pMainPanel.SuspendLayout();
            pOther.SuspendLayout();
            pCommunication.SuspendLayout();
            pSecurity.SuspendLayout();
            p2FA.SuspendLayout();
            pChangePassword.SuspendLayout();
            SuspendLayout();
            // 
            // pPersInformation
            // 
            pPersInformation.BackColor = Color.FromArgb(44, 44, 44);
            pPersInformation.Controls.Add(lError);
            pPersInformation.Controls.Add(lSaveChangesPI);
            pPersInformation.Controls.Add(lPersInformation);
            pPersInformation.Controls.Add(pBirthday);
            pPersInformation.Controls.Add(pPhonenumber);
            pPersInformation.Controls.Add(pEmail);
            pPersInformation.Controls.Add(pUsername);
            pPersInformation.Controls.Add(pBUserProfile);
            pPersInformation.Location = new Point(39, 30);
            pPersInformation.Margin = new Padding(30);
            pPersInformation.Name = "pPersInformation";
            pPersInformation.Padding = new Padding(20);
            pPersInformation.Size = new Size(322, 454);
            pPersInformation.TabIndex = 0;
            pPersInformation.Paint += pPersInformations_Paint;
            // 
            // lError
            // 
            lError.AutoSize = true;
            lError.Font = new Font("Segoe UI", 7F);
            lError.Location = new Point(142, 126);
            lError.Name = "lError";
            lError.Size = new Size(0, 12);
            lError.TabIndex = 10;
            // 
            // lSaveChangesPI
            // 
            lSaveChangesPI.Font = new Font("Arial Black", 9.5F);
            lSaveChangesPI.ForeColor = Color.FromArgb(162, 43, 64);
            lSaveChangesPI.Location = new Point(199, 420);
            lSaveChangesPI.Name = "lSaveChangesPI";
            lSaveChangesPI.Size = new Size(113, 24);
            lSaveChangesPI.TabIndex = 9;
            lSaveChangesPI.Text = "Save Changes";
            lSaveChangesPI.TextAlign = ContentAlignment.MiddleCenter;
            lSaveChangesPI.Click += lSaveChangesPI_Click;
            lSaveChangesPI.Paint += lSaveChangesPI_Paint;
            // 
            // lPersInformation
            // 
            lPersInformation.AutoSize = true;
            lPersInformation.Font = new Font("Arial Black", 6F);
            lPersInformation.ForeColor = Color.FromArgb(162, 43, 64);
            lPersInformation.Location = new Point(5, 5);
            lPersInformation.Name = "lPersInformation";
            lPersInformation.Size = new Size(96, 11);
            lPersInformation.TabIndex = 7;
            lPersInformation.Text = "Personal Information";
            // 
            // pBirthday
            // 
            pBirthday.BackColor = Color.FromArgb(34, 34, 34);
            pBirthday.Controls.Add(pictureBox1);
            pBirthday.Controls.Add(lBirthday);
            pBirthday.Controls.Add(dTPBirthday);
            pBirthday.Controls.Add(tBBirthday);
            pBirthday.Location = new Point(23, 341);
            pBirthday.Name = "pBirthday";
            pBirthday.Size = new Size(276, 60);
            pBirthday.TabIndex = 6;
            pBirthday.Paint += pBirthday_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(70, 70, 70);
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.MainFormResources.calendar;
            pictureBox1.Location = new Point(243, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lBirthday
            // 
            lBirthday.AutoSize = true;
            lBirthday.Font = new Font("Arial Black", 9F);
            lBirthday.ForeColor = Color.FromArgb(162, 43, 64);
            lBirthday.Location = new Point(10, 10);
            lBirthday.Name = "lBirthday";
            lBirthday.Size = new Size(63, 17);
            lBirthday.TabIndex = 1;
            lBirthday.Text = "Birthday";
            // 
            // dTPBirthday
            // 
            dTPBirthday.CustomFormat = "dd.MM.yyyy";
            dTPBirthday.Format = DateTimePickerFormat.Custom;
            dTPBirthday.Location = new Point(243, 30);
            dTPBirthday.MaxDate = new DateTime(2006, 12, 20, 16, 18, 7, 718);
            dTPBirthday.MinDate = new DateTime(1904, 12, 20, 15, 54, 42, 658);
            dTPBirthday.Name = "dTPBirthday";
            dTPBirthday.Size = new Size(23, 23);
            dTPBirthday.TabIndex = 5;
            dTPBirthday.Value = new DateTime(2006, 12, 20, 15, 18, 7, 718);
            dTPBirthday.ValueChanged += dTPBirthday_ValueChanged;
            // 
            // tBBirthday
            // 
            tBBirthday.BackColor = Color.FromArgb(70, 70, 70);
            tBBirthday.BorderStyle = BorderStyle.None;
            tBBirthday.Font = new Font("Arial", 15F);
            tBBirthday.Location = new Point(10, 30);
            tBBirthday.Name = "tBBirthday";
            tBBirthday.PlaceholderText = "dd.MM.yyyy";
            tBBirthday.Size = new Size(256, 23);
            tBBirthday.TabIndex = 6;
            tBBirthday.TextChanged += tBBirthday_TextChanged;
            // 
            // pPhonenumber
            // 
            pPhonenumber.BackColor = Color.FromArgb(34, 34, 34);
            pPhonenumber.Controls.Add(tBPhonenumber);
            pPhonenumber.Controls.Add(lPhonenumber);
            pPhonenumber.Location = new Point(23, 275);
            pPhonenumber.Name = "pPhonenumber";
            pPhonenumber.Size = new Size(276, 60);
            pPhonenumber.TabIndex = 4;
            pPhonenumber.Paint += pPhonenumber_Paint;
            // 
            // tBPhonenumber
            // 
            tBPhonenumber.BackColor = Color.FromArgb(70, 70, 70);
            tBPhonenumber.BorderStyle = BorderStyle.None;
            tBPhonenumber.Font = new Font("Arial", 15F);
            tBPhonenumber.Location = new Point(10, 30);
            tBPhonenumber.Name = "tBPhonenumber";
            tBPhonenumber.PlaceholderText = "Enter Phone number";
            tBPhonenumber.Size = new Size(256, 23);
            tBPhonenumber.TabIndex = 2;
            // 
            // lPhonenumber
            // 
            lPhonenumber.AutoSize = true;
            lPhonenumber.Font = new Font("Arial Black", 9F);
            lPhonenumber.ForeColor = Color.FromArgb(162, 43, 64);
            lPhonenumber.Location = new Point(10, 10);
            lPhonenumber.Name = "lPhonenumber";
            lPhonenumber.Size = new Size(102, 17);
            lPhonenumber.TabIndex = 1;
            lPhonenumber.Text = "Phone number";
            // 
            // pEmail
            // 
            pEmail.BackColor = Color.FromArgb(34, 34, 34);
            pEmail.Controls.Add(tBEmail);
            pEmail.Controls.Add(lEmail);
            pEmail.Location = new Point(23, 209);
            pEmail.Name = "pEmail";
            pEmail.Size = new Size(276, 60);
            pEmail.TabIndex = 3;
            pEmail.Paint += pEmail_Paint;
            // 
            // tBEmail
            // 
            tBEmail.BackColor = Color.FromArgb(70, 70, 70);
            tBEmail.BorderStyle = BorderStyle.None;
            tBEmail.Font = new Font("Arial", 15F);
            tBEmail.Location = new Point(10, 30);
            tBEmail.Name = "tBEmail";
            tBEmail.PlaceholderText = "examble@examble.com";
            tBEmail.Size = new Size(256, 23);
            tBEmail.TabIndex = 2;
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Font = new Font("Arial Black", 9F);
            lEmail.ForeColor = Color.FromArgb(162, 43, 64);
            lEmail.Location = new Point(10, 10);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(48, 17);
            lEmail.TabIndex = 1;
            lEmail.Text = "E-Mail";
            // 
            // pUsername
            // 
            pUsername.BackColor = Color.FromArgb(34, 34, 34);
            pUsername.Controls.Add(tBUsername);
            pUsername.Controls.Add(lUsername);
            pUsername.Location = new Point(23, 143);
            pUsername.Name = "pUsername";
            pUsername.Size = new Size(276, 60);
            pUsername.TabIndex = 2;
            pUsername.Paint += pUserName_Paint;
            // 
            // tBUsername
            // 
            tBUsername.BackColor = Color.FromArgb(70, 70, 70);
            tBUsername.BorderStyle = BorderStyle.None;
            tBUsername.Font = new Font("Arial", 15F);
            tBUsername.Location = new Point(10, 30);
            tBUsername.Name = "tBUsername";
            tBUsername.PlaceholderText = "Enter username";
            tBUsername.Size = new Size(256, 23);
            tBUsername.TabIndex = 2;
            // 
            // lUsername
            // 
            lUsername.AutoSize = true;
            lUsername.Font = new Font("Arial Black", 9F);
            lUsername.ForeColor = Color.FromArgb(162, 43, 64);
            lUsername.Location = new Point(10, 10);
            lUsername.Name = "lUsername";
            lUsername.Size = new Size(75, 17);
            lUsername.TabIndex = 1;
            lUsername.Text = "Username";
            lUsername.Click += lUsername_Click;
            // 
            // pBUserProfile
            // 
            pBUserProfile.BackgroundImageLayout = ImageLayout.None;
            pBUserProfile.Image = Properties.MainFormResources.standartUser;
            pBUserProfile.Location = new Point(111, 23);
            pBUserProfile.Name = "pBUserProfile";
            pBUserProfile.Size = new Size(100, 100);
            pBUserProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pBUserProfile.TabIndex = 0;
            pBUserProfile.TabStop = false;
            pBUserProfile.MouseMove += pBUserProfile_MouseMove;
            // 
            // pMainPanel
            // 
            pMainPanel.AutoScroll = true;
            pMainPanel.BackColor = Color.Transparent;
            pMainPanel.Controls.Add(pOther);
            pMainPanel.Controls.Add(pSecurity);
            pMainPanel.Controls.Add(pPersInformation);
            pMainPanel.Location = new Point(0, 0);
            pMainPanel.Name = "pMainPanel";
            pMainPanel.Size = new Size(400, 1088);
            pMainPanel.TabIndex = 1;
            // 
            // pOther
            // 
            pOther.BackColor = Color.FromArgb(44, 44, 44);
            pOther.Controls.Add(label3);
            pOther.Controls.Add(label4);
            pOther.Controls.Add(lOther);
            pOther.Controls.Add(pCommunication);
            pOther.Location = new Point(39, 945);
            pOther.Margin = new Padding(30);
            pOther.Name = "pOther";
            pOther.Padding = new Padding(20);
            pOther.Size = new Size(322, 419);
            pOther.TabIndex = 2;
            pOther.Paint += pOther_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.Location = new Point(172, 40);
            label3.Name = "label3";
            label3.Size = new Size(0, 12);
            label3.TabIndex = 10;
            // 
            // label4
            // 
            label4.Font = new Font("Arial Black", 9.5F);
            label4.ForeColor = Color.FromArgb(162, 43, 64);
            label4.Location = new Point(199, 375);
            label4.Name = "label4";
            label4.Size = new Size(113, 24);
            label4.TabIndex = 9;
            label4.Text = "Save Changes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lOther
            // 
            lOther.AutoSize = true;
            lOther.Font = new Font("Arial Black", 6F);
            lOther.ForeColor = Color.FromArgb(162, 43, 64);
            lOther.Location = new Point(5, 5);
            lOther.Name = "lOther";
            lOther.Size = new Size(30, 11);
            lOther.TabIndex = 7;
            lOther.Text = "Other";
            // 
            // pCommunication
            // 
            pCommunication.BackColor = Color.FromArgb(34, 34, 34);
            pCommunication.Controls.Add(cBCommunication);
            pCommunication.Controls.Add(lCommunication);
            pCommunication.Location = new Point(23, 37);
            pCommunication.Name = "pCommunication";
            pCommunication.Size = new Size(276, 158);
            pCommunication.TabIndex = 2;
            pCommunication.Paint += pCommunication_Paint;
            // 
            // cBCommunication
            // 
            cBCommunication.AutoSize = true;
            cBCommunication.Font = new Font("Arial Black", 9F);
            cBCommunication.Location = new Point(10, 43);
            cBCommunication.Name = "cBCommunication";
            cBCommunication.Size = new Size(239, 21);
            cBCommunication.TabIndex = 2;
            cBCommunication.Text = "Communication of Rat Gambling";
            cBCommunication.UseVisualStyleBackColor = true;
            // 
            // lCommunication
            // 
            lCommunication.AutoSize = true;
            lCommunication.Font = new Font("Arial Black", 9F);
            lCommunication.ForeColor = Color.FromArgb(162, 43, 64);
            lCommunication.Location = new Point(10, 10);
            lCommunication.Name = "lCommunication";
            lCommunication.Size = new Size(110, 17);
            lCommunication.TabIndex = 1;
            lCommunication.Text = "Communication";
            // 
            // pSecurity
            // 
            pSecurity.BackColor = Color.FromArgb(44, 44, 44);
            pSecurity.Controls.Add(p2FA);
            pSecurity.Controls.Add(label1);
            pSecurity.Controls.Add(lSaveChangesS);
            pSecurity.Controls.Add(lSecurity);
            pSecurity.Controls.Add(pChangePassword);
            pSecurity.Location = new Point(39, 504);
            pSecurity.Margin = new Padding(30);
            pSecurity.Name = "pSecurity";
            pSecurity.Padding = new Padding(20);
            pSecurity.Size = new Size(322, 419);
            pSecurity.TabIndex = 1;
            pSecurity.Paint += pSecurity_Paint;
            // 
            // p2FA
            // 
            p2FA.BackColor = Color.FromArgb(34, 34, 34);
            p2FA.Controls.Add(l2FA);
            p2FA.Location = new Point(23, 201);
            p2FA.Name = "p2FA";
            p2FA.Size = new Size(276, 158);
            p2FA.TabIndex = 11;
            p2FA.Paint += p2FA_Paint;
            // 
            // l2FA
            // 
            l2FA.AutoSize = true;
            l2FA.Font = new Font("Arial Black", 9F);
            l2FA.ForeColor = Color.FromArgb(162, 43, 64);
            l2FA.Location = new Point(10, 10);
            l2FA.Name = "l2FA";
            l2FA.Size = new Size(178, 17);
            l2FA.TabIndex = 1;
            l2FA.Text = "Two-factor authentication";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(152, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 12);
            label1.TabIndex = 10;
            // 
            // lSaveChangesS
            // 
            lSaveChangesS.Font = new Font("Arial Black", 9.5F);
            lSaveChangesS.ForeColor = Color.FromArgb(162, 43, 64);
            lSaveChangesS.Location = new Point(199, 375);
            lSaveChangesS.Name = "lSaveChangesS";
            lSaveChangesS.Size = new Size(113, 24);
            lSaveChangesS.TabIndex = 9;
            lSaveChangesS.Text = "Save Changes";
            lSaveChangesS.TextAlign = ContentAlignment.MiddleCenter;
            lSaveChangesS.Click += lSaveChangesS_Click;
            lSaveChangesS.Paint += lSaveChangesS_Paint;
            // 
            // lSecurity
            // 
            lSecurity.AutoSize = true;
            lSecurity.Font = new Font("Arial Black", 6F);
            lSecurity.ForeColor = Color.FromArgb(162, 43, 64);
            lSecurity.Location = new Point(5, 5);
            lSecurity.Name = "lSecurity";
            lSecurity.Size = new Size(42, 11);
            lSecurity.TabIndex = 7;
            lSecurity.Text = "Security";
            // 
            // pChangePassword
            // 
            pChangePassword.BackColor = Color.FromArgb(34, 34, 34);
            pChangePassword.Controls.Add(tBConfirmNewPWD);
            pChangePassword.Controls.Add(tBNewPWD);
            pChangePassword.Controls.Add(tBLatestPW);
            pChangePassword.Controls.Add(lChangePassword);
            pChangePassword.Location = new Point(23, 37);
            pChangePassword.Name = "pChangePassword";
            pChangePassword.Size = new Size(276, 158);
            pChangePassword.TabIndex = 2;
            pChangePassword.Paint += pChangePassword_Paint;
            // 
            // tBConfirmNewPWD
            // 
            tBConfirmNewPWD.BackColor = Color.FromArgb(70, 70, 70);
            tBConfirmNewPWD.BorderStyle = BorderStyle.None;
            tBConfirmNewPWD.Font = new Font("Arial", 15F);
            tBConfirmNewPWD.Location = new Point(10, 110);
            tBConfirmNewPWD.Name = "tBConfirmNewPWD";
            tBConfirmNewPWD.PlaceholderText = "Confirm new password";
            tBConfirmNewPWD.Size = new Size(256, 23);
            tBConfirmNewPWD.TabIndex = 4;
            // 
            // tBNewPWD
            // 
            tBNewPWD.BackColor = Color.FromArgb(70, 70, 70);
            tBNewPWD.BorderStyle = BorderStyle.None;
            tBNewPWD.Font = new Font("Arial", 15F);
            tBNewPWD.Location = new Point(10, 70);
            tBNewPWD.Name = "tBNewPWD";
            tBNewPWD.PlaceholderText = "New password";
            tBNewPWD.Size = new Size(256, 23);
            tBNewPWD.TabIndex = 3;
            // 
            // tBLatestPW
            // 
            tBLatestPW.BackColor = Color.FromArgb(70, 70, 70);
            tBLatestPW.BorderStyle = BorderStyle.None;
            tBLatestPW.Font = new Font("Arial", 15F);
            tBLatestPW.Location = new Point(10, 30);
            tBLatestPW.Name = "tBLatestPW";
            tBLatestPW.PlaceholderText = "Latest password";
            tBLatestPW.Size = new Size(256, 23);
            tBLatestPW.TabIndex = 2;
            // 
            // lChangePassword
            // 
            lChangePassword.AutoSize = true;
            lChangePassword.Font = new Font("Arial Black", 9F);
            lChangePassword.ForeColor = Color.FromArgb(162, 43, 64);
            lChangePassword.Location = new Point(10, 10);
            lChangePassword.Name = "lChangePassword";
            lChangePassword.Size = new Size(123, 17);
            lChangePassword.TabIndex = 1;
            lChangePassword.Text = "Change password";
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(400, 500);
            Controls.Add(pMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountForm";
            Deactivate += AccountForm_Deactivate;
            Load += AccountForm_Load;
            pPersInformation.ResumeLayout(false);
            pPersInformation.PerformLayout();
            pBirthday.ResumeLayout(false);
            pBirthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pPhonenumber.ResumeLayout(false);
            pPhonenumber.PerformLayout();
            pEmail.ResumeLayout(false);
            pEmail.PerformLayout();
            pUsername.ResumeLayout(false);
            pUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBUserProfile).EndInit();
            pMainPanel.ResumeLayout(false);
            pOther.ResumeLayout(false);
            pOther.PerformLayout();
            pCommunication.ResumeLayout(false);
            pCommunication.PerformLayout();
            pSecurity.ResumeLayout(false);
            pSecurity.PerformLayout();
            p2FA.ResumeLayout(false);
            p2FA.PerformLayout();
            pChangePassword.ResumeLayout(false);
            pChangePassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pPersInformation;
        private src.customControl.ScrollablePanel pMainPanel;
        private PictureBox pBUserProfile;
        private Label lUsername;
        private Panel pUsername;
        private TextBox tBUsername;
        private Panel pEmail;
        private TextBox tBEmail;
        private Label lEmail;
        private Panel pBirthday;
        private Label lBirthday;
        private DateTimePicker dTPBirthday;
        private Panel pPhonenumber;
        private TextBox tBPhonenumber;
        private Label lPhonenumber;
        private Label lPersInformation;
        private TextBox tBBirthday;
        private PictureBox pictureBox1;
        private Label lSaveChangesPI;
        private Label lError;
        private Panel pSecurity;
        private Label label1;
        private Label lSaveChangesS;
        private Label lSecurity;
        private Panel panel2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Panel pCommunication;
        private Label lOther;
        private Panel panel4;
        private TextBox textBox3;
        private Label lCommunication;
        private Panel pChangePassword;
        private TextBox tBLatestPW;
        private Label lChangePassword;
        private TextBox tBConfirmNewPWD;
        private TextBox tBNewPWD;
        private Panel p2FA;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label l2FA;
        private Panel pOther;
        private Label label2;
        private Label label3;
        private CheckBox cBCommunication;
    }
}