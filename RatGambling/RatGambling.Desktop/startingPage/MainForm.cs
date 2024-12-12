#pragma warning disable
using RatGambling.Desktop.Properties;
using RatGambling.Desktop.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatGambling.Desktop.startingPage
{
    public partial class MainForm : StdForm
    {
        private Image unpressedImage;
        private Image hoverImage;
        private Image pressedImage;
        //private Point originalLocation;

        public MainForm()
        {
            InitializeComponent();

            unpressedImage = Properties.Resources.play_button_unpressed;
            hoverImage = ApplyHoverEffect(unpressedImage);
            pressedImage = ApplyPressedEffect(Properties.Resources.play_button_pressed);


        }
        #region PlayButton

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //pictureBox1.Location = new Point(originalLocation.X + 5, originalLocation.Y + 5);
            pBPlayButton.BackgroundImage = pressedImage;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //pictureBox1.Location = originalLocation;
            pBPlayButton.BackgroundImage = hoverImage;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pBPlayButton.BackgroundImage = hoverImage;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pBPlayButton.BackgroundImage = unpressedImage;
        }

        private Image ApplyHoverEffect(Image original)
        {
            var colorMatrix = new ColorMatrix(
                new float[][]{
                    new float[] {0.5f, 0, 0, 0, 0},
                    new float[] {0, 0.5f, 0, 0, 0},
                    new float[] {0, 0, 0.5f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                }
            );

            var imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            // Ein neues Bitmap mit Graustufen erstellen
            Bitmap grayscaleImage = new Bitmap(original.Width, original.Height);
            using (Graphics g = Graphics.FromImage(grayscaleImage))
            {
                g.DrawImage(original, new Rectangle(0, 0, grayscaleImage.Width, grayscaleImage.Height),
                    0, 0, original.Width, original.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return grayscaleImage;
        }
        private Image ApplyPressedEffect(Image original)
        {
            var colorMatrix = new ColorMatrix(
                new float[][]{
                    new float[] {0.4f, 0, 0, 0, 0},
                    new float[] {0, 0.4f, 0, 0, 0},
                    new float[] {0, 0, 0.4f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                }
            );

            var imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            // Erstelle ein neues Bitmap mit dem "gedrückten" Effekt
            Bitmap pressedImage = new Bitmap(original.Width, original.Height);
            using (Graphics g = Graphics.FromImage(pressedImage))
            {
                g.DrawImage(original, new Rectangle(0, 0, pressedImage.Width, pressedImage.Height),
                    0, 0, original.Width, original.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return pressedImage;
        }
        #endregion

        #region RatSecret
        private void pBRatMoving_Click(object sender, EventArgs e)
        {
            pBRatStanding.Visible = !pBRatStanding.Visible;
            pBRatMoving.Visible = !pBRatMoving.Visible;
        }

        private void pBRatStanding_Click(object sender, EventArgs e)
        {
            pBRatStanding.Visible = !pBRatStanding.Visible;
            pBRatMoving.Visible = !pBRatMoving.Visible;
        }
        #endregion
    }
}
#pragma warning restore