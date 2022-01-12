using System;
using System.Drawing;

namespace AdvancesInComputerVision.GUI.ImageProcessing
{
    public static class StereoImage
    {
        public static Image GetStereo(Image imageLeft, Image imageRight, int blockSize, int searchRadius)
        {
            var matrix = new int[imageLeft.Height, imageLeft.Width];

            var imageLeftAsBitmap = new Bitmap(imageLeft);
            var imageRightAsBitmap = new Bitmap(imageRight);

            for (var yLeft = 0; yLeft < imageLeftAsBitmap.Height; yLeft++)
            {
                for (var xLeft = 0; xLeft < imageLeftAsBitmap.Width; xLeft++)
                {
                    var lowestSadValue = int.MaxValue;

                    for (var yRight = yLeft - searchRadius; yRight < yLeft + searchRadius; yRight++)
                    {
                        for (var xRight = xLeft - searchRadius; xRight < xLeft + searchRadius; xRight++)
                        {
                            var currentSadValue = GetBlocksSadValue(imageLeftAsBitmap, imageRightAsBitmap, yLeft, xLeft, yRight, xRight, blockSize);

                            if (currentSadValue < lowestSadValue)
                            {
                                lowestSadValue = currentSadValue;
                            }
                        }
                    }

                    matrix[yLeft, xLeft] = lowestSadValue;
                }
            }

            var stereoImage = ApplyMatrixToImage(matrix, imageLeftAsBitmap);

            return stereoImage;
        }

        private static int GetBlocksSadValue(Bitmap imageLeft, Bitmap imageRight, int yLeft, int xLeft, int yRight, int xRight, int blockSize)
        {
            var sum = 0;

            for (var yOffset = 0; yOffset < blockSize; yOffset++)
            {
                for (var xOffset = 0; xOffset < blockSize; xOffset++)
                {
                    if (IsOutsideOfBounds(imageLeft, yLeft + yOffset, xLeft + xOffset))
                    {
                        continue;
                    }

                    if (IsOutsideOfBounds(imageRight, yRight + yOffset, xRight + xOffset))
                    {
                        continue;
                    }
                    
                    var a = imageLeft.GetPixel(xLeft + xOffset, yLeft + yOffset).R;
                    var b = imageRight.GetPixel(xRight + xOffset, yRight + yOffset).R;

                    var absoluteDifference = Math.Abs(a - b);

                    sum += absoluteDifference;
                }
            }

            return sum;
        }

        private static bool IsOutsideOfBounds(Bitmap image, int y, int x)
        {
            return y >= image.Height || y < 0
                    || x >= image.Width || x < 0;
        }

        private static Bitmap ApplyMatrixToImage(int[,] matrix, Bitmap image)
        {
            var newImage = new Bitmap(image);

            for (var y = 0; y < newImage.Height; y++)
            {
                for (var x = 0; x < newImage.Width; x++)
                {
                    var color = newImage.GetPixel(x, y);
                    var newValue = Clamp(color.R - matrix[y, x]);
                    var newColor = Color.FromArgb(newValue, newValue, newValue);

                    newImage.SetPixel(x, y, newColor);
                }
            }

            return newImage;
        }

        private static byte Clamp(int number)
        {
            if (number < 0)
            {
                return 0;
            }
            else if (number > 255)
            {
                return 255;
            }
            else
            {
                return (byte)number;
            }
        }
    }
}