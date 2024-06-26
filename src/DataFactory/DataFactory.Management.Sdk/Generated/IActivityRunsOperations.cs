// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ActivityRunsOperations operations.
    /// </summary>
    public partial interface IActivityRunsOperations
    {
        /// <summary>
        /// Query activity runs based on input filter conditions.
        /// </summary>
        /// <remarks>
        /// Query activity runs based on input filter conditions.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='runId'>
        /// The pipeline run identifier.
        /// </param>
        /// <param name='filterParameters'>
        /// Parameters to filter the activity runs.
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ActivityRunsQueryResponse>> QueryByPipelineRunWithHttpMessagesAsync(string resourceGroupName, string factoryName, string runId, RunFilterParameters filterParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}