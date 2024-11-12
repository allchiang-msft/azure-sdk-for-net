// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ElasticSan.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ElasticSan.Samples
{
    public partial class Sample_ElasticSanPrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PrivateEndpointConnectionsCreateMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnections_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanPrivateEndpointConnectionResource created on azure
            // for more information of creating ElasticSanPrivateEndpointConnectionResource, please refer to the document of ElasticSanPrivateEndpointConnectionResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string privateEndpointConnectionName = "privateendpointconnectionname";
            ResourceIdentifier elasticSanPrivateEndpointConnectionResourceId = ElasticSanPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, privateEndpointConnectionName);
            ElasticSanPrivateEndpointConnectionResource elasticSanPrivateEndpointConnection = client.GetElasticSanPrivateEndpointConnectionResource(elasticSanPrivateEndpointConnectionResourceId);

            // invoke the operation
            ElasticSanPrivateEndpointConnectionData data = new ElasticSanPrivateEndpointConnectionData(new ElasticSanPrivateLinkServiceConnectionState()
            {
                Status = ElasticSanPrivateEndpointServiceConnectionStatus.Pending,
                Description = "dxl",
                ActionsRequired = "jhjdpwvyzipggtn",
            })
            {
                GroupIds =
{
"jdwrzpemdjrpiwzvy"
},
            };
            ArmOperation<ElasticSanPrivateEndpointConnectionResource> lro = await elasticSanPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            ElasticSanPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PrivateEndpointConnectionsCreateMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Create_MinimumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnections_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanPrivateEndpointConnectionResource created on azure
            // for more information of creating ElasticSanPrivateEndpointConnectionResource, please refer to the document of ElasticSanPrivateEndpointConnectionResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string privateEndpointConnectionName = "privateendpointconnectionname";
            ResourceIdentifier elasticSanPrivateEndpointConnectionResourceId = ElasticSanPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, privateEndpointConnectionName);
            ElasticSanPrivateEndpointConnectionResource elasticSanPrivateEndpointConnection = client.GetElasticSanPrivateEndpointConnectionResource(elasticSanPrivateEndpointConnectionResourceId);

            // invoke the operation
            ElasticSanPrivateEndpointConnectionData data = new ElasticSanPrivateEndpointConnectionData(new ElasticSanPrivateLinkServiceConnectionState());
            ArmOperation<ElasticSanPrivateEndpointConnectionResource> lro = await elasticSanPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            ElasticSanPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanPrivateEndpointConnectionResource created on azure
            // for more information of creating ElasticSanPrivateEndpointConnectionResource, please refer to the document of ElasticSanPrivateEndpointConnectionResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string privateEndpointConnectionName = "privateendpointconnectionname";
            ResourceIdentifier elasticSanPrivateEndpointConnectionResourceId = ElasticSanPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, privateEndpointConnectionName);
            ElasticSanPrivateEndpointConnectionResource elasticSanPrivateEndpointConnection = client.GetElasticSanPrivateEndpointConnectionResource(elasticSanPrivateEndpointConnectionResourceId);

            // invoke the operation
            ElasticSanPrivateEndpointConnectionResource result = await elasticSanPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionsGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanPrivateEndpointConnectionResource created on azure
            // for more information of creating ElasticSanPrivateEndpointConnectionResource, please refer to the document of ElasticSanPrivateEndpointConnectionResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string privateEndpointConnectionName = "privateendpointconnectionname";
            ResourceIdentifier elasticSanPrivateEndpointConnectionResourceId = ElasticSanPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, privateEndpointConnectionName);
            ElasticSanPrivateEndpointConnectionResource elasticSanPrivateEndpointConnection = client.GetElasticSanPrivateEndpointConnectionResource(elasticSanPrivateEndpointConnectionResourceId);

            // invoke the operation
            ElasticSanPrivateEndpointConnectionResource result = await elasticSanPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PrivateEndpointConnectionsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanPrivateEndpointConnectionResource created on azure
            // for more information of creating ElasticSanPrivateEndpointConnectionResource, please refer to the document of ElasticSanPrivateEndpointConnectionResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string privateEndpointConnectionName = "privateendpointconnectionname";
            ResourceIdentifier elasticSanPrivateEndpointConnectionResourceId = ElasticSanPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, privateEndpointConnectionName);
            ElasticSanPrivateEndpointConnectionResource elasticSanPrivateEndpointConnection = client.GetElasticSanPrivateEndpointConnectionResource(elasticSanPrivateEndpointConnectionResourceId);

            // invoke the operation
            await elasticSanPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_PrivateEndpointConnectionsDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/PrivateEndpointConnections_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanPrivateEndpointConnectionResource created on azure
            // for more information of creating ElasticSanPrivateEndpointConnectionResource, please refer to the document of ElasticSanPrivateEndpointConnectionResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            string privateEndpointConnectionName = "privateendpointconnectionname";
            ResourceIdentifier elasticSanPrivateEndpointConnectionResourceId = ElasticSanPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName, privateEndpointConnectionName);
            ElasticSanPrivateEndpointConnectionResource elasticSanPrivateEndpointConnection = client.GetElasticSanPrivateEndpointConnectionResource(elasticSanPrivateEndpointConnectionResourceId);

            // invoke the operation
            await elasticSanPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
