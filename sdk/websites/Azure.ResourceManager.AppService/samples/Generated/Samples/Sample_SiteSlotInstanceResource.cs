// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteSlotInstanceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSiteInstanceInfo()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetSiteInstanceInfo.json
            // this example is just showing the usage of "WebApps_GetInstanceInfoSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotInstanceResource created on azure
            // for more information of creating SiteSlotInstanceResource, please refer to the document of SiteSlotInstanceResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "tests346";
            string slot = "staging";
            string instanceId = "134987120";
            ResourceIdentifier siteSlotInstanceResourceId = SiteSlotInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, slot, instanceId);
            SiteSlotInstanceResource siteSlotInstance = client.GetSiteSlotInstanceResource(siteSlotInstanceResourceId);

            // invoke the operation
            SiteSlotInstanceResource result = await siteSlotInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteInstanceStatusData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
