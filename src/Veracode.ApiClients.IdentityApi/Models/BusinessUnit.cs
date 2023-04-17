// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.IdentityApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A single business unit.
    /// </summary>
    public partial class BusinessUnit
    {
        /// <summary>
        /// Initializes a new instance of the BusinessUnit class.
        /// </summary>
        public BusinessUnit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BusinessUnit class.
        /// </summary>
        /// <param name="buId">The business unit ID in the Veracode Identity
        /// API.</param>
        /// <param name="buLegacyId">The business unit ID in the Veracode
        /// database.</param>
        /// <param name="buName">The business unit name.</param>
        /// <param name="isDefault">Flag indicating if this is the default
        /// business unit for the organization.</param>
        public BusinessUnit(string buId = default(string), int? buLegacyId = default(int?), string buName = default(string), bool? isDefault = default(bool?), Organization organization = default(Organization), IList<Team> teams = default(IList<Team>))
        {
            BuId = buId;
            BuLegacyId = buLegacyId;
            BuName = buName;
            IsDefault = isDefault;
            Organization = organization;
            Teams = teams;
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
        /// Gets or sets the business unit ID in the Veracode database.
        /// </summary>
        [JsonProperty(PropertyName = "bu_legacy_id")]
        public int? BuLegacyId { get; set; }

        /// <summary>
        /// Gets or sets the business unit name.
        /// </summary>
        [JsonProperty(PropertyName = "bu_name")]
        public string BuName { get; set; }

        /// <summary>
        /// Gets or sets flag indicating if this is the default business unit
        /// for the organization.
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public Organization Organization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teams")]
        public IList<Team> Teams { get; set; }

    }
}
