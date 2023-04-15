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
    /// EmbeddedSandbox
    /// </summary>
    public partial class EmbeddedSandbox
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedSandbox class.
        /// </summary>
        public EmbeddedSandbox()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedSandbox class.
        /// </summary>
        public EmbeddedSandbox(IList<Sandbox> sandboxes = default(IList<Sandbox>))
        {
            Sandboxes = sandboxes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sandboxes")]
        public IList<Sandbox> Sandboxes { get; set; }

    }
}
