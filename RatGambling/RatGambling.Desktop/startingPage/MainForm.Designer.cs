using System.Drawing.Drawing2D;

namespace RatGambling.Desktop.startingPage
{
    partial class MainForm
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
            pBPlayButton = new PictureBox();
            pBRatStanding = new PictureBox();
            pBRatMoving = new PictureBox();
            pBHeadLine = new PictureBox();
            pBQuitButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBPlayButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBRatStanding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBRatMoving).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBHeadLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBQuitButton).BeginInit();
            SuspendLayout();
            // 
            // pBPlayButton
            // 
            pBPlayButton.BackgroundImage = Properties.Resources.play_button_unpressed;
            pBPlayButton.BackgroundImageLayout = ImageLayout.Stretch;
            pBPlayButton.ErrorImage = null;
            pBPlayButton.Location = new Point(710, 410);
            pBPlayButton.Name = "pBPlayButton";
            pBPlayButton.Size = new Size(200, 200);
            pBPlayButton.TabIndex = 1;
            pBPlayButton.TabStop = false;
            pBPlayButton.Click += pBPlayButton_Click;
            pBPlayButton.MouseDown += pBPlayButton_MouseDown;
            pBPlayButton.MouseEnter += pBPlayButton_MouseEnter;
            pBPlayButton.MouseLeave += pBPlayButton_MouseLeave;
            pBPlayButton.MouseUp += pBPlayButton_MouseUp;
            // 
            // pBRatStanding
            // 
            pBRatStanding.BackgroundImageLayout = ImageLayout.Stretch;
            pBRatStanding.Image = Properties.Resources.rat_standing;
            pBRatStanding.Location = new Point(571, 104);
            pBRatStanding.Name = "pBRatStanding";
            pBRatStanding.Size = new Size(117, 141);
            pBRatStanding.SizeMode = PictureBoxSizeMode.StretchImage;
            pBRatStanding.TabIndex = 2;
            pBRatStanding.TabStop = false;
            pBRatStanding.Click += pBRatStanding_Click;
            // 
            // pBRatMoving
            // 
            pBRatMoving.BackgroundImageLayout = ImageLayout.Stretch;
            pBRatMoving.Image = Properties.Resources.rat_walking;
            pBRatMoving.Location = new Point(571, 104);
            pBRatMoving.Name = "pBRatMoving";
            pBRatMoving.Size = new Size(117, 141);
            pBRatMoving.SizeMode = PictureBoxSizeMode.StretchImage;
            pBRatMoving.TabIndex = 5;
            pBRatMoving.TabStop = false;
            pBRatMoving.Visible = false;
            pBRatMoving.Click += pBRatMoving_Click;
            // 
            // pBHeadLine
            // 
            pBHeadLine.Image = Properties.Resources.heading;
            pBHeadLine.Location = new Point(107, 38);
            pBHeadLine.Name = "pBHeadLine";
            pBHeadLine.Size = new Size(1285, 366);
            pBHeadLine.TabIndex = 6;
            pBHeadLine.TabStop = false;
            // 
            // pBQuitButton
            // 
            pBQuitButton.Image = Properties.Resources.rat_of_spades_QUIT;
            pBQuitButton.Location = new Point(12, 755);
            pBQuitButton.Name = "pBQuitButton";
            pBQuitButton.Size = new Size(180, 253);
            pBQuitButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pBQuitButton.TabIndex = 7;
            pBQuitButton.TabStop = false;
            pBQuitButton.Click += pBQuitButton_Click;
            pBQuitButton.MouseDown += pBQuitButton_MouseDown;
            pBQuitButton.MouseEnter += pBQuitButton_MouseEnter;
            pBQuitButton.MouseLeave += pBQuitButton_MouseLeave;
            pBQuitButton.MouseUp += pBQuitButton_MouseUp;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1620, 1020);
            Controls.Add(pBQuitButton);
            Controls.Add(pBRatMoving);
            Controls.Add(pBRatStanding);
            Controls.Add(pBPlayButton);
            Controls.Add(pBHeadLine);
            Name = "MainForm";
            Text = "";
            Controls.SetChildIndex(pBHeadLine, 0);
            Controls.SetChildIndex(pBPlayButton, 0);
            Controls.SetChildIndex(pBRatStanding, 0);
            Controls.SetChildIndex(pBRatMoving, 0);
            Controls.SetChildIndex(pBQuitButton, 0);
            ((System.ComponentModel.ISupportInitialize)pBPlayButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBRatStanding).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBRatMoving).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBHeadLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBQuitButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBPlayButton;
        private PictureBox pBRatStanding;
        private PictureBox pBRatMoving;
        private PictureBox pBHeadLine;
        private PictureBox pBQuitButton;
    }
}