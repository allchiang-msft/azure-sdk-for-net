// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class which represents the RestApis for a given azure namespace.
    /// </summary>
    public partial class RestApiCollection : ArmCollection, IEnumerable<RestApi>, IAsyncEnumerable<RestApi>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly string _nameSpace;

        /// <summary> Represents the REST operations. </summary>
        private RestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="RestApiCollection"/> class for mocking. </summary>
        protected RestApiCollection()
        {
        }

        /// <summary> Initializes a new instance of RestApiCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="nameSpace"> The namespace for the rest apis. </param>
        internal RestApiCollection(ClientContext parent, string nameSpace) : base(parent.ClientOptions, parent.Credential, parent.BaseUri, parent.Pipeline)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _nameSpace = nameSpace;
            _restClient = new RestOperations(_nameSpace, ClientOptions.ApiVersions.GetApiVersionForNamespace(nameSpace), _clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.Root.ResourceType;

        /// <summary> Gets a list of operations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestApi" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestApi> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestApi> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestApiCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.List(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets a list of operations. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestApi" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestApi> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestApi>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestApiCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<RestApi> IEnumerable<RestApi>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestApi> IAsyncEnumerable<RestApi>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
