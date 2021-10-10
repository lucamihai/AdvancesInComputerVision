using System;
using System.Drawing;
using System.Windows.Forms;
using AdvancesInComputerVision.GUI.ImageProcessing;

namespace AdvancesInComputerVision.GUI
{
    public partial class MainWindow : Form
    {
        private Image backupOriginalImage;
        private Image backupAlteredImage;

        private readonly Pen cropPen;
        private Point cropStart;
        private Point cropEnd;

        public MainWindow()
        {
            InitializeComponent();

            cropPen = new Pen(Color.Green, 5);
            cropStart = new Point();
            cropEnd = new Point();
        }

        private void ButtonLoadOriginalImageClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var loadedImage = new Bitmap(openFileDialog.FileName);
                backupOriginalImage = loadedImage;
                backupAlteredImage = new Bitmap(loadedImage);
                pictureBoxOriginalImage.BackgroundImage = new Bitmap(loadedImage);
                pictureBoxAlteredImage.BackgroundImage = new Bitmap(loadedImage);
            }
        }

        private void ButtonResetOriginalImageClick(object sender, EventArgs e)
        {
            pictureBoxOriginalImage.BackgroundImage = new Bitmap(backupOriginalImage);
        }

        private void ButtonSetOriginalImageClick(object sender, EventArgs e)
        {
            backupOriginalImage = new Bitmap(pictureBoxOriginalImage.BackgroundImage);

            pictureBoxOriginalImage.BackgroundImage = new Bitmap(pictureBoxAlteredImage.BackgroundImage);
        }

        private void ButtonResetAlteredImageClick(object sender, EventArgs e)
        {
            pictureBoxAlteredImage.BackgroundImage = new Bitmap(backupAlteredImage);
        }

        private void ButtonCropClick(object sender, EventArgs e)
        {
            backupAlteredImage = new Bitmap(pictureBoxAlteredImage.BackgroundImage);

            pictureBoxAlteredImage.BackgroundImage = pictureBoxOriginalImage.BackgroundImage.Crop(cropStart, cropEnd);
        }

        private void ButtonGrayscaleClick(object sender, EventArgs e)
        {
            backupAlteredImage = new Bitmap(pictureBoxAlteredImage.BackgroundImage);

            pictureBoxAlteredImage.BackgroundImage = pictureBoxOriginalImage.BackgroundImage.AsGrayscale();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            cropStart.X = e.X;
            cropStart.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            cropEnd.X = e.X;
            cropEnd.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var cropWidth = cropEnd.X - cropStart.X;
            var cropHeight = cropEnd.Y - cropStart.Y;

            pictureBoxOriginalImage.Refresh();
            pictureBoxOriginalImage.CreateGraphics().DrawRectangle(cropPen, cropStart.X, cropStart.Y, cropWidth, cropHeight);
        }
    }
}
