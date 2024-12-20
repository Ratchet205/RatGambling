using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGambling.Desktop.src.classes
{
    internal class IsTransparentPixel
    {
        /// <summary>
        /// Überprüft, ob der angeklickte Pixel im Bild transparent ist.
        /// </summary>
        /// <param name="image">Das Bild, in dem geprüft werden soll.</param>
        /// <param name="clickLocation">Die Klickposition relativ zum Control.</param>
        /// <param name="controlWidth">Die Breite des Controls, das das Bild anzeigt.</param>
        /// <param name="controlHeight">Die Höhe des Controls, das das Bild anzeigt.</param>
        /// <returns>True, wenn der Pixel transparent ist, sonst False.</returns>
        public static bool Check(Bitmap image, Point clickLocation, int controlWidth, int controlHeight)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image), "Image cannot be null.");

            float scaleX = (float)image.Width / controlWidth;
            float scaleY = (float)image.Height / controlHeight;

            int imageX = (int)(clickLocation.X * scaleX);
            int imageY = (int)(clickLocation.Y * scaleY);

            // Prüfen, ob die Klickposition außerhalb der Bildgrenzen liegt
            if (imageX < 0 || imageX >= image.Width || imageY < 0 || imageY >= image.Height)
                return true;

            Color pixelColor = image.GetPixel(imageX, imageY);

            // Gibt zurück, ob der Pixel vollständig transparent ist
            return pixelColor.A == 0;
        }
    }
}
