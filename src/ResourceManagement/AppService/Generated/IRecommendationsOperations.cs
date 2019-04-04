// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RecommendationsOperations operations.
    /// </summary>
    public partial interface IRecommendationsOperations
    {
        /// <summary>
        /// List all recommendations for a subscription.
        /// </summary>
        /// <remarks>
        /// List all recommendations for a subscription.
        /// </remarks>
        /// <param name='featured'>
        /// Specify &lt;code&gt;true&lt;/code&gt; to return only the most
        /// critical recommendations. The default is
        /// &lt;code&gt;false&lt;/code&gt;, which returns all recommendations.
        /// </param>
        /// <param name='filter'>
        /// Filter is specified by using OData syntax. Example: $filter=channel
        /// eq 'Api' or channel eq 'Notification' and startTime eq
        /// 2014-01-01T00:00:00Z and endTime eq 2014-12-31T23:59:59Z and
        /// timeGrain eq duration'[PT1H|PT1M|P1D]
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListWithHttpMessagesAsync(bool? featured = default(bool?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reset all recommendation opt-out settings for a subscription.
        /// </summary>
        /// <remarks>
        /// Reset all recommendation opt-out settings for a subscription.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResetAllFiltersWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disables the specified rule so it will not apply to a subscription
        /// in the future.
        /// </summary>
        /// <remarks>
        /// Disables the specified rule so it will not apply to a subscription
        /// in the future.
        /// </remarks>
        /// <param name='name'>
        /// Rule name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DisableRecommendationForSubscriptionWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get past recommendations for an app, optionally specified by the
        /// time range.
        /// </summary>
        /// <remarks>
        /// Get past recommendations for an app, optionally specified by the
        /// time range.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='hostingEnvironmentName'>
        /// Name of the hosting environment.
        /// </param>
        /// <param name='expiredOnly'>
        /// Specify &lt;code&gt;false&lt;/code&gt; to return all
        /// recommendations. The default is &lt;code&gt;true&lt;/code&gt;,
        /// which returns only expired recommendations.
        /// </param>
        /// <param name='filter'>
        /// Filter is specified by using OData syntax. Example: $filter=channel
        /// eq 'Api' or channel eq 'Notification' and startTime eq
        /// 2014-01-01T00:00:00Z and endTime eq 2014-12-31T23:59:59Z and
        /// timeGrain eq duration'[PT1H|PT1M|P1D]
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListHistoryForHostingEnvironmentWithHttpMessagesAsync(string resourceGroupName, string hostingEnvironmentName, bool? expiredOnly = default(bool?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all recommendations for an app.
        /// </summary>
        /// <remarks>
        /// Get all recommendations for an app.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='hostingEnvironmentName'>
        /// Name of the app.
        /// </param>
        /// <param name='featured'>
        /// Specify &lt;code&gt;true&lt;/code&gt; to return only the most
        /// critical recommendations. The default is
        /// &lt;code&gt;false&lt;/code&gt;, which returns all recommendations.
        /// </param>
        /// <param name='filter'>
        /// Return only channels specified in the filter. Filter is specified
        /// by using OData syntax. Example: $filter=channel eq 'Api' or channel
        /// eq 'Notification'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListRecommendedRulesForHostingEnvironmentWithHttpMessagesAsync(string resourceGroupName, string hostingEnvironmentName, bool? featured = default(bool?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disable all recommendations for an app.
        /// </summary>
        /// <remarks>
        /// Disable all recommendations for an app.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='environmentName'>
        /// Name of the app.
        /// </param>
        /// <param name='hostingEnvironmentName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DisableAllForHostingEnvironmentWithHttpMessagesAsync(string resourceGroupName, string environmentName, string hostingEnvironmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reset all recommendation opt-out settings for an app.
        /// </summary>
        /// <remarks>
        /// Reset all recommendation opt-out settings for an app.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='environmentName'>
        /// Name of the app.
        /// </param>
        /// <param name='hostingEnvironmentName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResetAllFiltersForHostingEnvironmentWithHttpMessagesAsync(string resourceGroupName, string environmentName, string hostingEnvironmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a recommendation rule for an app.
        /// </summary>
        /// <remarks>
        /// Get a recommendation rule for an app.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='hostingEnvironmentName'>
        /// Name of the hosting environment.
        /// </param>
        /// <param name='name'>
        /// Name of the recommendation.
        /// </param>
        /// <param name='updateSeen'>
        /// Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen
        /// timestamp of the recommendation object.
        /// </param>
        /// <param name='recommendationId'>
        /// The GUID of the recommendation object if you query an expired one.
        /// You don't need to specify it to query an active entry.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecommendationRuleInner>> GetRuleDetailsByHostingEnvironmentWithHttpMessagesAsync(string resourceGroupName, string hostingEnvironmentName, string name, bool? updateSeen = default(bool?), string recommendationId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disables the specific rule for a web site permanently.
        /// </summary>
        /// <remarks>
        /// Disables the specific rule for a web site permanently.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='environmentName'>
        /// Site name
        /// </param>
        /// <param name='name'>
        /// Rule name
        /// </param>
        /// <param name='hostingEnvironmentName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DisableRecommendationForHostingEnvironmentWithHttpMessagesAsync(string resourceGroupName, string environmentName, string name, string hostingEnvironmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get past recommendations for an app, optionally specified by the
        /// time range.
        /// </summary>
        /// <remarks>
        /// Get past recommendations for an app, optionally specified by the
        /// time range.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='siteName'>
        /// Name of the app.
        /// </param>
        /// <param name='expiredOnly'>
        /// Specify &lt;code&gt;false&lt;/code&gt; to return all
        /// recommendations. The default is &lt;code&gt;true&lt;/code&gt;,
        /// which returns only expired recommendations.
        /// </param>
        /// <param name='filter'>
        /// Filter is specified by using OData syntax. Example: $filter=channel
        /// eq 'Api' or channel eq 'Notification' and startTime eq
        /// 2014-01-01T00:00:00Z and endTime eq 2014-12-31T23:59:59Z and
        /// timeGrain eq duration'[PT1H|PT1M|P1D]
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListHistoryForWebAppWithHttpMessagesAsync(string resourceGroupName, string siteName, bool? expiredOnly = default(bool?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all recommendations for an app.
        /// </summary>
        /// <remarks>
        /// Get all recommendations for an app.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='siteName'>
        /// Name of the app.
        /// </param>
        /// <param name='featured'>
        /// Specify &lt;code&gt;true&lt;/code&gt; to return only the most
        /// critical recommendations. The default is
        /// &lt;code&gt;false&lt;/code&gt;, which returns all recommendations.
        /// </param>
        /// <param name='filter'>
        /// Return only channels specified in the filter. Filter is specified
        /// by using OData syntax. Example: $filter=channel eq 'Api' or channel
        /// eq 'Notification'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListRecommendedRulesForWebAppWithHttpMessagesAsync(string resourceGroupName, string siteName, bool? featured = default(bool?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disable all recommendations for an app.
        /// </summary>
        /// <remarks>
        /// Disable all recommendations for an app.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='siteName'>
        /// Name of the app.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DisableAllForWebAppWithHttpMessagesAsync(string resourceGroupName, string siteName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reset all recommendation opt-out settings for an app.
        /// </summary>
        /// <remarks>
        /// Reset all recommendation opt-out settings for an app.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='siteName'>
        /// Name of the app.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ResetAllFiltersForWebAppWithHttpMessagesAsync(string resourceGroupName, string siteName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a recommendation rule for an app.
        /// </summary>
        /// <remarks>
        /// Get a recommendation rule for an app.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='siteName'>
        /// Name of the app.
        /// </param>
        /// <param name='name'>
        /// Name of the recommendation.
        /// </param>
        /// <param name='updateSeen'>
        /// Specify &lt;code&gt;true&lt;/code&gt; to update the last-seen
        /// timestamp of the recommendation object.
        /// </param>
        /// <param name='recommendationId'>
        /// The GUID of the recommendation object if you query an expired one.
        /// You don't need to specify it to query an active entry.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecommendationRuleInner>> GetRuleDetailsByWebAppWithHttpMessagesAsync(string resourceGroupName, string siteName, string name, bool? updateSeen = default(bool?), string recommendationId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disables the specific rule for a web site permanently.
        /// </summary>
        /// <remarks>
        /// Disables the specific rule for a web site permanently.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of the resource group to which the resource belongs.
        /// </param>
        /// <param name='siteName'>
        /// Site name
        /// </param>
        /// <param name='name'>
        /// Rule name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DisableRecommendationForSiteWithHttpMessagesAsync(string resourceGroupName, string siteName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all recommendations for a subscription.
        /// </summary>
        /// <remarks>
        /// List all recommendations for a subscription.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get past recommendations for an app, optionally specified by the
        /// time range.
        /// </summary>
        /// <remarks>
        /// Get past recommendations for an app, optionally specified by the
        /// time range.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListHistoryForHostingEnvironmentNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all recommendations for an app.
        /// </summary>
        /// <remarks>
        /// Get all recommendations for an app.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListRecommendedRulesForHostingEnvironmentNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get past recommendations for an app, optionally specified by the
        /// time range.
        /// </summary>
        /// <remarks>
        /// Get past recommendations for an app, optionally specified by the
        /// time range.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListHistoryForWebAppNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all recommendations for an app.
        /// </summary>
        /// <remarks>
        /// Get all recommendations for an app.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecommendationInner>>> ListRecommendedRulesForWebAppNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
