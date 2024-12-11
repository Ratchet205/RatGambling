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
            pBQuit = new PictureBox();
            pQuitButton = new Panel();
            ((System.ComponentModel.ISupportInitialize)pBPlayButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBQuit).BeginInit();
            pQuitButton.SuspendLayout();
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
            // pBQuit
            // 
            pBQuit.BackgroundImageLayout = ImageLayout.Stretch;
            pBQuit.Image = Properties.Resources.quit_rat_walking;
            pBQuit.Location = new Point(303, 0);
            pBQuit.Name = "pBQuit";
            pBQuit.Size = new Size(100, 106);
            pBQuit.SizeMode = PictureBoxSizeMode.StretchImage;
            pBQuit.TabIndex = 2;
            pBQuit.TabStop = false;
            pBQuit.Click += pQuitButton_Click;
            // 
            // pQuitButton
            // 
            pQuitButton.Controls.Add(pBQuit);
            pQuitButton.Location = new Point(12, 898);
            pQuitButton.Name = "pQuitButton";
            pQuitButton.Size = new Size(403, 106);
            pQuitButton.TabIndex = 3;
            pQuitButton.Click += pQuitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1620, 1020);
            Controls.Add(pQuitButton);
            Controls.Add(pBPlayButton);
            Name = "MainForm";
            Text = "MainForm";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            Controls.SetChildIndex(pBPlayButton, 0);
            Controls.SetChildIndex(pQuitButton, 0);
            ((System.ComponentModel.ISupportInitialize)pBPlayButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBQuit).EndInit();
            pQuitButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBPlayButton;
        private PictureBox pBQuit;
        private Panel pQuitButton;
    }
}