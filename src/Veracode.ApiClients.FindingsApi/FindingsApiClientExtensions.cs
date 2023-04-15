// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veracode.ApiClients.FindingsApi
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FindingsApiClient.
    /// </summary>
    public static partial class FindingsApiClientExtensions
    {
            /// <summary>
            /// getCategories
            /// </summary>
            /// <remarks>
            /// Returns a list of CWE categories.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='page'>
            /// Page number. Defaults to 0.
            /// </param>
            /// <param name='size'>
            /// Page size (0-500). The default is 100.
            /// </param>
            public static PagedResourceOfCategory GetCategoriesUsingGET(this IFindingsApiClient operations, int? page = default(int?), int? size = default(int?))
            {
                return operations.GetCategoriesUsingGETAsync(page, size).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getCategories
            /// </summary>
            /// <remarks>
            /// Returns a list of CWE categories.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='page'>
            /// Page number. Defaults to 0.
            /// </param>
            /// <param name='size'>
            /// Page size (0-500). The default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResourceOfCategory> GetCategoriesUsingGETAsync(this IFindingsApiClient operations, int? page = default(int?), int? size = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCategoriesUsingGETWithHttpMessagesAsync(page, size, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getCategory
            /// </summary>
            /// <remarks>
            /// Returns CWE Category information and links to associated resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='category'>
            /// The CWE category identifier.
            /// </param>
            public static Category GetCategoryUsingGET(this IFindingsApiClient operations, int category)
            {
                return operations.GetCategoryUsingGETAsync(category).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getCategory
            /// </summary>
            /// <remarks>
            /// Returns CWE Category information and links to associated resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='category'>
            /// The CWE category identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Category> GetCategoryUsingGETAsync(this IFindingsApiClient operations, int category, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCategoryUsingGETWithHttpMessagesAsync(category, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getCwes
            /// </summary>
            /// <remarks>
            /// Returns a list of CWEs.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='page'>
            /// Page number. Defaults to 0.
            /// </param>
            /// <param name='size'>
            /// Page size (0-500). The default is 100.
            /// </param>
            public static PagedResourceOfCwe GetCwesUsingGET(this IFindingsApiClient operations, int? page = default(int?), int? size = default(int?))
            {
                return operations.GetCwesUsingGETAsync(page, size).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getCwes
            /// </summary>
            /// <remarks>
            /// Returns a list of CWEs.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='page'>
            /// Page number. Defaults to 0.
            /// </param>
            /// <param name='size'>
            /// Page size (0-500). The default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResourceOfCwe> GetCwesUsingGETAsync(this IFindingsApiClient operations, int? page = default(int?), int? size = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCwesUsingGETWithHttpMessagesAsync(page, size, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getCwe
            /// </summary>
            /// <remarks>
            /// Returns CWE information and links to associated resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cwe'>
            /// The CWE ID.
            /// </param>
            public static Cwe GetCweUsingGET(this IFindingsApiClient operations, int cwe)
            {
                return operations.GetCweUsingGETAsync(cwe).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getCwe
            /// </summary>
            /// <remarks>
            /// Returns CWE information and links to associated resources.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cwe'>
            /// The CWE ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cwe> GetCweUsingGETAsync(this IFindingsApiClient operations, int cwe, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCweUsingGETWithHttpMessagesAsync(cwe, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// getFindings
            /// </summary>
            /// <remarks>
            /// Returns findings information from Veracode scans.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationGuid'>
            /// The application identifier.
            /// </param>
            /// <param name='context'>
            /// Context type, which filters results to show only the findings of this
            /// specific context type. The findings status parameter is relative to this
            /// context parameter.
            /// </param>
            /// <param name='cve'>
            /// CVE ID.
            /// </param>
            /// <param name='cvss'>
            /// CVSS ID (0-10), which can be double (decimal) values. This filter returns
            /// all findings with a CVSS value equal to the provided value.
            /// </param>
            /// <param name='cvssGte'>
            /// CVSS ID (0-10), which can be double (decimal) values. This filter returns
            /// all findings with a CVSS value greater than or equal to the provided value.
            /// </param>
            /// <param name='cwe'>
            /// CWE ID (single or comma-delimited).
            /// </param>
            /// <param name='findingCategory'>
            /// Category of finding (single or comma-delimited). Not valid for the SCA scan
            /// type.
            /// </param>
            /// <param name='includeAnnot'>
            /// Use this flag to include the annotations in the response. Not valid for the
            /// SCA scan type.
            /// </param>
            /// <param name='includeExpDate'>
            /// Use this flag to include findings grace period expiry date in the response.
            /// </param>
            /// <param name='mitigatedAfter'>
            /// Return all findings with annotations mitigated after the specified date.
            /// Does not apply to the SCA scan type. Use date format: yyyy-MM-dd
            /// </param>
            /// <param name='newParameter'>
            /// Use this flag to include only new findings in the current context (policy
            /// or sandbox) in the response.
            /// </param>
            /// <param name='scaDepMode'>
            /// Return all findings with the specified SCA dependency mode. Only valid for
            /// the SCA scan type. Possible values include: 'UNKNOWN', 'DIRECT',
            /// 'TRANSITIVE', 'BOTH'
            /// </param>
            /// <param name='scaScanMode'>
            /// Return all findings from SCA scans of the specified scan mode. Only valid
            /// for the SCA scan type. Possible values include: 'UPLOAD', 'AGENT', 'BOTH'
            /// </param>
            /// <param name='scanType'>
            /// Type of scan in which the finding was found (single or comma-delimited).
            /// </param>
            /// <param name='severity'>
            /// This filter returns all findings with this severity value (0-5).
            /// </param>
            /// <param name='severityGte'>
            /// This filter returns all scan findings with a severity value greater or
            /// equal to the value of the filter (0-5).
            /// </param>
            /// <param name='violatesPolicy'>
            /// Use this flag to filter the results based on whether the results violate
            /// the policy associated with the application. True means the results
            /// negatively impact the policy and should be fixed. Not valid for the SCA
            /// scan type.
            /// </param>
            public static PagedResourceOfFinding GetFindingsUsingGET(this IFindingsApiClient operations, string applicationGuid, string context = default(string), string cve = default(string), double? cvss = default(double?), double? cvssGte = default(double?), IList<int?> cwe = default(IList<int?>), IList<int?> findingCategory = default(IList<int?>), bool? includeAnnot = default(bool?), bool? includeExpDate = default(bool?), System.DateTime? mitigatedAfter = default(System.DateTime?), bool? newParameter = default(bool?), string scaDepMode = default(string), string scaScanMode = default(string), IList<string> scanType = default(IList<string>), int? severity = default(int?), int? severityGte = default(int?), bool? violatesPolicy = default(bool?))
            {
                return operations.GetFindingsUsingGETAsync(applicationGuid, context, cve, cvss, cvssGte, cwe, findingCategory, includeAnnot, includeExpDate, mitigatedAfter, newParameter, scaDepMode, scaScanMode, scanType, severity, severityGte, violatesPolicy).GetAwaiter().GetResult();
            }

            /// <summary>
            /// getFindings
            /// </summary>
            /// <remarks>
            /// Returns findings information from Veracode scans.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationGuid'>
            /// The application identifier.
            /// </param>
            /// <param name='context'>
            /// Context type, which filters results to show only the findings of this
            /// specific context type. The findings status parameter is relative to this
            /// context parameter.
            /// </param>
            /// <param name='cve'>
            /// CVE ID.
            /// </param>
            /// <param name='cvss'>
            /// CVSS ID (0-10), which can be double (decimal) values. This filter returns
            /// all findings with a CVSS value equal to the provided value.
            /// </param>
            /// <param name='cvssGte'>
            /// CVSS ID (0-10), which can be double (decimal) values. This filter returns
            /// all findings with a CVSS value greater than or equal to the provided value.
            /// </param>
            /// <param name='cwe'>
            /// CWE ID (single or comma-delimited).
            /// </param>
            /// <param name='findingCategory'>
            /// Category of finding (single or comma-delimited). Not valid for the SCA scan
            /// type.
            /// </param>
            /// <param name='includeAnnot'>
            /// Use this flag to include the annotations in the response. Not valid for the
            /// SCA scan type.
            /// </param>
            /// <param name='includeExpDate'>
            /// Use this flag to include findings grace period expiry date in the response.
            /// </param>
            /// <param name='mitigatedAfter'>
            /// Return all findings with annotations mitigated after the specified date.
            /// Does not apply to the SCA scan type. Use date format: yyyy-MM-dd
            /// </param>
            /// <param name='newParameter'>
            /// Use this flag to include only new findings in the current context (policy
            /// or sandbox) in the response.
            /// </param>
            /// <param name='scaDepMode'>
            /// Return all findings with the specified SCA dependency mode. Only valid for
            /// the SCA scan type. Possible values include: 'UNKNOWN', 'DIRECT',
            /// 'TRANSITIVE', 'BOTH'
            /// </param>
            /// <param name='scaScanMode'>
            /// Return all findings from SCA scans of the specified scan mode. Only valid
            /// for the SCA scan type. Possible values include: 'UPLOAD', 'AGENT', 'BOTH'
            /// </param>
            /// <param name='scanType'>
            /// Type of scan in which the finding was found (single or comma-delimited).
            /// </param>
            /// <param name='severity'>
            /// This filter returns all findings with this severity value (0-5).
            /// </param>
            /// <param name='severityGte'>
            /// This filter returns all scan findings with a severity value greater or
            /// equal to the value of the filter (0-5).
            /// </param>
            /// <param name='violatesPolicy'>
            /// Use this flag to filter the results based on whether the results violate
            /// the policy associated with the application. True means the results
            /// negatively impact the policy and should be fixed. Not valid for the SCA
            /// scan type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResourceOfFinding> GetFindingsUsingGETAsync(this IFindingsApiClient operations, string applicationGuid, string context = default(string), string cve = default(string), double? cvss = default(double?), double? cvssGte = default(double?), IList<int?> cwe = default(IList<int?>), IList<int?> findingCategory = default(IList<int?>), bool? includeAnnot = default(bool?), bool? includeExpDate = default(bool?), System.DateTime? mitigatedAfter = default(System.DateTime?), bool? newParameter = default(bool?), string scaDepMode = default(string), string scaScanMode = default(string), IList<string> scanType = default(IList<string>), int? severity = default(int?), int? severityGte = default(int?), bool? violatesPolicy = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFindingsUsingGETWithHttpMessagesAsync(applicationGuid, context, cve, cvss, cvssGte, cwe, findingCategory, includeAnnot, includeExpDate, mitigatedAfter, newParameter, scaDepMode, scaScanMode, scanType, severity, severityGte, violatesPolicy, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
