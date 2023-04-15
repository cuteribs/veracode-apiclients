// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.SCAAgent.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SBOM SPDX Document
    /// </summary>
    public partial class SbomSpdx
    {
        /// <summary>
        /// Initializes a new instance of the SbomSpdx class.
        /// </summary>
        public SbomSpdx()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SbomSpdx class.
        /// </summary>
        /// <param name="sPDXID">Identify the current SPDX document which may
        /// be referenced in relationships by other files, packages internally
        /// and documents externally.</param>
        /// <param name="spdxVersion">SPDX specification version. Current
        /// version is SPDX-2.3</param>
        /// <param name="name">Project name for upload scan or workspace name
        /// for agent scan</param>
        /// <param name="dataLicense">License with data in the document. Use
        /// the Creative Commons CC0 1.0 Universal license is ussed.</param>
        /// <param name="documentDescribes">List of package identifiers</param>
        /// <param name="documentNamespace">Provide an SPDX document-specific
        /// namespace as a unique absolute Uniform Resource Identifier (URI) as
        /// specified in RFC-3986</param>
        /// <param name="relationships">Dependencies between
        /// packages(libraries)</param>
        public SbomSpdx(string sPDXID = default(string), string spdxVersion = default(string), SbomspdxCreationInfo creationInfo = default(SbomspdxCreationInfo), string name = default(string), string dataLicense = default(string), IList<string> documentDescribes = default(IList<string>), string documentNamespace = default(string), IList<SbomspdxPackages> packages = default(IList<SbomspdxPackages>), IList<SbomspdxRelationships> relationships = default(IList<SbomspdxRelationships>))
        {
            SPDXID = sPDXID;
            SpdxVersion = spdxVersion;
            CreationInfo = creationInfo;
            Name = name;
            DataLicense = dataLicense;
            DocumentDescribes = documentDescribes;
            DocumentNamespace = documentNamespace;
            Packages = packages;
            Relationships = relationships;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identify the current SPDX document which may be
        /// referenced in relationships by other files, packages internally and
        /// documents externally.
        /// </summary>
        [JsonProperty(PropertyName = "SPDXID")]
        public string SPDXID { get; set; }

        /// <summary>
        /// Gets or sets SPDX specification version. Current version is
        /// SPDX-2.3
        /// </summary>
        [JsonProperty(PropertyName = "spdxVersion")]
        public string SpdxVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creationInfo")]
        public SbomspdxCreationInfo CreationInfo { get; set; }

        /// <summary>
        /// Gets or sets project name for upload scan or workspace name for
        /// agent scan
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets license with data in the document. Use the Creative
        /// Commons CC0 1.0 Universal license is ussed.
        /// </summary>
        [JsonProperty(PropertyName = "dataLicense")]
        public string DataLicense { get; set; }

        /// <summary>
        /// Gets or sets list of package identifiers
        /// </summary>
        [JsonProperty(PropertyName = "documentDescribes")]
        public IList<string> DocumentDescribes { get; set; }

        /// <summary>
        /// Gets or sets provide an SPDX document-specific namespace as a
        /// unique absolute Uniform Resource Identifier (URI) as specified in
        /// RFC-3986
        /// </summary>
        [JsonProperty(PropertyName = "documentNamespace")]
        public string DocumentNamespace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packages")]
        public IList<SbomspdxPackages> Packages { get; set; }

        /// <summary>
        /// Gets or sets dependencies between packages(libraries)
        /// </summary>
        [JsonProperty(PropertyName = "relationships")]
        public IList<SbomspdxRelationships> Relationships { get; set; }

    }
}
