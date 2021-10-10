using System.Drawing;

namespace AdvancesInComputerVision.GUI.ImageProcessing
{
    public static class ImageCropper
    {
        public static Image Crop(this Image image, Point start, Point end)
        {
            var cropWidth = end.X - start.X;
            var cropHeight = end.Y - start.Y;

            if (cropWidth < 1 || cropHeight < 1)
            {
                return image;
            }

            var cropRectangle = new Rectangle(start.X, start.Y, cropWidth, cropHeight);
            var originalImage = new Bitmap(image, image.Width, image.Height);

            var imageToBeCropped = new Bitmap(cropWidth, cropHeight);
            var graphics = Graphics.FromImage(imageToBeCropped);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            graphics.DrawImage(originalImage, 0, 0, cropRectangle, GraphicsUnit.Pixel);

            return imageToBeCropped;
        }
    }
}
