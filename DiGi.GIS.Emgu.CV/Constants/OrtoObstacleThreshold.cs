namespace DiGi.GIS.Emgu.CV.Constants
{
    /// <summary>
    /// Provides the thresholds of the shadow, snow, haze and cloud heuristics on orthophoto tiles (<see cref="Create.OrtoObstacleFractions(byte[])"/>, <see cref="Query.OrtoObstacles(Classes.OrtoObstacleFractions?)"/>).
    /// <para>Brightness is the mean of the three channels and saturation is (max − min) / max of a pixel, so the rules read an RGB composite and a CIR composite (NIR, red, green) alike: snow and cloud are bright and neutral in every band, deep shadow is dark in every band. The values are heuristics for relative sample selection, not radiometric claims.</para>
    /// </summary>
    public static class OrtoObstacleThreshold
    {
        /// <summary>
        /// The edge, in pixels, of the square blocks on which texture (brightness standard deviation) is measured for the cloud and haze rules.
        /// </summary>
        public const int BlockSize = 16;

        /// <summary>
        /// The smallest block mean brightness (0–255) of a cloud block.
        /// </summary>
        public const double CloudBrightnessMin = 200;

        /// <summary>
        /// The largest block brightness standard deviation (0–255) of a cloud block: cloud is bright and smooth, whereas snow on the ground keeps the texture of what it covers.
        /// </summary>
        public const double CloudTextureMax = 6;

        /// <summary>
        /// The largest block mean saturation (0–1) of a cloud block.
        /// </summary>
        public const double CloudSaturationMax = 0.15;

        /// <summary>
        /// The smallest block mean brightness (0–255) of a haze block; darker smooth blocks are left to the shadow rule.
        /// </summary>
        public const double HazeBrightnessMin = 110;

        /// <summary>
        /// The largest block brightness standard deviation (0–255) of a haze block: haze is a washed-out, low-contrast veil.
        /// </summary>
        public const double HazeTextureMax = 5;

        /// <summary>
        /// The largest block mean saturation (0–1) of a haze block.
        /// </summary>
        public const double HazeSaturationMax = 0.2;

        /// <summary>
        /// The smallest brightness (0–255) of a snow pixel.
        /// </summary>
        public const double SnowBrightnessMin = 210;

        /// <summary>
        /// The largest saturation (0–1) of a snow pixel.
        /// </summary>
        public const double SnowSaturationMax = 0.1;

        /// <summary>
        /// The largest brightness (0–255) of a deep-shadow pixel. Dark water passes this rule too; the heuristic does not tell the two apart.
        /// </summary>
        public const double ShadowBrightnessMax = 40;

        /// <summary>
        /// The shadow fraction from which <see cref="Enums.OrtoObstacle.Shadow"/> is reported. Building shadows are normal on any tile, so the bar is high.
        /// </summary>
        public const double ShadowFraction = 0.25;

        /// <summary>
        /// The snow fraction from which <see cref="Enums.OrtoObstacle.Snow"/> is reported.
        /// </summary>
        public const double SnowFraction = 0.1;

        /// <summary>
        /// The haze fraction from which <see cref="Enums.OrtoObstacle.Haze"/> is reported.
        /// </summary>
        public const double HazeFraction = 0.25;

        /// <summary>
        /// The cloud fraction from which <see cref="Enums.OrtoObstacle.Cloud"/> is reported.
        /// </summary>
        public const double CloudFraction = 0.05;
    }
}
