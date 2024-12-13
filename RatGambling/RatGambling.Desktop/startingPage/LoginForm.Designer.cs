namespace RatGambling.Desktop.startingPage
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            tBEmail = new TextBox();
            tBPassword = new TextBox();
            pBSubmit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBSubmit).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.MainFormResources.GameLogo;
            pictureBox1.Location = new Point(138, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tBEmail
            // 
            tBEmail.BackColor = Color.FromArgb(224, 224, 224);
            tBEmail.BorderStyle = BorderStyle.None;
            tBEmail.Font = new Font("Arial Black", 12F);
            tBEmail.ForeColor = Color.FromArgb(64, 64, 64);
            tBEmail.Location = new Point(122, 188);
            tBEmail.Name = "tBEmail";
            tBEmail.PlaceholderText = "E-Mail";
            tBEmail.Size = new Size(156, 23);
            tBEmail.TabIndex = 100;
            tBEmail.TabStop = false;
            tBEmail.TextChanged += tBEmail_TextChanged;
            // 
            // tBPassword
            // 
            tBPassword.BackColor = Color.FromArgb(224, 224, 224);
            tBPassword.BorderStyle = BorderStyle.None;
            tBPassword.Font = new Font("Arial Black", 12F);
            tBPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tBPassword.Location = new Point(122, 236);
            tBPassword.Name = "tBPassword";
            tBPassword.PlaceholderText = "Password";
            tBPassword.Size = new Size(156, 23);
            tBPassword.TabIndex = 100;
            tBPassword.TabStop = false;
            tBPassword.Validated += tBPassword_Validated;
            // 
            // pBSubmit
            // 
            pBSubmit.Image = Properties.MainFormResources.submit_button;
            pBSubmit.Location = new Point(138, 299);
            pBSubmit.Name = "pBSubmit";
            pBSubmit.Size = new Size(126, 126);
            pBSubmit.SizeMode = PictureBoxSizeMode.StretchImage;
            pBSubmit.TabIndex = 3;
            pBSubmit.TabStop = false;
            pBSubmit.Click += pBSubmit_Click;
            pBSubmit.Paint += pBSubmit_Paint;
            pBSubmit.MouseEnter += pBSubmit_MouseEnter;
            pBSubmit.MouseLeave += pBSubmit_MouseLeave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(400, 500);
            Controls.Add(pBSubmit);
            Controls.Add(tBPassword);
            Controls.Add(tBEmail);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Log_RegForm";
            Deactivate += Log_RegForm_Deactivate;
            Load += Log_RegForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBSubmit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tBEmail;
        private TextBox tBPassword;
        private PictureBox pBSubmit;
    }
}