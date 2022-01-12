using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AdvancesInComputerVision.GUI.UserControls
{
    public partial class ImageInPaintingUserControl : UserControl
    {
        private readonly List<Point> clickedPoints;
        private readonly Pen pen;

        private Graphics graphicsImageBefore;

        private Region shapeRegion;

        public ImageInPaintingUserControl()
        {
            InitializeComponent();

            buttonCloseShape.Enabled = false;

            clickedPoints = new List<Point>();
            pen = new Pen(Color.GreenYellow, 2f);
        }

        private void buttonLoadImage_Click(object sender, System.EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var loadedImage = new Bitmap(openFileDialog.FileName);
                pictureBoxImageBefore.BackgroundImage = loadedImage;
                graphicsImageBefore = pictureBoxImageBefore.CreateGraphics();

                var loadedImageCopy = new Bitmap(loadedImage);
                pictureBoxImageAfter.BackgroundImage = loadedImageCopy;
            }
        }

        private void buttonReset_Click(object sender, System.EventArgs e)
        {
            clickedPoints.Clear();
            pictureBoxImageBefore.Refresh();
        }

        private void pictureBoxImageBefore_MouseClick(object sender, MouseEventArgs e)
        {
            clickedPoints.Add(e.Location);

            DrawLastTwoPoints();

            if (clickedPoints.Count > 2)
            {
                buttonCloseShape.Enabled = true;
            }
        }

        private void DrawLastTwoPoints()
        {
            if (clickedPoints.Count < 2)
            {
                return;
            }

            var lastPointIndex = clickedPoints.Count - 1;
            
            graphicsImageBefore.DrawLine(pen, clickedPoints[lastPointIndex], clickedPoints[lastPointIndex - 1]);
        }

        private void buttonCloseShape_Click(object sender, System.EventArgs e)
        {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddLines(clickedPoints.ToArray());
            shapeRegion = new Region(graphicsPath);

            graphicsImageBefore.DrawLine(pen, clickedPoints[^1], clickedPoints[0]);
            buttonCloseShape.Enabled = false;
        }

        private void buttonHighlightSelection_Click(object sender, System.EventArgs e)
        {
            var highlightImage = new Bitmap(pictureBoxImageAfter.BackgroundImage);

            for (var x = 0; x < pictureBoxImageBefore.BackgroundImage.Width; x++)
            {
                for (var y = 0; y < pictureBoxImageBefore.BackgroundImage.Height; y++)
                {
                    if (!shapeRegion.IsVisible(new Point(x, y)))
                    {
                        var pixel = highlightImage.GetPixel(x, y);
                        var grayScaleValue = Clamp((pixel.R + pixel.G + pixel.B) / 3);
                        var grayScale = Color.FromArgb(grayScaleValue, grayScaleValue, grayScaleValue);
                        highlightImage.SetPixel(x, y, grayScale);
                    }
                }
            }

            pictureBoxImageAfter.BackgroundImage = highlightImage;
        }

        private byte Clamp(int value)
        {
            if (value < 0)
            {
                return 0;
            }
            else if (value > 255)
            {
                return 255;
            }
            else
            {
                return (byte)value;
            }
        }
    }
}
