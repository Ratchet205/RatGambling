using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGambling.Desktop.src.customControl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class ScrollablePanel : Panel
    {
        // Import ShowScrollBar API
        [DllImport("user32.dll")]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        private const int SB_HORZ = 0; // Horizontal scrollbar
        private const int SB_VERT = 1; // Vertical scrollbar
        private const int SB_BOTH = 3; // Both scrollbars

        public ScrollablePanel()
        {
            this.AutoScroll = true; // Enable scrolling
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Hide both horizontal and vertical scrollbars
            ShowScrollBar(this.Handle, SB_BOTH, false);
        }
    }
}
