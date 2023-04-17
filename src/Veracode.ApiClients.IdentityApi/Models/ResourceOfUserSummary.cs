// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.IdentityApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResourceOfUserSummary
    {
        /// <summary>
        /// Initializes a new instance of the ResourceOfUserSummary class.
        /// </summary>
        public ResourceOfUserSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceOfUserSummary class.
        /// </summary>
        /// <param name="deleted">Flag indicating if this user was soft
        /// deleted.</param>
        /// <param name="userId">The user ID in the Veracode Identity
        /// API.</param>
        /// <param name="userName">The username for this user.</param>
        public ResourceOfUserSummary(bool? deleted = default(bool?), string userId = default(string), string userName = default(string))
        {
            Deleted = deleted;
            UserId = userId;
            UserName = userName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets flag indicating if this user was soft deleted.
        /// </summary>
        [JsonProperty(PropertyName = "deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Gets or sets the user ID in the Veracode Identity API.
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the username for this user.
        /// </summary>
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

    }
}
