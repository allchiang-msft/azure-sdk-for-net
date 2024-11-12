// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Search.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Search.Samples
{
    public partial class Sample_SearchPrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PrivateEndpointConnectionUpdate()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2024-06-01-preview/examples/UpdatePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchPrivateEndpointConnectionResource created on azure
            // for more information of creating SearchPrivateEndpointConnectionResource, please refer to the document of SearchPrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            string privateEndpointConnectionName = "testEndpoint.50bf4fbe-d7c1-4b48-a642-4f5892642546";
            ResourceIdentifier searchPrivateEndpointConnectionResourceId = SearchPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName, privateEndpointConnectionName);
            SearchPrivateEndpointConnectionResource searchPrivateEndpointConnection = client.GetSearchPrivateEndpointConnectionResource(searchPrivateEndpointConnectionResourceId);

            // invoke the operation
            SearchPrivateEndpointConnectionData data = new SearchPrivateEndpointConnectionData()
            {
                Properties = new SearchServicePrivateEndpointConnectionProperties()
                {
                    ConnectionState = new SearchServicePrivateLinkServiceConnectionState()
                    {
                        Status = SearchServicePrivateLinkServiceConnectionStatus.Rejected,
                        Description = "Rejected for some reason.",
                    },
                },
            };
            ArmOperation<SearchPrivateEndpointConnectionResource> lro = await searchPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            SearchPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionGet()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2024-06-01-preview/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchPrivateEndpointConnectionResource created on azure
            // for more information of creating SearchPrivateEndpointConnectionResource, please refer to the document of SearchPrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            string privateEndpointConnectionName = "testEndpoint.50bf4fbe-d7c1-4b48-a642-4f5892642546";
            ResourceIdentifier searchPrivateEndpointConnectionResourceId = SearchPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName, privateEndpointConnectionName);
            SearchPrivateEndpointConnectionResource searchPrivateEndpointConnection = client.GetSearchPrivateEndpointConnectionResource(searchPrivateEndpointConnectionResourceId);

            // invoke the operation
            SearchPrivateEndpointConnectionResource result = await searchPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PrivateEndpointConnectionDelete()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2024-06-01-preview/examples/DeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchPrivateEndpointConnectionResource created on azure
            // for more information of creating SearchPrivateEndpointConnectionResource, please refer to the document of SearchPrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            string privateEndpointConnectionName = "testEndpoint.50bf4fbe-d7c1-4b48-a642-4f5892642546";
            ResourceIdentifier searchPrivateEndpointConnectionResourceId = SearchPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName, privateEndpointConnectionName);
            SearchPrivateEndpointConnectionResource searchPrivateEndpointConnection = client.GetSearchPrivateEndpointConnectionResource(searchPrivateEndpointConnectionResourceId);

            // invoke the operation
            ArmOperation<SearchPrivateEndpointConnectionResource> lro = await searchPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);
            SearchPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
