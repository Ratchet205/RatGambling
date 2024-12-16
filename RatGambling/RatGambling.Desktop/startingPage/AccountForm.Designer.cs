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
            pPersInformations = new Panel();
            pMainPanel = new src.customControl.ScrollablePanel();
            pMainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pPersInformations
            // 
            pPersInformations.BackColor = Color.FromArgb(44, 44, 44);
            pPersInformations.Location = new Point(39, 30);
            pPersInformations.Margin = new Padding(30);
            pPersInformations.Name = "pPersInformations";
            pPersInformations.Padding = new Padding(20);
            pPersInformations.Size = new Size(322, 177);
            pPersInformations.TabIndex = 0;
            pPersInformations.Paint += pPersInformations_Paint;
            // 
            // pMainPanel
            // 
            pMainPanel.AutoScroll = true;
            pMainPanel.Controls.Add(pPersInformations);
            pMainPanel.Location = new Point(0, 0);
            pMainPanel.Name = "pMainPanel";
            pMainPanel.Size = new Size(400, 500);
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
            pMainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pPersInformations;
        private src.customControl.ScrollablePanel pMainPanel;
    }
}