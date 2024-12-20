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
            pBUserProfile = new PictureBox();
            pMainPanel = new ScrollablePanel();
            pPersInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBUserProfile).BeginInit();
            pMainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pPersInformation
            // 
            pPersInformation.BackColor = Color.FromArgb(44, 44, 44);
            pPersInformation.Controls.Add(pBUserProfile);
            pPersInformation.Location = new Point(39, 30);
            pPersInformation.Margin = new Padding(30);
            pPersInformation.Name = "pPersInformation";
            pPersInformation.Padding = new Padding(20);
            pPersInformation.Size = new Size(322, 318);
            pPersInformation.TabIndex = 0;
            pPersInformation.Paint += pPersInformations_Paint;
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
            pMainPanel.Controls.Add(pPersInformation);
            pMainPanel.Location = new Point(0, 0);
            pMainPanel.Name = "pMainPanel";
            pMainPanel.Size = new Size(400, 446);
            pMainPanel.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)pBUserProfile).EndInit();
            pMainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pPersInformation;
        private src.customControl.ScrollablePanel pMainPanel;
        private PictureBox pBUserProfile;
    }
}