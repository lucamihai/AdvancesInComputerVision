using System;
using System.Drawing;
using System.Windows.Forms;
using AdvancesInComputerVision.GUI.ImageProcessing;

namespace AdvancesInComputerVision.GUI.UserControls
{
    public partial class StereoVisionUserControl : UserControl
    {
        public StereoVisionUserControl()
        {
            InitializeComponent();
        }

        private void LoadImageLeft_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var loadedImage = new Bitmap(openFileDialog.FileName);
                pictureBoxImageLeft.BackgroundImage = loadedImage;
            }
        }

        private void LoadImageRight_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var loadedImage = new Bitmap(openFileDialog.FileName);
                pictureBoxImageRight.BackgroundImage = loadedImage;
            }
        }

        private void buttonStereo_Click(object sender, EventArgs e)
        {
            var blockSize = (int)numericUpDownBlocksize.Value;
            var searchRadius = (int)numericUpDownSearchRadius.Value;
            var imageLeft = pictureBoxImageLeft.BackgroundImage.AsGrayscale();
            var imageRight = pictureBoxImageRight.BackgroundImage.AsGrayscale();

            var stereoImage = StereoImage.GetStereo(imageLeft, imageRight, blockSize, searchRadius);

            pictureBoxStereoImage.BackgroundImage = stereoImage;
        }
    }
}
