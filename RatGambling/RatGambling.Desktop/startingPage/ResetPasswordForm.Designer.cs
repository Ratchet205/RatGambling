namespace RatGambling.Desktop.startingPage
{
    partial class ResetPasswordForm
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
            tBEmail = new TextBox();
            pictureBox1 = new PictureBox();
            tBRequest = new TextBox();
            pBBackToLogin = new PictureBox();
            lLoginError = new Label();
            ((System.ComponentModel.ISupportInitialize)pBSubmit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBBackToLogin).BeginInit();
            SuspendLayout();
            // 
            // pBSubmit
            // 
            pBSubmit.Image = Properties.MainFormResources.submit_button_blue;
            pBSubmit.Location = new Point(138, 299);
            pBSubmit.Name = "pBSubmit";
            pBSubmit.Size = new Size(126, 126);
            pBSubmit.SizeMode = PictureBoxSizeMode.StretchImage;
            pBSubmit.TabIndex = 6;
            pBSubmit.TabStop = false;
            pBSubmit.Paint += pBSubmit_Paint;
            pBSubmit.MouseDown += pBSubmit_MouseDown;
            pBSubmit.MouseLeave += pBSubmit_MouseLeave;
            pBSubmit.MouseMove += pBSubmit_MouseMove;
            // 
            // tBEmail
            // 
            tBEmail.BackColor = Color.FromArgb(224, 224, 224);
            tBEmail.BorderStyle = BorderStyle.None;
            tBEmail.Font = new Font("Arial Black", 10F);
            tBEmail.ForeColor = Color.FromArgb(64, 64, 64);
            tBEmail.Location = new Point(79, 250);
            tBEmail.Name = "tBEmail";
            tBEmail.PlaceholderText = "E-Mail";
            tBEmail.Size = new Size(242, 19);
            tBEmail.TabIndex = 5;
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
            // tBRequest
            // 
            tBRequest.BackColor = Color.FromArgb(54, 54, 54);
            tBRequest.BorderStyle = BorderStyle.None;
            tBRequest.ForeColor = Color.FromArgb(190, 190, 190);
            tBRequest.Location = new Point(79, 171);
            tBRequest.Multiline = true;
            tBRequest.Name = "tBRequest";
            tBRequest.ReadOnly = true;
            tBRequest.Size = new Size(242, 49);
            tBRequest.TabIndex = 7;
            tBRequest.TabStop = false;
            tBRequest.Text = "Enter the email address you used during sign up on Rat Gambling, and we'll send you instructions on how to reset your password.";
            // 
            // pBBackToLogin
            // 
            pBBackToLogin.Image = Properties.MainFormResources.arrowBack;
            pBBackToLogin.Location = new Point(12, 12);
            pBBackToLogin.Name = "pBBackToLogin";
            pBBackToLogin.Size = new Size(39, 29);
            pBBackToLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pBBackToLogin.TabIndex = 8;
            pBBackToLogin.TabStop = false;
            pBBackToLogin.Click += pBBackToLogin_Click;
            // 
            // lLoginError
            // 
            lLoginError.AutoSize = true;
            lLoginError.ForeColor = Color.Red;
            lLoginError.Location = new Point(184, 279);
            lLoginError.Name = "lLoginError";
            lLoginError.Size = new Size(0, 15);
            lLoginError.TabIndex = 107;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(400, 500);
            Controls.Add(lLoginError);
            Controls.Add(pBBackToLogin);
            Controls.Add(tBRequest);
            Controls.Add(pBSubmit);
            Controls.Add(tBEmail);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPasswordForm";
            Deactivate += ResetPasswordForm_Deactivate;
            Load += ResetPasswordForm_Load;
            ((System.ComponentModel.ISupportInitialize)pBSubmit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBBackToLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBSubmit;
        private TextBox tBEmail;
        private PictureBox pictureBox1;
        private TextBox tBRequest;
        private PictureBox pBBackToLogin;
        private Label lLoginError;
    }
}