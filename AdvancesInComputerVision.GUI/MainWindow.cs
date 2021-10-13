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

        private Point originalClick;

        private readonly Pen cropPen;
        private Point cropStart;
        private Point cropEnd;

        private bool cropSelectionIsEnabled;
        private int cropSelectionX;
        private int cropSelectionY;
        private int cropSelectionSize;

        public MainWindow()
        {
            InitializeComponent();

            originalClick = new Point();

            cropPen = new Pen(Color.Green, 5);
            cropStart = new Point();
            cropEnd = new Point();

            cropSelectionIsEnabled = false;
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

        private void PictureBoxOriginalImageMouseDown(object sender, MouseEventArgs e)
        {
            originalClick.X = e.X;
            originalClick.Y = e.Y;

            if (cropSelectionIsEnabled)
            {
                return;
            }

            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            cropStart.X = e.X;
            cropStart.Y = e.Y;
        }

        private void PictureBoxOriginalImageMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (cropSelectionIsEnabled)
            {
                var widthOffset = originalClick.X - e.X;
                var heightOffset = originalClick.Y - e.Y;

                var xLowerLimit = (int)numericUpDownCropSelectionX.Minimum;
                var yLowerLimit = (int)numericUpDownCropSelectionY.Minimum;
                var xUpperLimit = (int)numericUpDownCropSelectionX.Maximum;
                var yUpperLimit = (int)numericUpDownCropSelectionY.Maximum;

                var newStartX = cropSelectionX + widthOffset;
                newStartX = newStartX < xLowerLimit ? xUpperLimit : newStartX;
                newStartX = newStartX > xUpperLimit ? xUpperLimit : newStartX;

                var newStartY = cropSelectionY + heightOffset;
                newStartY = newStartY < yLowerLimit ? yUpperLimit : newStartY;
                newStartY = newStartY > yUpperLimit ? yUpperLimit : newStartY;

                cropSelectionX = newStartX;
                cropSelectionY = newStartY;
                
            }
            else
            {
                cropEnd.X = e.X;
                cropEnd.Y = e.Y;
            }
        }

        private void PictureBoxOriginalImageMouseUp(object sender, MouseEventArgs e)
        {
            if (cropSelectionIsEnabled)
            {
                numericUpDownCropSelectionX.Value = cropSelectionX;
                numericUpDownCropSelectionY.Value = cropSelectionY;

                DrawCropSelectionRectangle();
                return;
            }

            var cropWidth = cropEnd.X - cropStart.X;
            var cropHeight = cropEnd.Y - cropStart.Y;

            pictureBoxOriginalImage.Refresh();
            pictureBoxOriginalImage.CreateGraphics().DrawRectangle(cropPen, cropStart.X, cropStart.Y, cropWidth, cropHeight);
        }

        private void buttonBeginCropSelection_Click(object sender, EventArgs e)
        {
            cropSelectionIsEnabled = true;

            var imageWidth = pictureBoxOriginalImage.BackgroundImage.Width;
            var imageHeight = pictureBoxOriginalImage.BackgroundImage.Height;

            var initialSize = imageWidth < imageHeight
                ? imageWidth
                : imageHeight;

            var xOffsetMaxValue = imageWidth - initialSize;
            var yOffsetMaxValue = imageHeight - initialSize;
            numericUpDownCropSelectionX.Maximum = xOffsetMaxValue;
            numericUpDownCropSelectionY.Maximum = yOffsetMaxValue;

            numericUpDownCropSelectionSize.Maximum = initialSize;
            numericUpDownCropSelectionSize.Value = initialSize;
            cropSelectionSize = initialSize;

            DrawCropSelectionRectangle();
        }

        private void buttonCropSelection_Click(object sender, EventArgs e)
        {
            var endX = cropSelectionX + cropSelectionSize;
            var endY = cropSelectionY + cropSelectionSize;
            var start = new Point(cropSelectionX, cropSelectionY);
            var end = new Point(endX, endY);

            backupAlteredImage = new Bitmap(pictureBoxAlteredImage.BackgroundImage);

            pictureBoxAlteredImage.BackgroundImage = pictureBoxOriginalImage.BackgroundImage.Crop(start, end);
        }

        

        private void numericUpDownCropSelectionX_ValueChanged(object sender, EventArgs e)
        {
            cropSelectionX = (int)numericUpDownCropSelectionX.Value;

            DrawCropSelectionRectangle();
        }

        private void numericUpDownCropSelectionY_ValueChanged(object sender, EventArgs e)
        {
            cropSelectionY = (int)numericUpDownCropSelectionY.Value;

            DrawCropSelectionRectangle();
        }

        private void numericUpDownCropSelectionSize_ValueChanged(object sender, EventArgs e)
        {
            var newSize = (int)numericUpDownCropSelectionSize.Value;
            var imageWidth = pictureBoxOriginalImage.BackgroundImage.Width;
            var imageHeight = pictureBoxOriginalImage.BackgroundImage.Height;

            var xOffsetMaxValue = imageWidth - newSize;
            var yOffsetMaxValue = imageHeight - newSize;
            numericUpDownCropSelectionX.Maximum = xOffsetMaxValue;
            numericUpDownCropSelectionY.Maximum = yOffsetMaxValue;

            cropSelectionSize = newSize;

            DrawCropSelectionRectangle();
        }

        private void DrawCropSelectionRectangle()
        {
            pictureBoxOriginalImage.Refresh();
            pictureBoxOriginalImage.CreateGraphics().DrawRectangle(cropPen, cropSelectionX, cropSelectionY, cropSelectionSize, cropSelectionSize);
        }
    }
}
