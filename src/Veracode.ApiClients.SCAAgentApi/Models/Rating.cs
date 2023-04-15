// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgent.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Rating
    /// </summary>
    /// <remarks>
    /// Defines the severity or risk ratings of a vulnerability.
    /// </remarks>
    public partial class Rating
    {
        /// <summary>
        /// Initializes a new instance of the Rating class.
        /// </summary>
        public Rating()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Rating class.
        /// </summary>
        /// <param name="score">Score</param>
        /// <param name="severity">Textual representation of the severity that
        /// corresponds to the numerical score of the rating. Possible values
        /// include: 'critical', 'high', 'medium', 'low', 'none'</param>
        /// <param name="method">Possible values include: 'CVSSv2',
        /// 'CVSSv3'</param>
        /// <param name="vector">Vector</param>
        public Rating(double? score = default(double?), string severity = default(string), string method = default(string), string vector = default(string))
        {
            Score = score;
            Severity = severity;
            Method = method;
            Vector = vector;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets score
        /// </summary>
        /// <remarks>
        /// The numerical score of the rating.
        /// </remarks>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or sets textual representation of the severity that
        /// corresponds to the numerical score of the rating. Possible values
        /// include: 'critical', 'high', 'medium', 'low', 'none'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'CVSSv2', 'CVSSv3'
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets vector
        /// </summary>
        /// <remarks>
        /// Textual representation of the metric values used to score the
        /// vulnerability.
        /// </remarks>
        [JsonProperty(PropertyName = "vector")]
        public string Vector { get; set; }

    }
}
