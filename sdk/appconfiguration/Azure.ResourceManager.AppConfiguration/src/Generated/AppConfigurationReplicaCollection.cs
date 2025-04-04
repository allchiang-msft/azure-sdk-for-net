// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="AppConfigurationReplicaResource"/> and their operations.
    /// Each <see cref="AppConfigurationReplicaResource"/> in the collection will belong to the same instance of <see cref="AppConfigurationStoreResource"/>.
    /// To get an <see cref="AppConfigurationReplicaCollection"/> instance call the GetAppConfigurationReplicas method from an instance of <see cref="AppConfigurationStoreResource"/>.
    /// </summary>
    public partial class AppConfigurationReplicaCollection : ArmCollection, IEnumerable<AppConfigurationReplicaResource>, IAsyncEnumerable<AppConfigurationReplicaResource>
    {
        private readonly ClientDiagnostics _appConfigurationReplicaReplicasClientDiagnostics;
        private readonly ReplicasRestOperations _appConfigurationReplicaReplicasRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationReplicaCollection"/> class for mocking. </summary>
        protected AppConfigurationReplicaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppConfigurationReplicaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppConfigurationReplicaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appConfigurationReplicaReplicasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", AppConfigurationReplicaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppConfigurationReplicaResource.ResourceType, out string appConfigurationReplicaReplicasApiVersion);
            _appConfigurationReplicaReplicasRestClient = new ReplicasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appConfigurationReplicaReplicasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AppConfigurationStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AppConfigurationStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a replica with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="replicaName"> The name of the replica. </param>
        /// <param name="data"> The parameters for creating a replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppConfigurationReplicaResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string replicaName, AppConfigurationReplicaData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appConfigurationReplicaReplicasRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation<AppConfigurationReplicaResource>(new AppConfigurationReplicaOperationSource(Client), _appConfigurationReplicaReplicasClientDiagnostics, Pipeline, _appConfigurationReplicaReplicasRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a replica with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="replicaName"> The name of the replica. </param>
        /// <param name="data"> The parameters for creating a replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppConfigurationReplicaResource> CreateOrUpdate(WaitUntil waitUntil, string replicaName, AppConfigurationReplicaData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appConfigurationReplicaReplicasRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, data, cancellationToken);
                var operation = new AppConfigurationArmOperation<AppConfigurationReplicaResource>(new AppConfigurationReplicaOperationSource(Client), _appConfigurationReplicaReplicasClientDiagnostics, Pipeline, _appConfigurationReplicaReplicasRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified replica.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicaName"> The name of the replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual async Task<Response<AppConfigurationReplicaResource>> GetAsync(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaCollection.Get");
            scope.Start();
            try
            {
                var response = await _appConfigurationReplicaReplicasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified replica.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicaName"> The name of the replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual Response<AppConfigurationReplicaResource> Get(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaCollection.Get");
            scope.Start();
            try
            {
                var response = _appConfigurationReplicaReplicasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the replicas for a given configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_ListByConfigurationStore</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppConfigurationReplicaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppConfigurationReplicaResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appConfigurationReplicaReplicasRestClient.CreateListByConfigurationStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appConfigurationReplicaReplicasRestClient.CreateListByConfigurationStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationReplicaResource(Client, AppConfigurationReplicaData.DeserializeAppConfigurationReplicaData(e)), _appConfigurationReplicaReplicasClientDiagnostics, Pipeline, "AppConfigurationReplicaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the replicas for a given configuration store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_ListByConfigurationStore</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppConfigurationReplicaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppConfigurationReplicaResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appConfigurationReplicaReplicasRestClient.CreateListByConfigurationStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appConfigurationReplicaReplicasRestClient.CreateListByConfigurationStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppConfigurationReplicaResource(Client, AppConfigurationReplicaData.DeserializeAppConfigurationReplicaData(e)), _appConfigurationReplicaReplicasClientDiagnostics, Pipeline, "AppConfigurationReplicaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicaName"> The name of the replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appConfigurationReplicaReplicasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicaName"> The name of the replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual Response<bool> Exists(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaCollection.Exists");
            scope.Start();
            try
            {
                var response = _appConfigurationReplicaReplicasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicaName"> The name of the replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppConfigurationReplicaResource>> GetIfExistsAsync(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appConfigurationReplicaReplicasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppConfigurationReplicaResource>(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/replicas/{replicaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Replicas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppConfigurationReplicaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="replicaName"> The name of the replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual NullableResponse<AppConfigurationReplicaResource> GetIfExists(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _appConfigurationReplicaReplicasClientDiagnostics.CreateScope("AppConfigurationReplicaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appConfigurationReplicaReplicasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, replicaName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppConfigurationReplicaResource>(response.GetRawResponse());
                return Response.FromValue(new AppConfigurationReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppConfigurationReplicaResource> IEnumerable<AppConfigurationReplicaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppConfigurationReplicaResource> IAsyncEnumerable<AppConfigurationReplicaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
