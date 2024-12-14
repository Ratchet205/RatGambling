namespace RatGambling.Desktop.startingPage
{
    partial class RegisterForm
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
            pBSubmit = new PictureBox();
            tBPassword = new TextBox();
            tBEmail = new TextBox();
            pictureBox1 = new PictureBox();
            pBBackToLogin = new PictureBox();
            tBName = new TextBox();
            tBConfirmPassword = new TextBox();
            cBOver18Request = new CheckBox();
            lLoginError = new Label();
            cBAccountRemember = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pBSubmit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBBackToLogin).BeginInit();
            SuspendLayout();
            // 
            // pBSubmit
            // 
            pBSubmit.Image = Properties.MainFormResources.submit_button_red;
            pBSubmit.Location = new Point(138, 348);
            pBSubmit.Name = "pBSubmit";
            pBSubmit.Size = new Size(126, 126);
            pBSubmit.SizeMode = PictureBoxSizeMode.StretchImage;
            pBSubmit.TabIndex = 7;
            pBSubmit.TabStop = false;
            pBSubmit.Paint += pBSubmit_Paint;
            pBSubmit.MouseDown += pBSubmit_MouseDown;
            pBSubmit.MouseLeave += pBSubmit_MouseLeave;
            pBSubmit.MouseMove += pBSubmit_MouseMove;
            // 
            // tBPassword
            // 
            tBPassword.BackColor = Color.FromArgb(224, 224, 224);
            tBPassword.BorderStyle = BorderStyle.None;
            tBPassword.Font = new Font("Arial Black", 10F);
            tBPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tBPassword.Location = new Point(79, 245);
            tBPassword.Name = "tBPassword";
            tBPassword.PlaceholderText = "Password";
            tBPassword.Size = new Size(242, 19);
            tBPassword.TabIndex = 3;
            tBPassword.TabStop = false;
            // 
            // tBEmail
            // 
            tBEmail.BackColor = Color.FromArgb(224, 224, 224);
            tBEmail.BorderStyle = BorderStyle.None;
            tBEmail.Font = new Font("Arial Black", 10F);
            tBEmail.ForeColor = Color.FromArgb(64, 64, 64);
            tBEmail.Location = new Point(79, 215);
            tBEmail.Name = "tBEmail";
            tBEmail.PlaceholderText = "E-Mail";
            tBEmail.Size = new Size(242, 19);
            tBEmail.TabIndex = 2;
            tBEmail.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.MainFormResources.GameLogo;
            pictureBox1.Location = new Point(138, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pBBackToLogin
            // 
            pBBackToLogin.Image = Properties.MainFormResources.arrowBack;
            pBBackToLogin.Location = new Point(12, 12);
            pBBackToLogin.Name = "pBBackToLogin";
            pBBackToLogin.Size = new Size(39, 29);
            pBBackToLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pBBackToLogin.TabIndex = 9;
            pBBackToLogin.TabStop = false;
            pBBackToLogin.Click += pBBackToLogin_Click;
            // 
            // tBName
            // 
            tBName.BackColor = Color.FromArgb(224, 224, 224);
            tBName.BorderStyle = BorderStyle.None;
            tBName.Font = new Font("Arial Black", 10F);
            tBName.ForeColor = Color.FromArgb(64, 64, 64);
            tBName.Location = new Point(79, 185);
            tBName.Name = "tBName";
            tBName.PlaceholderText = "Name";
            tBName.Size = new Size(242, 19);
            tBName.TabIndex = 1;
            tBName.TabStop = false;
            // 
            // tBConfirmPassword
            // 
            tBConfirmPassword.BackColor = Color.FromArgb(224, 224, 224);
            tBConfirmPassword.BorderStyle = BorderStyle.None;
            tBConfirmPassword.Font = new Font("Arial Black", 10F);
            tBConfirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tBConfirmPassword.Location = new Point(79, 275);
            tBConfirmPassword.Name = "tBConfirmPassword";
            tBConfirmPassword.PlaceholderText = "Confirm Password";
            tBConfirmPassword.Size = new Size(242, 19);
            tBConfirmPassword.TabIndex = 4;
            tBConfirmPassword.TabStop = false;
            // 
            // cBOver18Request
            // 
            cBOver18Request.AutoSize = true;
            cBOver18Request.Font = new Font("Arial Black", 7F);
            cBOver18Request.ForeColor = Color.Red;
            cBOver18Request.Location = new Point(79, 300);
            cBOver18Request.Name = "cBOver18Request";
            cBOver18Request.Size = new Size(248, 18);
            cBOver18Request.TabIndex = 5;
            cBOver18Request.TabStop = false;
            cBOver18Request.Text = "I confirm that I am at least 18 years old.";
            cBOver18Request.UseVisualStyleBackColor = true;
            cBOver18Request.CheckedChanged += cBOver18Request_CheckedChanged;
            // 
            // lLoginError
            // 
            lLoginError.AutoSize = true;
            lLoginError.ForeColor = Color.Red;
            lLoginError.Location = new Point(184, 164);
            lLoginError.Name = "lLoginError";
            lLoginError.Size = new Size(0, 15);
            lLoginError.TabIndex = 13;
            // 
            // cBAccountRemember
            // 
            cBAccountRemember.AutoSize = true;
            cBAccountRemember.Font = new Font("Arial Black", 7F);
            cBAccountRemember.ForeColor = Color.Black;
            cBAccountRemember.Location = new Point(79, 324);
            cBAccountRemember.Name = "cBAccountRemember";
            cBAccountRemember.Size = new Size(131, 18);
            cBAccountRemember.TabIndex = 6;
            cBAccountRemember.TabStop = false;
            cBAccountRemember.Text = "Keep me logged in";
            cBAccountRemember.UseVisualStyleBackColor = true;
            cBAccountRemember.CheckedChanged += cBAccountRemember_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(400, 500);
            Controls.Add(cBAccountRemember);
            Controls.Add(lLoginError);
            Controls.Add(cBOver18Request);
            Controls.Add(tBConfirmPassword);
            Controls.Add(tBName);
            Controls.Add(pBBackToLogin);
            Controls.Add(pBSubmit);
            Controls.Add(tBPassword);
            Controls.Add(tBEmail);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Deactivate += RegisterForm_Deactivate;
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pBSubmit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBBackToLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBSubmit;
        private TextBox tBPassword;
        private TextBox tBEmail;
        private PictureBox pictureBox1;
        private PictureBox pBBackToLogin;
        private TextBox tBName;
        private TextBox tBConfirmPassword;
        private CheckBox cBOver18Request;
        private Label lLoginError;
        private CheckBox cBAccountRemember;
    }
}