// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.FindingsApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Link
    /// </summary>
    public partial class Link
    {
        /// <summary>
        /// Initializes a new instance of the Link class.
        /// </summary>
        public Link()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Link class.
        /// </summary>
        public Link(string deprecation = default(string), string href = default(string), string hreflang = default(string), string media = default(string), string rel = default(string), bool? templated = default(bool?), string title = default(string), string type = default(string))
        {
            Deprecation = deprecation;
            Href = href;
            Hreflang = hreflang;
            Media = media;
            Rel = rel;
            Templated = templated;
            Title = title;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deprecation")]
        public string Deprecation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hreflang")]
        public string Hreflang { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "media")]
        public string Media { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rel")]
        public string Rel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templated")]
        public bool? Templated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
