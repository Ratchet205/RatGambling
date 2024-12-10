namespace RatGambling.Desktop.src
{
    partial class StdForm
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
            pTopBorder = new Panel();
            pBMin = new PictureBox();
            pBExit = new PictureBox();
            pTopBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBExit).BeginInit();
            SuspendLayout();
            // 
            // pTopBorder
            // 
            pTopBorder.BackColor = Color.FromArgb(228, 21, 75);
            pTopBorder.Controls.Add(pBMin);
            pTopBorder.Controls.Add(pBExit);
            pTopBorder.Dock = DockStyle.Top;
            pTopBorder.Location = new Point(0, 0);
            pTopBorder.Name = "pTopBorder";
            pTopBorder.Size = new Size(1620, 32);
            pTopBorder.TabIndex = 0;
            // 
            // pBMin
            // 
            pBMin.Dock = DockStyle.Right;
            pBMin.Location = new Point(1540, 0);
            pBMin.Name = "pBMin";
            pBMin.Size = new Size(40, 32);
            pBMin.TabIndex = 1;
            pBMin.TabStop = false;
            pBMin.Click += pBMin_Click;
            pBMin.Paint += pBMin_Paint;
            pBMin.MouseEnter += pBMin_MouseEnter;
            pBMin.MouseLeave += pBMin_MouseLeave;
            // 
            // pBExit
            // 
            pBExit.Dock = DockStyle.Right;
            pBExit.Location = new Point(1580, 0);
            pBExit.Name = "pBExit";
            pBExit.Size = new Size(40, 32);
            pBExit.TabIndex = 0;
            pBExit.TabStop = false;
            pBExit.Click += pBExit_Click;
            pBExit.Paint += pBExit_Paint;
            pBExit.MouseEnter += pBExit_MouseEnter;
            pBExit.MouseLeave += pBExit_MouseLeave;
            // 
            // StdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1620, 1020);
            Controls.Add(pTopBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StdForm";
            Text = "StdForm";
            pTopBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pTopBorder;
        private PictureBox pBMin;
        private PictureBox pBExit;
    }
}