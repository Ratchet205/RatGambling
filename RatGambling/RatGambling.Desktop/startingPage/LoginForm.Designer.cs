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
            cBAccountRemember = new CheckBox();
            lRegisterText = new Label();
            lLRegister = new LinkLabel();
            lLPWReset = new LinkLabel();
            lLoginError = new Label();
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
            tBEmail.Font = new Font("Arial Black", 10F);
            tBEmail.ForeColor = Color.FromArgb(64, 64, 64);
            tBEmail.Location = new Point(79, 187);
            tBEmail.Name = "tBEmail";
            tBEmail.PlaceholderText = "E-Mail";
            tBEmail.Size = new Size(242, 19);
            tBEmail.TabIndex = 1;
            tBEmail.TabStop = false;
            tBEmail.TextChanged += tBEmail_TextChanged;
            tBEmail.Enter += tBEmail_Enter;
            // 
            // tBPassword
            // 
            tBPassword.BackColor = Color.FromArgb(224, 224, 224);
            tBPassword.BorderStyle = BorderStyle.None;
            tBPassword.Font = new Font("Arial Black", 10F);
            tBPassword.ForeColor = Color.FromArgb(64, 64, 64);
            tBPassword.Location = new Point(79, 233);
            tBPassword.Name = "tBPassword";
            tBPassword.PasswordChar = '•';
            tBPassword.PlaceholderText = "Password";
            tBPassword.Size = new Size(242, 19);
            tBPassword.TabIndex = 2;
            tBPassword.TabStop = false;
            tBPassword.TextChanged += tBPassword_TextChanged;
            tBPassword.Enter += tBPassword_Enter;
            tBPassword.Validated += tBPassword_Validated;
            // 
            // pBSubmit
            // 
            pBSubmit.Image = Properties.MainFormResources.submit_button_green;
            pBSubmit.Location = new Point(138, 299);
            pBSubmit.Name = "pBSubmit";
            pBSubmit.Size = new Size(126, 126);
            pBSubmit.SizeMode = PictureBoxSizeMode.StretchImage;
            pBSubmit.TabIndex = 3;
            pBSubmit.TabStop = false;
            pBSubmit.Click += pBSubmit_Click;
            pBSubmit.Paint += pBSubmit_Paint;
            pBSubmit.MouseDown += pBSubmit_MouseDown;
            pBSubmit.MouseLeave += pBSubmit_MouseLeave;
            pBSubmit.MouseMove += pBSubmit_MouseMove;
            // 
            // cBAccountRemember
            // 
            cBAccountRemember.AutoSize = true;
            cBAccountRemember.Font = new Font("Arial Black", 9F);
            cBAccountRemember.Location = new Point(79, 270);
            cBAccountRemember.Name = "cBAccountRemember";
            cBAccountRemember.Size = new Size(121, 21);
            cBAccountRemember.TabIndex = 3;
            cBAccountRemember.TabStop = false;
            cBAccountRemember.Text = "Remember me";
            cBAccountRemember.UseVisualStyleBackColor = true;
            cBAccountRemember.CheckedChanged += cBAccountRemember_CheckedChanged;
            // 
            // lRegisterText
            // 
            lRegisterText.AutoSize = true;
            lRegisterText.Font = new Font("Arial", 11F);
            lRegisterText.Location = new Point(78, 446);
            lRegisterText.Name = "lRegisterText";
            lRegisterText.Size = new Size(158, 17);
            lRegisterText.TabIndex = 102;
            lRegisterText.Text = "Dont have an account?";
            // 
            // lLRegister
            // 
            lLRegister.AutoSize = true;
            lLRegister.Font = new Font("Arial", 11F);
            lLRegister.LinkColor = Color.Black;
            lLRegister.Location = new Point(242, 446);
            lLRegister.Name = "lLRegister";
            lLRegister.Size = new Size(63, 17);
            lLRegister.TabIndex = 103;
            lLRegister.TabStop = true;
            lLRegister.Text = "Register";
            lLRegister.LinkClicked += lLRegister_LinkClicked;
            // 
            // lLPWReset
            // 
            lLPWReset.AutoSize = true;
            lLPWReset.Font = new Font("Arial", 11F);
            lLPWReset.LinkColor = Color.Black;
            lLPWReset.Location = new Point(227, 274);
            lLPWReset.Name = "lLPWReset";
            lLPWReset.Size = new Size(126, 17);
            lLPWReset.TabIndex = 105;
            lLPWReset.TabStop = true;
            lLPWReset.Text = "Forgot password?";
            lLPWReset.LinkClicked += lLPWReset_LinkClicked;
            // 
            // lLoginError
            // 
            lLoginError.AutoSize = true;
            lLoginError.ForeColor = Color.Red;
            lLoginError.Location = new Point(131, 162);
            lLoginError.Name = "lLoginError";
            lLoginError.Size = new Size(0, 15);
            lLoginError.TabIndex = 106;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(400, 500);
            Controls.Add(lLoginError);
            Controls.Add(lLPWReset);
            Controls.Add(lLRegister);
            Controls.Add(lRegisterText);
            Controls.Add(cBAccountRemember);
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
        private CheckBox cBAccountRemember;
        private Label lRegisterText;
        private LinkLabel lLRegister;
        private LinkLabel lLPWReset;
        private Label lLoginError;
    }
}