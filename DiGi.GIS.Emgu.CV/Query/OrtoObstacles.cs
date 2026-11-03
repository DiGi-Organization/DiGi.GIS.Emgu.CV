using DiGi.GIS.Emgu.CV.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS.Emgu.CV
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the obstacles measured on a probed orthophoto tile: each of <see cref="OrtoObstacle.Shadow"/>, <see cref="OrtoObstacle.Snow"/>, <see cref="OrtoObstacle.Haze"/> and <see cref="OrtoObstacle.Cloud"/> whose fraction reaches its threshold in <see cref="Constants.OrtoObstacleThreshold"/>.
        /// <para>The result is the <c>measuredOrtoObstacle</c> argument of <see cref="GIS.Query.OrtoObstacles"/>; null passes on as "not probed".</para>
        /// </summary>
        /// <param name="ortoObstacleFractions">The fractions measured on the tile.</param>
        /// <returns>The measured obstacles (<see cref="OrtoObstacle.None"/> when no fraction reaches its threshold), or null when <paramref name="ortoObstacleFractions"/> is null.</returns>
        public static OrtoObstacle? OrtoObstacles(this OrtoObstacleFractions? ortoObstacleFractions)
        {
            if (ortoObstacleFractions == null)
            {
                return null;
            }

            OrtoObstacle result = OrtoObstacle.None;

            if (ortoObstacleFractions.Shadow >= Constants.OrtoObstacleThreshold.ShadowFraction)
            {
                result |= OrtoObstacle.Shadow;
            }

            if (ortoObstacleFractions.Snow >= Constants.OrtoObstacleThreshold.SnowFraction)
            {
                result |= OrtoObstacle.Snow;
            }

            if (ortoObstacleFractions.Haze >= Constants.OrtoObstacleThreshold.HazeFraction)
            {
                result |= OrtoObstacle.Haze;
            }

            if (ortoObstacleFractions.Cloud >= Constants.OrtoObstacleThreshold.CloudFraction)
            {
                result |= OrtoObstacle.Cloud;
            }

            return result;
        }
    }
}
