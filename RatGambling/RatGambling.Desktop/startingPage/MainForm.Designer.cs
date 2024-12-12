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
            pQuitButton = new Panel();
            pictureBox1 = new PictureBox();
            pBRatMoving = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBPlayButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBRatStanding).BeginInit();
            pQuitButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBRatMoving).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            pBPlayButton.Click += pictureBox1_Click;
            pBPlayButton.MouseDown += pictureBox1_MouseDown;
            pBPlayButton.MouseEnter += pictureBox1_MouseEnter;
            pBPlayButton.MouseLeave += pictureBox1_MouseLeave;
            pBPlayButton.MouseUp += pictureBox1_MouseUp;
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
            // pQuitButton
            // 
            pQuitButton.Controls.Add(pictureBox1);
            pQuitButton.Location = new Point(12, 898);
            pQuitButton.Name = "pQuitButton";
            pQuitButton.Size = new Size(403, 106);
            pQuitButton.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.quit;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.heading;
            pictureBox2.Location = new Point(107, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1285, 366);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1620, 1020);
            Controls.Add(pBRatMoving);
            Controls.Add(pBRatStanding);
            Controls.Add(pQuitButton);
            Controls.Add(pBPlayButton);
            Controls.Add(pictureBox2);
            Name = "MainForm";
            Text = "";
            Controls.SetChildIndex(pictureBox2, 0);
            Controls.SetChildIndex(pBPlayButton, 0);
            Controls.SetChildIndex(pQuitButton, 0);
            Controls.SetChildIndex(pBRatStanding, 0);
            Controls.SetChildIndex(pBRatMoving, 0);
            ((System.ComponentModel.ISupportInitialize)pBPlayButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBRatStanding).EndInit();
            pQuitButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBRatMoving).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBPlayButton;
        private PictureBox pBRatStanding;
        private Panel pQuitButton;
        private PictureBox pBRatMoving;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}