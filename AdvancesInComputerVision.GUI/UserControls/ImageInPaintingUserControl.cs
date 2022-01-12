using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancesInComputerVision.GUI.UserControls
{
    public partial class ImageInPaintingUserControl : UserControl
    {
        private readonly List<Point> clickedPoints;
        private readonly Pen pen;

        private Graphics graphicsImageBefore;

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
            graphicsImageBefore.DrawLine(pen, clickedPoints[^1], clickedPoints[0]);
            buttonCloseShape.Enabled = false;
        }
    }
}
