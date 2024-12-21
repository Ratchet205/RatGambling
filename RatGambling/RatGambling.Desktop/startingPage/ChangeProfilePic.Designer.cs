namespace RatGambling.Desktop.startingPage
{
    partial class ChangeProfilePic
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
            pBExit = new PictureBox();
            pBChangePfP = new PictureBox();
            bFinishEdit = new Button();
            trBZoomPFP = new TrackBar();
            pTopBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBChangePfP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trBZoomPFP).BeginInit();
            SuspendLayout();
            // 
            // pTopBorder
            // 
            pTopBorder.BackColor = Color.Purple;
            pTopBorder.Controls.Add(pBExit);
            pTopBorder.Dock = DockStyle.Top;
            pTopBorder.Location = new Point(0, 0);
            pTopBorder.Name = "pTopBorder";
            pTopBorder.Size = new Size(384, 32);
            pTopBorder.TabIndex = 2;
            // 
            // pBExit
            // 
            pBExit.Dock = DockStyle.Right;
            pBExit.Location = new Point(344, 0);
            pBExit.Name = "pBExit";
            pBExit.Size = new Size(40, 32);
            pBExit.TabIndex = 0;
            pBExit.TabStop = false;
            pBExit.Click += pBExit_Click;
            pBExit.Paint += pBExit_Paint;
            pBExit.MouseEnter += pBExit_MouseEnter;
            pBExit.MouseLeave += pBExit_MouseLeave;
            // 
            // pBChangePfP
            // 
            pBChangePfP.Location = new Point(39, 83);
            pBChangePfP.Name = "pBChangePfP";
            pBChangePfP.Size = new Size(100, 100);
            pBChangePfP.TabIndex = 3;
            pBChangePfP.TabStop = false;
            // 
            // bFinishEdit
            // 
            bFinishEdit.Location = new Point(197, 126);
            bFinishEdit.Name = "bFinishEdit";
            bFinishEdit.Size = new Size(75, 23);
            bFinishEdit.TabIndex = 4;
            bFinishEdit.Text = "Finish";
            bFinishEdit.UseVisualStyleBackColor = true;
            bFinishEdit.Click += bFinishEdit_Click;
            // 
            // trBZoomPFP
            // 
            trBZoomPFP.Location = new Point(39, 189);
            trBZoomPFP.Name = "trBZoomPFP";
            trBZoomPFP.Size = new Size(100, 45);
            trBZoomPFP.TabIndex = 5;
            trBZoomPFP.Scroll += trBZoomPFP_Scroll;
            // 
            // ChangeProfilePic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            ClientSize = new Size(384, 261);
            Controls.Add(trBZoomPFP);
            Controls.Add(bFinishEdit);
            Controls.Add(pBChangePfP);
            Controls.Add(pTopBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeProfilePic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeProfilePic";
            Deactivate += ChangeProfilePic_Deactivate;
            Load += ChangeProfilePic_Load;
            pTopBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBChangePfP).EndInit();
            ((System.ComponentModel.ISupportInitialize)trBZoomPFP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pTopBorder;
        private PictureBox pBExit;
        private PictureBox pBChangePfP;
        private Button bFinishEdit;
        private TrackBar trBZoomPFP;
    }
}