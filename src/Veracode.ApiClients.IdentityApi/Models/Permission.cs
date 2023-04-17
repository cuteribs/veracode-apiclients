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
    /// A single permission.
    /// </summary>
    public partial class Permission
    {
        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        public Permission()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        /// <param name="permissionDescription">The short description for this
        /// permission.</param>
        /// <param name="permissionId">The permission ID in the Veracode
        /// Identity API.</param>
        /// <param name="permissionLegacyId">The permission ID in the Veracode
        /// database.</param>
        /// <param name="permissionName">The permission name.</param>
        /// <param name="permissionTypes">The permission-types that apply to
        /// this permission. This parameter is specific to the Veracode
        /// Identity API</param>
        public Permission(string permissionDescription = default(string), string permissionId = default(string), int? permissionLegacyId = default(int?), string permissionName = default(string), IList<string> permissionTypes = default(IList<string>))
        {
            PermissionDescription = permissionDescription;
            PermissionId = permissionId;
            PermissionLegacyId = permissionLegacyId;
            PermissionName = permissionName;
            PermissionTypes = permissionTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the short description for this permission.
        /// </summary>
        [JsonProperty(PropertyName = "permission_description")]
        public string PermissionDescription { get; set; }

        /// <summary>
        /// Gets or sets the permission ID in the Veracode Identity API.
        /// </summary>
        [JsonProperty(PropertyName = "permission_id")]
        public string PermissionId { get; set; }

        /// <summary>
        /// Gets or sets the permission ID in the Veracode database.
        /// </summary>
        [JsonProperty(PropertyName = "permission_legacy_id")]
        public int? PermissionLegacyId { get; set; }

        /// <summary>
        /// Gets or sets the permission name.
        /// </summary>
        [JsonProperty(PropertyName = "permission_name")]
        public string PermissionName { get; set; }

        /// <summary>
        /// Gets or sets the permission-types that apply to this permission.
        /// This parameter is specific to the Veracode Identity API
        /// </summary>
        [JsonProperty(PropertyName = "permission_types")]
        public IList<string> PermissionTypes { get; set; }

    }
}
