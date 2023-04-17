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

    public partial class TeamResource
    {
        /// <summary>
        /// Initializes a new instance of the TeamResource class.
        /// </summary>
        public TeamResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeamResource class.
        /// </summary>
        public TeamResource(ResourceOfBusinessUnit businessUnit = default(ResourceOfBusinessUnit), bool? deleted = default(bool?), IList<ResourceOfFeature> features = default(IList<ResourceOfFeature>), ResourceOfOrganization organization = default(ResourceOfOrganization), string teamId = default(string), int? teamLegacyId = default(int?), string teamName = default(string), IList<ResourceOfUserTeam> users = default(IList<ResourceOfUserTeam>))
        {
            BusinessUnit = businessUnit;
            Deleted = deleted;
            Features = features;
            Organization = organization;
            TeamId = teamId;
            TeamLegacyId = teamLegacyId;
            TeamName = teamName;
            Users = users;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "business_unit")]
        public ResourceOfBusinessUnit BusinessUnit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<ResourceOfFeature> Features { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public ResourceOfOrganization Organization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "team_id")]
        public string TeamId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "team_legacy_id")]
        public int? TeamLegacyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "team_name")]
        public string TeamName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<ResourceOfUserTeam> Users { get; set; }

    }
}
