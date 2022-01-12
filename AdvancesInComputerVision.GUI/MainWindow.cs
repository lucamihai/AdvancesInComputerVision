using System.Windows.Forms;
using AdvancesInComputerVision.GUI.UserControls;

namespace AdvancesInComputerVision.GUI
{
    public partial class MainWindow : Form
    {
        private readonly ImageCroppingUserControl imageCroppingUserControl;
        private readonly StereoVisionUserControl stereoVisionUserControl;
        private readonly ImageInPaintingUserControl imageInPaintingUserControl;

        public MainWindow()
        {
            InitializeComponent();

            imageCroppingUserControl = new ImageCroppingUserControl();
            stereoVisionUserControl = new StereoVisionUserControl();
            imageInPaintingUserControl = new ImageInPaintingUserControl();

            panelActiveUserControl.Controls.Add(imageCroppingUserControl);
        }

        private void imageCroppingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            panelActiveUserControl.Controls.Clear();
            panelActiveUserControl.Controls.Add(imageCroppingUserControl);
        }

        private void stereoVisionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            panelActiveUserControl.Controls.Clear();
            panelActiveUserControl.Controls.Add(stereoVisionUserControl);
        }

        private void inPaintingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            panelActiveUserControl.Controls.Clear();
            panelActiveUserControl.Controls.Add(imageInPaintingUserControl);
        }
    }
}
