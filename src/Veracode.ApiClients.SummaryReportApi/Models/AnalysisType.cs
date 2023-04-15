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
    /// For a static analysis, a list of modules with one module node per
    /// module analyzed. For a dynamic analysis, a single module node.
    /// </summary>
    public partial class AnalysisType
    {
        /// <summary>
        /// Initializes a new instance of the AnalysisType class.
        /// </summary>
        public AnalysisType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AnalysisType class.
        /// </summary>
        /// <param name="rating">Letter grade for the security of this
        /// application.</param>
        /// <param name="score">Numeric security score for this
        /// application.</param>
        /// <param name="mitigatedRating">Letter grade for the security of this
        /// application, based on mitigated findings.</param>
        /// <param name="mitigatedScore">Numeric security score for this
        /// application, based on mitigated findings.</param>
        /// <param name="submittedDate">Date when you submitted this
        /// application to Veracode for analysis.</param>
        /// <param name="publishedDate">Date when Veracode published the
        /// analysis for this application.</param>
        /// <param name="nextScanDue">Date when the active security policy for
        /// this application is scheduled to request the next scan.</param>
        /// <param name="analysisSizeBytes">Optional. For a static analysis,
        /// the size, in bytes, of the scanned modules.</param>
        /// <param name="engineVersion">For a static analysis, the version of
        /// the engine that Veracode used for this scan.</param>
        /// <param name="dynamicScanType">Possible values include: 'MP', 'DS',
        /// 'DA'</param>
        /// <param name="scanExitStatusId">Optional. For a dynamic analysis,
        /// the numeric code for scan exit status.</param>
        /// <param name="scanExitStatusDesc">Optional. For a dynamic analysis,
        /// a description for scan_exit_status_id.</param>
        /// <param name="version">Optional. Version of the scan.</param>
        public AnalysisType(Module modules = default(Module), string rating = default(string), long? score = default(long?), string mitigatedRating = default(string), long? mitigatedScore = default(long?), string submittedDate = default(string), string publishedDate = default(string), string nextScanDue = default(string), double? analysisSizeBytes = default(double?), string engineVersion = default(string), string dynamicScanType = default(string), long? scanExitStatusId = default(long?), string scanExitStatusDesc = default(string), string version = default(string))
        {
            Modules = modules;
            Rating = rating;
            Score = score;
            MitigatedRating = mitigatedRating;
            MitigatedScore = mitigatedScore;
            SubmittedDate = submittedDate;
            PublishedDate = publishedDate;
            NextScanDue = nextScanDue;
            AnalysisSizeBytes = analysisSizeBytes;
            EngineVersion = engineVersion;
            DynamicScanType = dynamicScanType;
            ScanExitStatusId = scanExitStatusId;
            ScanExitStatusDesc = scanExitStatusDesc;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modules")]
        public Module Modules { get; set; }

        /// <summary>
        /// Gets or sets letter grade for the security of this application.
        /// </summary>
        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }

        /// <summary>
        /// Gets or sets numeric security score for this application.
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public long? Score { get; set; }

        /// <summary>
        /// Gets or sets letter grade for the security of this application,
        /// based on mitigated findings.
        /// </summary>
        [JsonProperty(PropertyName = "mitigated_rating")]
        public string MitigatedRating { get; set; }

        /// <summary>
        /// Gets or sets numeric security score for this application, based on
        /// mitigated findings.
        /// </summary>
        [JsonProperty(PropertyName = "mitigated_score")]
        public long? MitigatedScore { get; set; }

        /// <summary>
        /// Gets or sets date when you submitted this application to Veracode
        /// for analysis.
        /// </summary>
        [JsonProperty(PropertyName = "submitted_date")]
        public string SubmittedDate { get; set; }

        /// <summary>
        /// Gets or sets date when Veracode published the analysis for this
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "published_date")]
        public string PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets date when the active security policy for this
        /// application is scheduled to request the next scan.
        /// </summary>
        [JsonProperty(PropertyName = "next_scan_due")]
        public string NextScanDue { get; set; }

        /// <summary>
        /// Gets or sets optional. For a static analysis, the size, in bytes,
        /// of the scanned modules.
        /// </summary>
        [JsonProperty(PropertyName = "analysis_size_bytes")]
        public double? AnalysisSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets for a static analysis, the version of the engine that
        /// Veracode used for this scan.
        /// </summary>
        [JsonProperty(PropertyName = "engine_version")]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'MP', 'DS', 'DA'
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_scan_type")]
        public string DynamicScanType { get; set; }

        /// <summary>
        /// Gets or sets optional. For a dynamic analysis, the numeric code for
        /// scan exit status.
        /// </summary>
        [JsonProperty(PropertyName = "scan_exit_status_id")]
        public long? ScanExitStatusId { get; set; }

        /// <summary>
        /// Gets or sets optional. For a dynamic analysis, a description for
        /// scan_exit_status_id.
        /// </summary>
        [JsonProperty(PropertyName = "scan_exit_status_desc")]
        public string ScanExitStatusDesc { get; set; }

        /// <summary>
        /// Gets or sets optional. Version of the scan.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
