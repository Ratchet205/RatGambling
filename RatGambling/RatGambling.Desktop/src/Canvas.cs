using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGambling.Desktop.src
{
    internal class Canvas(int begin_X, int begin_Y, int width, int height)
    {
        private (int X, int Y) _location = (begin_X, begin_Y);
        public (int X, int Y) Location => _location;

        private int _width = width;
        public int Width => _width;

        private int _height = height;
        public int Height => _height;

        private (int X, int Y) _center = (begin_X + width/2, begin_Y + height/2);
        public (int X, int Y) Center => _center;
    }
}
