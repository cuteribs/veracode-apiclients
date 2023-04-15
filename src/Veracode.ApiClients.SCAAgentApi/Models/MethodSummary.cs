// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgent.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// MethodSummary
    /// </summary>
    public partial class MethodSummary
    {
        /// <summary>
        /// Initializes a new instance of the MethodSummary class.
        /// </summary>
        public MethodSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MethodSummary class.
        /// </summary>
        public MethodSummary(string moduleName = default(string), string className = default(string), string methodName = default(string))
        {
            ModuleName = moduleName;
            ClassName = className;
            MethodName = methodName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "module_name")]
        public string ModuleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "method_name")]
        public string MethodName { get; set; }

    }
}
