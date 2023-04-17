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
    /// A single team.
    /// </summary>
    public partial class Team
    {
        /// <summary>
        /// Initializes a new instance of the Team class.
        /// </summary>
        public Team()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Team class.
        /// </summary>
        /// <param name="relationship">Enum to indicate the relationship this
        /// user has with this team. Possible values include: 'ADMIN',
        /// 'MEMBER'</param>
        /// <param name="teamId">The team ID in the Veracode Identity
        /// API.</param>
        /// <param name="teamLegacyId">The ID in the Veracode database.</param>
        /// <param name="teamName">The team name.</param>
        public Team(BusinessUnit businessUnit = default(BusinessUnit), IList<Feature> features = default(IList<Feature>), Organization organization = default(Organization), string relationship = default(string), string teamId = default(string), int? teamLegacyId = default(int?), string teamName = default(string), IList<UserTeam> users = default(IList<UserTeam>))
        {
            BusinessUnit = businessUnit;
            Features = features;
            Organization = organization;
            Relationship = relationship;
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
        public BusinessUnit BusinessUnit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<Feature> Features { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public Organization Organization { get; set; }

        /// <summary>
        /// Gets or sets enum to indicate the relationship this user has with
        /// this team. Possible values include: 'ADMIN', 'MEMBER'
        /// </summary>
        [JsonProperty(PropertyName = "relationship")]
        public string Relationship { get; set; }

        /// <summary>
        /// Gets or sets the team ID in the Veracode Identity API.
        /// </summary>
        [JsonProperty(PropertyName = "team_id")]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or sets the ID in the Veracode database.
        /// </summary>
        [JsonProperty(PropertyName = "team_legacy_id")]
        public int? TeamLegacyId { get; set; }

        /// <summary>
        /// Gets or sets the team name.
        /// </summary>
        [JsonProperty(PropertyName = "team_name")]
        public string TeamName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<UserTeam> Users { get; set; }

    }
}
