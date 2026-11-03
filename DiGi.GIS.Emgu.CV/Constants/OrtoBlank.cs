namespace DiGi.GIS.Emgu.CV.Constants
{
    /// <summary>
    /// Provides the parameters of the uniform-colour (blank) check on orthophoto tiles (<see cref="Query.IsOrtoBlank(byte[])"/>).
    /// </summary>
    public static class OrtoBlank
    {
        /// <summary>
        /// The largest spread (maximum minus minimum, per channel, on 0–255) of the sampled pixels for which a tile still counts as one uniform colour.
        /// <para>The blank tile the GUGiK WMS answers outside its coverage or scale range decodes as exactly uniform white, so the tolerance only has to absorb JPEG ringing; real imagery spreads far wider.</para>
        /// </summary>
        public const int Tolerance = 8;

        /// <summary>
        /// The number of sample positions along each axis of the tile; the sampled grid is at most <see cref="SampleCount"/> × <see cref="SampleCount"/> pixels.
        /// </summary>
        public const int SampleCount = 64;
    }
}
