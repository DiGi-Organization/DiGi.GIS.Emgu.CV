using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Emgu.CV.Classes
{
    /// <summary>
    /// The shares of an orthophoto tile hidden by shadow, snow, haze and cloud, each on [0, 1].
    /// <para>Every pixel is assigned to at most one obstacle, so the four fractions add up to <see cref="Total"/>, which is the <c>obstacleFraction</c> argument of <see cref="GIS.Query.OrtoSheetUsability"/>. <see cref="Query.OrtoObstacles(OrtoObstacleFractions?)"/> turns the fractions into the measured obstacles of <see cref="GIS.Query.OrtoObstacles"/>.</para>
    /// <para>Build one from an image with <see cref="Create.OrtoObstacleFractions(byte[])"/>.</para>
    /// </summary>
    public class OrtoObstacleFractions : Core.Classes.SerializableObject, GIS.Interfaces.IGISSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Cloud))]
        private readonly double cloud;

        [JsonInclude, JsonPropertyName(nameof(Haze))]
        private readonly double haze;

        [JsonInclude, JsonPropertyName(nameof(Shadow))]
        private readonly double shadow;

        [JsonInclude, JsonPropertyName(nameof(Snow))]
        private readonly double snow;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoObstacleFractions"/> class.
        /// </summary>
        /// <param name="shadow">The share of the tile in deep shadow.</param>
        /// <param name="snow">The share of the tile covered by snow.</param>
        /// <param name="haze">The share of the tile veiled by haze or fog.</param>
        /// <param name="cloud">The share of the tile covered by cloud.</param>
        public OrtoObstacleFractions(double shadow, double snow, double haze, double cloud)
        {
            this.shadow = shadow;
            this.snow = snow;
            this.haze = haze;
            this.cloud = cloud;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoObstacleFractions"/> class as a copy of another instance.
        /// </summary>
        /// <param name="ortoObstacleFractions">The instance to copy.</param>
        public OrtoObstacleFractions(OrtoObstacleFractions? ortoObstacleFractions)
            : base(ortoObstacleFractions)
        {
            if (ortoObstacleFractions != null)
            {
                shadow = ortoObstacleFractions.shadow;
                snow = ortoObstacleFractions.snow;
                haze = ortoObstacleFractions.haze;
                cloud = ortoObstacleFractions.cloud;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoObstacleFractions"/> class from its JSON representation.
        /// </summary>
        /// <param name="jsonObject">The JSON object.</param>
        public OrtoObstacleFractions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the share of the tile covered by cloud.
        /// </summary>
        [JsonIgnore]
        public double Cloud => cloud;

        /// <summary>
        /// Gets the share of the tile veiled by haze or fog.
        /// </summary>
        [JsonIgnore]
        public double Haze => haze;

        /// <summary>
        /// Gets the share of the tile in deep shadow.
        /// </summary>
        [JsonIgnore]
        public double Shadow => shadow;

        /// <summary>
        /// Gets the share of the tile covered by snow.
        /// </summary>
        [JsonIgnore]
        public double Snow => snow;

        /// <summary>
        /// Gets the share of the tile hidden by any obstacle: the sum of the four fractions, which never overlap.
        /// </summary>
        [JsonIgnore]
        public double Total => shadow + snow + haze + cloud;
    }
}
