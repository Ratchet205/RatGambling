using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class DarkenPanel : Control
{
    public float Opacity { get; set; } = 1.0f; // Value between 0 (transparent) and 1 (opaque)

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (SolidBrush brush = new SolidBrush(Color.FromArgb((int)(Opacity * 255), this.BackColor)))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // Avoid default background painting to maintain transparency effect
    }
}
