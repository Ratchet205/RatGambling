using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RatGambling.Desktop.startingPage
{
    public partial class AccountForm : Form
    {
        private MainForm parent = new();
        public AccountForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            Location = new Point(
                parent.Location.X + parent.Width / 2 - Width / 2,
                parent.Location.Y + parent.Height / 2 - Height / 2);

            pMainPanel.Size = new System.Drawing.Size(this.ClientSize.Width - 10, this.ClientSize.Height - 10);
            pMainPanel.Location = new System.Drawing.Point(5, 5);

            pMainPanel.AutoScroll = true;

            pMainPanel.VerticalScroll.Visible = false;
            pMainPanel.HorizontalScroll.Visible = false;
        }



        private void pPersInformations_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(e, pPersInformations);
        }

        private void DrawPanelBorder(PaintEventArgs e, Panel panel)
        {
            Graphics g = e.Graphics;
            Color borderColor = Color.Black;
            int borderWidth = 4;
            g.DrawRectangle(new Pen(borderColor, borderWidth),
                            panel.ClientRectangle.X,
                            panel.ClientRectangle.Y,
                            panel.ClientRectangle.Width,
                            panel.ClientRectangle.Height);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderWidth = 2;
            Color borderColor = Color.FromArgb(0xc3, 0x3f, 0x3f);

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                Rectangle rect = new Rectangle(
                    borderWidth / 2,
                    borderWidth / 2,
                    this.ClientSize.Width - borderWidth,
                    this.ClientSize.Height - borderWidth);

                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void AccountForm_Deactivate(object sender, EventArgs e)
        {
            parent?.glassPanel.Dispose();
            Close();
        }
    }
}
