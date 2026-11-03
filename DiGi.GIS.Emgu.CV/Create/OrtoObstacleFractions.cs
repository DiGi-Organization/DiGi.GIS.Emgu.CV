using DiGi.GIS.Emgu.CV.Classes;
using Emgu.CV;
using Emgu.CV.Structure;
using System;

namespace DiGi.GIS.Emgu.CV
{
    public static partial class Create
    {
        /// <summary>
        /// Measures the shares of an encoded orthophoto tile (JPEG or PNG, RGB or CIR) hidden by cloud, haze, snow and deep shadow.
        /// </summary>
        /// <param name="bytes">The encoded image.</param>
        /// <returns>The fractions, or null when the bytes are missing or cannot be decoded.</returns>
        public static OrtoObstacleFractions? OrtoObstacleFractions(this byte[]? bytes)
        {
            using Image<Bgr, byte>? image = Image(bytes);
            return OrtoObstacleFractions(image);
        }

        /// <summary>
        /// Measures the shares of an orthophoto tile (RGB or CIR composite) hidden by cloud, haze, snow and deep shadow, with the thresholds of <see cref="Constants.OrtoObstacleThreshold"/>.
        /// <para>The tile is cut into blocks of <see cref="Constants.OrtoObstacleThreshold.BlockSize"/> pixels (partial blocks at the edges included). A block that is bright, neutral and smooth is cloud; one that is neutral, smooth and of middle brightness is haze. In every other block each pixel is tested on its own: bright and neutral is snow, dark is shadow. A pixel therefore counts towards at most one obstacle.</para>
        /// <para>Smooth neutral surfaces (a large flat roof, a car park) can pass the haze rule and open water passes the shadow rule; the fractions are for relative ranking of samples.</para>
        /// </summary>
        /// <param name="image">The decoded image.</param>
        /// <returns>The fractions, or null when the image is null or empty.</returns>
        public static OrtoObstacleFractions? OrtoObstacleFractions(this Image<Bgr, byte>? image)
        {
            if (image == null)
            {
                return null;
            }

            byte[,,] data = image.Data;
            int height = data.GetLength(0);
            int width = data.GetLength(1);
            if (height == 0 || width == 0)
            {
                return null;
            }

            int blockSize = Math.Max(1, Constants.OrtoObstacleThreshold.BlockSize);

            long shadowCount = 0;
            long snowCount = 0;
            long hazeCount = 0;
            long cloudCount = 0;

            for (int y_Block = 0; y_Block < height; y_Block += blockSize)
            {
                int y_End = Math.Min(height, y_Block + blockSize);
                for (int x_Block = 0; x_Block < width; x_Block += blockSize)
                {
                    int x_End = Math.Min(width, x_Block + blockSize);
                    int count = (y_End - y_Block) * (x_End - x_Block);

                    double brightnessSum = 0;
                    double brightnessSquareSum = 0;
                    double saturationSum = 0;
                    for (int y = y_Block; y < y_End; y++)
                    {
                        for (int x = x_Block; x < x_End; x++)
                        {
                            double brightness = Brightness(data, y, x);
                            brightnessSum += brightness;
                            brightnessSquareSum += brightness * brightness;
                            saturationSum += Saturation(data, y, x);
                        }
                    }

                    double brightnessMean = brightnessSum / count;
                    double texture = Math.Sqrt(Math.Max(0, (brightnessSquareSum / count) - (brightnessMean * brightnessMean)));
                    double saturationMean = saturationSum / count;

                    if (brightnessMean >= Constants.OrtoObstacleThreshold.CloudBrightnessMin && texture <= Constants.OrtoObstacleThreshold.CloudTextureMax && saturationMean <= Constants.OrtoObstacleThreshold.CloudSaturationMax)
                    {
                        cloudCount += count;
                        continue;
                    }

                    if (brightnessMean >= Constants.OrtoObstacleThreshold.HazeBrightnessMin && texture <= Constants.OrtoObstacleThreshold.HazeTextureMax && saturationMean <= Constants.OrtoObstacleThreshold.HazeSaturationMax)
                    {
                        hazeCount += count;
                        continue;
                    }

                    for (int y = y_Block; y < y_End; y++)
                    {
                        for (int x = x_Block; x < x_End; x++)
                        {
                            double brightness = Brightness(data, y, x);
                            if (brightness >= Constants.OrtoObstacleThreshold.SnowBrightnessMin && Saturation(data, y, x) <= Constants.OrtoObstacleThreshold.SnowSaturationMax)
                            {
                                snowCount++;
                            }
                            else if (brightness <= Constants.OrtoObstacleThreshold.ShadowBrightnessMax)
                            {
                                shadowCount++;
                            }
                        }
                    }
                }
            }

            double total = (double)height * width;

            return new Classes.OrtoObstacleFractions(shadowCount / total, snowCount / total, hazeCount / total, cloudCount / total);

            static double Brightness(byte[,,] data, int y, int x)
            {
                return (data[y, x, 0] + data[y, x, 1] + data[y, x, 2]) / 3.0;
            }

            static double Saturation(byte[,,] data, int y, int x)
            {
                int max = Math.Max(data[y, x, 0], Math.Max(data[y, x, 1], data[y, x, 2]));
                if (max == 0)
                {
                    return 0;
                }

                int min = Math.Min(data[y, x, 0], Math.Min(data[y, x, 1], data[y, x, 2]));
                return (max - min) / (double)max;
            }
        }
    }
}
