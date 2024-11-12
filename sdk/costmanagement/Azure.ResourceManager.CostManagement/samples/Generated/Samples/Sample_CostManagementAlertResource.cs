// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CostManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CostManagement.Samples
{
    public partial class Sample_CostManagementAlertResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SingleResourceGroupAlerts()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/SingleResourceGroupAlert.json
            // this example is just showing the usage of "Alerts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CostManagementAlertResource created on azure
            // for more information of creating CostManagementAlertResource, please refer to the document of CostManagementAlertResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ScreenSharingTest-peer";
            string alertId = "22222222-2222-2222-2222-222222222222";
            ResourceIdentifier costManagementAlertResourceId = CostManagementAlertResource.CreateResourceIdentifier(scope, alertId);
            CostManagementAlertResource costManagementAlert = client.GetCostManagementAlertResource(costManagementAlertResourceId);

            // invoke the operation
            CostManagementAlertResource result = await costManagementAlert.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CostManagementAlertData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SingleSubscriptionAlerts()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/SingleSubscriptionAlert.json
            // this example is just showing the usage of "Alerts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CostManagementAlertResource created on azure
            // for more information of creating CostManagementAlertResource, please refer to the document of CostManagementAlertResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string alertId = "22222222-2222-2222-2222-222222222222";
            ResourceIdentifier costManagementAlertResourceId = CostManagementAlertResource.CreateResourceIdentifier(scope, alertId);
            CostManagementAlertResource costManagementAlert = client.GetCostManagementAlertResource(costManagementAlertResourceId);

            // invoke the operation
            CostManagementAlertResource result = await costManagementAlert.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CostManagementAlertData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchResourceGroupAlerts()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/DismissResourceGroupAlerts.json
            // this example is just showing the usage of "Alerts_Dismiss" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CostManagementAlertResource created on azure
            // for more information of creating CostManagementAlertResource, please refer to the document of CostManagementAlertResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/ScreenSharingTest-peer";
            string alertId = "22222222-2222-2222-2222-222222222222";
            ResourceIdentifier costManagementAlertResourceId = CostManagementAlertResource.CreateResourceIdentifier(scope, alertId);
            CostManagementAlertResource costManagementAlert = client.GetCostManagementAlertResource(costManagementAlertResourceId);

            // invoke the operation
            CostManagementAlertPatch patch = new CostManagementAlertPatch()
            {
                Status = CostManagementAlertStatus.Dismissed,
            };
            CostManagementAlertResource result = await costManagementAlert.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CostManagementAlertData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchSubscriptionAlerts()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/DismissSubscriptionAlerts.json
            // this example is just showing the usage of "Alerts_Dismiss" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CostManagementAlertResource created on azure
            // for more information of creating CostManagementAlertResource, please refer to the document of CostManagementAlertResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string alertId = "22222222-2222-2222-2222-222222222222";
            ResourceIdentifier costManagementAlertResourceId = CostManagementAlertResource.CreateResourceIdentifier(scope, alertId);
            CostManagementAlertResource costManagementAlert = client.GetCostManagementAlertResource(costManagementAlertResourceId);

            // invoke the operation
            CostManagementAlertPatch patch = new CostManagementAlertPatch()
            {
                Status = CostManagementAlertStatus.Dismissed,
            };
            CostManagementAlertResource result = await costManagementAlert.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CostManagementAlertData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCostManagementAlerts_ExternalBillingAccountAlerts()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/ExternalBillingAccountAlerts.json
            // this example is just showing the usage of "Alerts_ListExternal" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation and iterate over the result
            ExternalCloudProviderType externalCloudProviderType = ExternalCloudProviderType.ExternalBillingAccounts;
            string externalCloudProviderId = "100";
            await foreach (CostManagementAlertResource item in tenantResource.GetCostManagementAlertsAsync(externalCloudProviderType, externalCloudProviderId))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CostManagementAlertData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCostManagementAlerts_ExternalSubscriptionAlerts()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/ExternalSubscriptionAlerts.json
            // this example is just showing the usage of "Alerts_ListExternal" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation and iterate over the result
            ExternalCloudProviderType externalCloudProviderType = ExternalCloudProviderType.ExternalSubscriptions;
            string externalCloudProviderId = "100";
            await foreach (CostManagementAlertResource item in tenantResource.GetCostManagementAlertsAsync(externalCloudProviderType, externalCloudProviderId))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CostManagementAlertData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
