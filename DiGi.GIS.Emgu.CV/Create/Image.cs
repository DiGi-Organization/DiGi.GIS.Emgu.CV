using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace DiGi.GIS.Emgu.CV
{
    public static partial class Create
    {
        /// <summary>
        /// Decodes an encoded image (JPEG, PNG or any format OpenCV reads) into a three-channel 8-bit BGR image; greyscale sources are expanded to three equal channels.
        /// </summary>
        /// <param name="bytes">The encoded image.</param>
        /// <returns>The decoded image, or null when the bytes are missing or cannot be decoded.</returns>
        public static Image<Bgr, byte>? Image(this byte[]? bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }

            try
            {
                using Mat mat = new();
                CvInvoke.Imdecode(bytes, ImreadModes.ColorBgr, mat);
                if (mat.IsEmpty)
                {
                    return null;
                }

                return mat.ToImage<Bgr, byte>();
            }
            catch (CvException)
            {
                return null;
            }
        }
    }
}
