// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.Applications.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sandbox
    /// </summary>
    public partial class Sandbox
    {
        /// <summary>
        /// Initializes a new instance of the Sandbox class.
        /// </summary>
        public Sandbox()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sandbox class.
        /// </summary>
        /// <param name="created">The date and time when the sandbox was
        /// created. The date/time format is per RFC3339 and ISO-8601, and the
        /// timezone is UTC. Example: 2019-04-12T23:20:50.52Z.</param>
        /// <param name="guid">Unique identifier (UUID).</param>
        /// <param name="id">Internal ID.</param>
        /// <param name="modified">The date and time when the sandbox was
        /// modified. The date/time format is per RFC3339 and ISO-8601, and the
        /// timezone is UTC. Example: 2019-04-12T23:20:50.52Z.</param>
        /// <param name="name">The sandbox name</param>
        public Sandbox(string applicationGuid = default(string), bool? autoRecreate = default(bool?), System.DateTime? created = default(System.DateTime?), IList<CustomNameValue> customFields = default(IList<CustomNameValue>), string guid = default(string), int? id = default(int?), System.DateTime? modified = default(System.DateTime?), string name = default(string), int? organizationId = default(int?), string ownerUsername = default(string))
        {
            ApplicationGuid = applicationGuid;
            AutoRecreate = autoRecreate;
            Created = created;
            CustomFields = customFields;
            Guid = guid;
            Id = id;
            Modified = modified;
            Name = name;
            OrganizationId = organizationId;
            OwnerUsername = ownerUsername;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "application_guid")]
        public string ApplicationGuid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_recreate")]
        public bool? AutoRecreate { get; set; }

        /// <summary>
        /// Gets the date and time when the sandbox was created. The date/time
        /// format is per RFC3339 and ISO-8601, and the timezone is UTC.
        /// Example: 2019-04-12T23:20:50.52Z.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "custom_fields")]
        public IList<CustomNameValue> CustomFields { get; set; }

        /// <summary>
        /// Gets unique identifier (UUID).
        /// </summary>
        [JsonProperty(PropertyName = "guid")]
        public string Guid { get; private set; }

        /// <summary>
        /// Gets internal ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; private set; }

        /// <summary>
        /// Gets the date and time when the sandbox was modified. The date/time
        /// format is per RFC3339 and ISO-8601, and the timezone is UTC.
        /// Example: 2019-04-12T23:20:50.52Z.
        /// </summary>
        [JsonProperty(PropertyName = "modified")]
        public System.DateTime? Modified { get; private set; }

        /// <summary>
        /// Gets or sets the sandbox name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_username")]
        public string OwnerUsername { get; set; }

    }
}
