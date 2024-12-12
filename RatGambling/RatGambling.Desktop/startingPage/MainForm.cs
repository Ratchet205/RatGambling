#pragma warning disable
using RatGambling.Desktop.Properties;
using RatGambling.Desktop.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        //
        //PlayButton 1/3
        //
        #region PlayButton
        private Image unpressedImage;
        private Image hoverImage;
        private Image pressedImage;
        #endregion
        //
        //QuitButton 1/3
        //
        #region QuitButton
        //Hover-Event
        private System.Windows.Forms.Timer shakeTimer;
        private int shakeDistance = 5;
        private int shakeSpeed = 40;
        private Random random = new Random();
        private Point originalLocation;

        //Down-Event
        private Image originalImage;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            //
            //PlayButton 2/3
            //
            #region PlayButton
            unpressedImage = Properties.MainFormResources.play_button_unpressed;
            hoverImage = ApplyHoverEffect(unpressedImage);
            pressedImage = ApplyPressedEffect(Properties.MainFormResources.play_button_pressed);
            #endregion
            //
            //QuitButton 2/3
            //
            #region QuitButton
            //Hover-Event
            originalLocation = pBQuitButton.Location;
            shakeTimer = new System.Windows.Forms.Timer();
            shakeTimer.Interval = shakeSpeed;
            shakeTimer.Tick += ShakeTimer_Tick;

            //Down-Event
            originalImage = pBQuitButton.Image;
            #endregion


        }
        //
        //PlayButton 3/3
        //
        #region PlayButton
        private void pBPlayButton_Click(object sender, EventArgs e)
        {
            //Open next Form
        }

        private void pBPlayButton_MouseDown(object sender, MouseEventArgs e)
        {
            pBPlayButton.BackgroundImage = pressedImage;
        }

        private void pBPlayButton_MouseUp(object sender, MouseEventArgs e)
        {
            pBPlayButton.BackgroundImage = hoverImage;
        }

        private void pBPlayButton_MouseEnter(object sender, EventArgs e)
        {
            pBPlayButton.BackgroundImage = hoverImage;
        }

        private void pBPlayButton_MouseLeave(object sender, EventArgs e)
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

        //
        //RatSecret 1/1
        //
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

        //
        //QuitButton 2/3
        //
        #region QuitButton
        private void pBQuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pBQuitButton_MouseEnter(object sender, EventArgs e)
        {
            shakeTimer.Start();
        }

        private void pBQuitButton_MouseLeave(object sender, EventArgs e)
        {
            shakeTimer.Stop();
            pBQuitButton.Location = originalLocation;
        }

        private void ShakeTimer_Tick(object sender, EventArgs e)
        {
            int xOffset = random.Next(-shakeDistance, shakeDistance + 1);
            int yOffset = random.Next(-shakeDistance, shakeDistance + 1);

            pBQuitButton.Location = new Point(originalLocation.X + xOffset, originalLocation.Y + yOffset);
        }

        private void pBQuitButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pBQuitButton.Image = ConvertToGrayscale(originalImage);
            }
        }
        private void pBQuitButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (originalImage != null)
                {
                    pBQuitButton.Image = originalImage;
                }
            }
        }

        private Image ConvertToGrayscale(Image originalImage)
        {
            if (originalImage == null)
            {
                return null;
            }
            Bitmap grayscaleBitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(grayscaleBitmap))
            {
                ColorMatrix colorMatrix = new ColorMatrix(
                    new float[][]{
                        new float[] {10f, 0, 0, 0, 0},
                        new float[] {0, 1f, 0, 0, 0},
                        new float[] {0, 0, 1f, 0, 0},
                        new float[] {0, 0, 0, 1f, 0},
                        new float[] {0, 0, 0, 0, 1}
                    });

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                        0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            return grayscaleBitmap;
        }
        #endregion
    }
}
#pragma warning restore