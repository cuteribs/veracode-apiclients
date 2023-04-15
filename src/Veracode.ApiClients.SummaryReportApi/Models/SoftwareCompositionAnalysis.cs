// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SummaryReportApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about findings discovered during Software Composition
    /// Analysis (SCA).
    /// </summary>
    public partial class SoftwareCompositionAnalysis
    {
        /// <summary>
        /// Initializes a new instance of the SoftwareCompositionAnalysis
        /// class.
        /// </summary>
        public SoftwareCompositionAnalysis()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SoftwareCompositionAnalysis
        /// class.
        /// </summary>
        /// <param name="thirdPartyComponents">Number of vulnerable third party
        /// components.</param>
        /// <param name="violatePolicy">Whether the component violates the
        /// security policy.</param>
        /// <param name="componentsViolatedPolicy">Number of components that
        /// violate the SCA policy.</param>
        /// <param name="blacklistedComponents">Number of blacklisted
        /// components.</param>
        /// <param name="scaServiceAvailable">True if the SCA service is
        /// available, else set to false.</param>
        public SoftwareCompositionAnalysis(VulnerableComponentList vulnerableComponents = default(VulnerableComponentList), long? thirdPartyComponents = default(long?), bool? violatePolicy = default(bool?), long? componentsViolatedPolicy = default(long?), long? blacklistedComponents = default(long?), bool? scaServiceAvailable = default(bool?))
        {
            VulnerableComponents = vulnerableComponents;
            ThirdPartyComponents = thirdPartyComponents;
            ViolatePolicy = violatePolicy;
            ComponentsViolatedPolicy = componentsViolatedPolicy;
            BlacklistedComponents = blacklistedComponents;
            ScaServiceAvailable = scaServiceAvailable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vulnerable_components")]
        public VulnerableComponentList VulnerableComponents { get; set; }

        /// <summary>
        /// Gets or sets number of vulnerable third party components.
        /// </summary>
        [JsonProperty(PropertyName = "third_party_components")]
        public long? ThirdPartyComponents { get; set; }

        /// <summary>
        /// Gets or sets whether the component violates the security policy.
        /// </summary>
        [JsonProperty(PropertyName = "violate_policy")]
        public bool? ViolatePolicy { get; set; }

        /// <summary>
        /// Gets or sets number of components that violate the SCA policy.
        /// </summary>
        [JsonProperty(PropertyName = "components_violated_policy")]
        public long? ComponentsViolatedPolicy { get; set; }

        /// <summary>
        /// Gets or sets number of blacklisted components.
        /// </summary>
        [JsonProperty(PropertyName = "blacklisted_components")]
        public long? BlacklistedComponents { get; set; }

        /// <summary>
        /// Gets or sets true if the SCA service is available, else set to
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "sca_service_available")]
        public bool? ScaServiceAvailable { get; set; }

    }
}
