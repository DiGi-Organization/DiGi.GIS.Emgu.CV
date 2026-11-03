using Emgu.CV;
using Emgu.CV.Structure;
using System;

namespace DiGi.GIS.Emgu.CV
{
    public static partial class Query
    {
        /// <summary>
        /// Checks whether an encoded orthophoto tile (JPEG or PNG) is of one uniform colour, within <see cref="Constants.OrtoBlank.Tolerance"/>.
        /// <para>This overload fits <c>Func&lt;byte[], bool&gt;</c>, so it can be passed as the <c>isBlank</c> argument of <see cref="GIS.Query.OrtoImageProbesAsync"/>.</para>
        /// </summary>
        /// <param name="bytes">The encoded image.</param>
        /// <returns>True when the tile is uniform; false when it has content, or when the bytes are missing or cannot be decoded.</returns>
        public static bool IsOrtoBlank(this byte[]? bytes)
        {
            return IsOrtoBlank(bytes, Constants.OrtoBlank.Tolerance);
        }

        /// <summary>
        /// Checks whether an encoded orthophoto tile (JPEG or PNG) is of one uniform colour.
        /// <para>The image is decoded to three channels and sampled on a grid of at most <see cref="Constants.OrtoBlank.SampleCount"/> positions per axis, always including the last row and column. The tile is uniform when, for every channel, the largest sampled value exceeds the smallest by no more than <paramref name="tolerance"/>.</para>
        /// <para>An undecodable payload is not blank: <see cref="GIS.Query.OrtoImageProbesAsync"/> tells exceptions apart before it asks this question.</para>
        /// </summary>
        /// <param name="bytes">The encoded image.</param>
        /// <param name="tolerance">The largest per-channel spread, on 0–255, that still counts as uniform.</param>
        /// <returns>True when the tile is uniform; false when it has content, or when the bytes are missing or cannot be decoded.</returns>
        public static bool IsOrtoBlank(this byte[]? bytes, int tolerance)
        {
            if (bytes == null || bytes.Length == 0 || tolerance < 0)
            {
                return false;
            }

            using Image<Bgr, byte>? image = Create.Image(bytes);
            if (image == null)
            {
                return false;
            }

            byte[,,] data = image.Data;

            int height = data.GetLength(0);
            int width = data.GetLength(1);

            int sampleCount = Math.Max(2, Constants.OrtoBlank.SampleCount);
            int stepY = Math.Max(1, (height - 1) / (sampleCount - 1));
            int stepX = Math.Max(1, (width - 1) / (sampleCount - 1));

            int[] minimums = [255, 255, 255];
            int[] maximums = [0, 0, 0];

            for (int y = 0; y < height; y = NextSample(y, stepY, height))
            {
                for (int x = 0; x < width; x = NextSample(x, stepX, width))
                {
                    for (int c = 0; c < 3; c++)
                    {
                        int value = data[y, x, c];
                        if (value < minimums[c])
                        {
                            minimums[c] = value;
                        }

                        if (value > maximums[c])
                        {
                            maximums[c] = value;
                        }

                        if (maximums[c] - minimums[c] > tolerance)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;

            static int NextSample(int index, int step, int count)
            {
                if (index == count - 1)
                {
                    return count;
                }

                return Math.Min(index + step, count - 1);
            }
        }
    }
}
