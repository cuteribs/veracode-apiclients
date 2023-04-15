// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SummaryReportApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorLinks
    {
        /// <summary>
        /// Initializes a new instance of the ErrorLinks class.
        /// </summary>
        public ErrorLinks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorLinks class.
        /// </summary>
        public ErrorLinks(Link help)
        {
            Help = help;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "help")]
        public Link Help { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Help == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Help");
            }
        }
    }
}
