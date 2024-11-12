// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualRouterResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteVirtualRouter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualRouterDelete.json
            // this example is just showing the usage of "VirtualRouters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterResource created on azure
            // for more information of creating VirtualRouterResource, please refer to the document of VirtualRouterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            ResourceIdentifier virtualRouterResourceId = VirtualRouterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName);
            VirtualRouterResource virtualRouter = client.GetVirtualRouterResource(virtualRouterResourceId);

            // invoke the operation
            await virtualRouter.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualRouter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualRouterGet.json
            // this example is just showing the usage of "VirtualRouters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterResource created on azure
            // for more information of creating VirtualRouterResource, please refer to the document of VirtualRouterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            ResourceIdentifier virtualRouterResourceId = VirtualRouterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName);
            VirtualRouterResource virtualRouter = client.GetVirtualRouterResource(virtualRouterResourceId);

            // invoke the operation
            VirtualRouterResource result = await virtualRouter.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualRouterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateVirtualRouter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualRouterPut.json
            // this example is just showing the usage of "VirtualRouters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualRouterResource created on azure
            // for more information of creating VirtualRouterResource, please refer to the document of VirtualRouterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualRouterName = "virtualRouter";
            ResourceIdentifier virtualRouterResourceId = VirtualRouterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualRouterName);
            VirtualRouterResource virtualRouter = client.GetVirtualRouterResource(virtualRouterResourceId);

            // invoke the operation
            VirtualRouterData data = new VirtualRouterData()
            {
                HostedGatewayId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/vnetGateway"),
                Location = new AzureLocation("West US"),
                Tags =
{
["key1"] = "value1",
},
            };
            ArmOperation<VirtualRouterResource> lro = await virtualRouter.UpdateAsync(WaitUntil.Completed, data);
            VirtualRouterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualRouterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetVirtualRouters_ListAllVirtualRoutersForAGivenSubscription()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VirtualRouterListBySubscription.json
            // this example is just showing the usage of "VirtualRouters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VirtualRouterResource item in subscriptionResource.GetVirtualRoutersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualRouterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
