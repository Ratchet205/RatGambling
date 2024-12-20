using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGambling.Desktop.src.customControl
{
    public class DarkenPanel : Control
    {
        public float Opacity { get; set; } = 1.0f; // Value between 0 (transparent) and 1 (opaque)

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using SolidBrush brush = new(Color.FromArgb((int)(Opacity * 255), this.BackColor));
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Avoid default background painting to maintain transparency effect
        }
    }
}
