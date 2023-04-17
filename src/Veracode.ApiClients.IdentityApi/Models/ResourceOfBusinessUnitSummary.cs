// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.IdentityApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResourceOfBusinessUnitSummary
    {
        /// <summary>
        /// Initializes a new instance of the ResourceOfBusinessUnitSummary
        /// class.
        /// </summary>
        public ResourceOfBusinessUnitSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceOfBusinessUnitSummary
        /// class.
        /// </summary>
        /// <param name="buId">The business unit ID in the Veracode Identity
        /// API.</param>
        /// <param name="buName">The business unit name.</param>
        public ResourceOfBusinessUnitSummary(string buId = default(string), string buName = default(string))
        {
            BuId = buId;
            BuName = buName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the business unit ID in the Veracode Identity API.
        /// </summary>
        [JsonProperty(PropertyName = "bu_id")]
        public string BuId { get; set; }

        /// <summary>
        /// Gets or sets the business unit name.
        /// </summary>
        [JsonProperty(PropertyName = "bu_name")]
        public string BuName { get; set; }

    }
}
