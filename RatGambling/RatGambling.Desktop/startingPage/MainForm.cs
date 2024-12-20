using RatGambling.Desktop.Properties;
using RatGambling.Desktop.src;
using RatGambling.Desktop.src.classes;
using RatGambling.Desktop.src.customControl;
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
using static System.Windows.Forms.DataFormats;


namespace RatGambling.Desktop.startingPage
{
    public partial class MainForm : StdForm
    {
        //
        //PlayButton 1/3
        //
        #region PlayButton
        private readonly Image unpressedImage;
        private readonly Image hoverImage;
        private readonly Image pressedImage;
        #endregion
        //
        //QuitButton 1/3
        //
        #region QuitButton
        //Hover-Event
        private readonly System.Windows.Forms.Timer shakeTimer;
        private readonly int shakeDistance = 5;
        private readonly int shakeSpeed = 40;
        private readonly Random random = new();
        private Point originalLocation;

        //Down-Event
        private readonly Image originalImage;
        #endregion
        //
        //ProfileMenuButton 1/3
        //
        #region ProfileMenuButton
        public DarkenPanel glassPanel = new();
        private readonly Bitmap buttonImage;
        private readonly Bitmap buttonImageo;

        #endregion
        readonly bool isLoggedin = true; // Logged in auf false stellen standart


        public MainForm()
        {
            InitializeComponent();
            //
            //PlayButton 2/3
            //
            #region PlayButton
            unpressedImage = MainFormResources.play_button_unpressed;
            hoverImage = ApplyHoverEffect(unpressedImage);
            pressedImage = ApplyPressedEffect(MainFormResources.play_button_pressed);
            buttonImage = MainFormResources.play_button_unpressed;
            buttonImageo = MainFormResources.play_button_pressed;
            #endregion
            //
            //QuitButton 2/3
            //
            #region QuitButton
            //Hover-Event
            originalLocation = pBQuitButton.Location;
            shakeTimer = new()
            {
                Interval = shakeSpeed
            };
            shakeTimer.Tick += ShakeTimer_Tick;

            //Down-Event
            originalImage = pBQuitButton.Image;
            #endregion
            //
            //ProfileMenuButton 2/3
            //
            #region ProfileMenuButton



            #endregion
        }

        //
        //PlayButton 3/3
        //
        #region PlayButton
        private void pBPlayButton_Click(object sender, EventArgs e)
        {
            Point mousePosition = pBPlayButton.PointToClient(Cursor.Position);
            if (IsTransparentPixel.Check(buttonImage, mousePosition, pBPlayButton.Width, pBPlayButton.Height))
            {
                return;
            }

        }

        private void pBPlayButton_MouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = pBPlayButton.PointToClient(Cursor.Position);
            if (IsTransparentPixel.Check(buttonImageo, mousePosition, pBPlayButton.Width, pBPlayButton.Height))
            {
                return;
            }
            pBPlayButton.BackgroundImage = pressedImage;
        }

        private void pBPlayButton_MouseUp(object sender, MouseEventArgs e)
        {
            Point mousePosition = pBPlayButton.PointToClient(Cursor.Position);
            if (IsTransparentPixel.Check(buttonImage, mousePosition, pBPlayButton.Width, pBPlayButton.Height))
            {
                return;
            }

            pBPlayButton.BackgroundImage = hoverImage;
        }

        private bool isMouseOverButton = false; // Verfolgt den Status, ob die Maus über dem sichtbaren Bereich ist

        private void pBPlayButton_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = pBPlayButton.PointToClient(Cursor.Position);

            bool isOverVisibleArea = !IsTransparentPixel.Check(buttonImage, mousePosition, pBPlayButton.Width, pBPlayButton.Height);

            if (isOverVisibleArea && !isMouseOverButton)
            {
                isMouseOverButton = true;
                pBPlayButton.BackgroundImage = hoverImage;
            }
            else if (!isOverVisibleArea && isMouseOverButton)
            {
                isMouseOverButton = false;
                pBPlayButton.BackgroundImage = unpressedImage;
            }
        }

        private static Bitmap ApplyHoverEffect(Image original)
        {
            var colorMatrix = new ColorMatrix(
                [
                    [0.5f, 0, 0, 0, 0],
                    [0, 0.5f, 0, 0, 0],
                    [0, 0, 0.5f, 0, 0],
                    [0, 0, 0, 1, 0],
                    [0, 0, 0, 0, 1],
                ]
            );

            var imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            Bitmap grayscaleImage = new(original.Width, original.Height);
            using (Graphics g = Graphics.FromImage(grayscaleImage))
            {
                g.DrawImage(original, new Rectangle(0, 0, grayscaleImage.Width, grayscaleImage.Height),
                    0, 0, original.Width, original.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return grayscaleImage;
        }
        private static Bitmap ApplyPressedEffect(Image original)
        {
            var colorMatrix = new ColorMatrix(
                [
                    [0.4f, 0, 0, 0, 0],
                    [0, 0.4f, 0, 0, 0],
                    [0, 0, 0.4f, 0, 0],
                    [0, 0, 0, 1, 0],
                    [0, 0, 0, 0, 1]
                ]
            );

            var imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            Bitmap pressedImage = new(original.Width, original.Height);
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

        private void ShakeTimer_Tick(object? sender, EventArgs e)
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

        private static Bitmap? ConvertToGrayscale(Image originalImage)
        {
            if (originalImage == null)
            {
                return null;
            }
            Bitmap grayscaleBitmap = new(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(grayscaleBitmap))
            {
                ColorMatrix colorMatrix = new(
                    [
                        [10f, 0, 0, 0, 0],
                        [0, 1f, 0, 0, 0],
                        [0, 0, 1f, 0, 0],
                        [0, 0, 0, 1f, 0],
                        [0, 0, 0, 0, 1]
                    ]);

                using ImageAttributes attributes = new();
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                    0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, attributes);
            }

            return grayscaleBitmap;
        }
        #endregion

        //
        //ProfileMenuButton 3/3
        //
        #region ProfileMenuButton
        private void pBAccount_Click(object sender, EventArgs e)
        {
            glassPanel = new DarkenPanel
            {
                Dock = DockStyle.Fill,
                Opacity = 0.7f,
                BackColor = Color.FromArgb(34, 10, 10)
            };

            Controls.Add(glassPanel);
            glassPanel.BringToFront();

            Invalidate();
            GenerateLoginForm();
        }
        private void GenerateLoginForm()
        {

            if (isLoggedin)
            {
                AccountForm accountForm = new(this);
                accountForm.Show();
            }
            else
            {
                LoginForm loginForm = new(this);
                loginForm.OptionSelected += OptionSelected;
                loginForm.Show();
            }
        }
        private void OptionSelected(object? sender, string returnValue)
        {
            switch (returnValue)
            {
                case "PWReset":
                    ResetPasswordForm resetPasswordForm = new(this);
                    resetPasswordForm.OptionSelected += OptionSelected;
                    resetPasswordForm.Show();
                    resetPasswordForm.BringToFront();
                    resetPasswordForm.Focus();
                    break;
                case "Register":
                    RegisterForm registerForm = new(this);
                    registerForm.OptionSelected += OptionSelected;
                    registerForm.Show();
                    registerForm.BringToFront();
                    registerForm.Focus();
                    break;
                case "ProcessRepeat":
                    GenerateLoginForm();
                    break;
            }
            Invalidate();
        }







        #endregion


    }
}