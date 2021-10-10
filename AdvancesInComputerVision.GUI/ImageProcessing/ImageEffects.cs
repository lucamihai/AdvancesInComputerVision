using System.Drawing;

namespace AdvancesInComputerVision.GUI.ImageProcessing
{
    public static class ImageEffects
    {
        public static Image AsGrayscale(this Image image)
        {
            var newImage = new Bitmap(image);

            for (var i = 0; i < newImage.Width; i++)
            {
                for (var j = 0; j < newImage.Height; j++)
                {
                    var color = newImage.GetPixel(i, j);
                    var average = (byte)((color.R + color.G + color.B) / 3);

                    color = Color.FromArgb(average, average, average);

                    newImage.SetPixel(i, j, color);
                }
            }

            return newImage;
        }
    }
}