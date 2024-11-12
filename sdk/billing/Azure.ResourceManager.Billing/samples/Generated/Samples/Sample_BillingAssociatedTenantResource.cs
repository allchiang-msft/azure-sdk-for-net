// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingAssociatedTenantResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_AssociatedTenantsDelete()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/associatedTenantsDelete.json
            // this example is just showing the usage of "AssociatedTenants_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAssociatedTenantResource created on azure
            // for more information of creating BillingAssociatedTenantResource, please refer to the document of BillingAssociatedTenantResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string associatedTenantName = "11111111-1111-1111-1111-111111111111";
            ResourceIdentifier billingAssociatedTenantResourceId = BillingAssociatedTenantResource.CreateResourceIdentifier(billingAccountName, associatedTenantName);
            BillingAssociatedTenantResource billingAssociatedTenant = client.GetBillingAssociatedTenantResource(billingAssociatedTenantResourceId);

            // invoke the operation
            await billingAssociatedTenant.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AssociatedTenantsGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/associatedTenantsGet.json
            // this example is just showing the usage of "AssociatedTenants_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAssociatedTenantResource created on azure
            // for more information of creating BillingAssociatedTenantResource, please refer to the document of BillingAssociatedTenantResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string associatedTenantName = "11111111-1111-1111-1111-111111111111";
            ResourceIdentifier billingAssociatedTenantResourceId = BillingAssociatedTenantResource.CreateResourceIdentifier(billingAccountName, associatedTenantName);
            BillingAssociatedTenantResource billingAssociatedTenant = client.GetBillingAssociatedTenantResource(billingAssociatedTenantResourceId);

            // invoke the operation
            BillingAssociatedTenantResource result = await billingAssociatedTenant.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingAssociatedTenantData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AssociatedTenantsCreateOrUpdate()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/associatedTenantsCreateOrUpdate.json
            // this example is just showing the usage of "AssociatedTenants_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAssociatedTenantResource created on azure
            // for more information of creating BillingAssociatedTenantResource, please refer to the document of BillingAssociatedTenantResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string associatedTenantName = "11111111-1111-1111-1111-111111111111";
            ResourceIdentifier billingAssociatedTenantResourceId = BillingAssociatedTenantResource.CreateResourceIdentifier(billingAccountName, associatedTenantName);
            BillingAssociatedTenantResource billingAssociatedTenant = client.GetBillingAssociatedTenantResource(billingAssociatedTenantResourceId);

            // invoke the operation
            BillingAssociatedTenantData data = new BillingAssociatedTenantData()
            {
                Properties = new BillingAssociatedTenantProperties()
                {
                    DisplayName = "Contoso Finance",
                    BillingManagementState = BillingManagementTenantState.Active,
                    ProvisioningManagementState = BillingProvisioningTenantState.Pending,
                },
            };
            ArmOperation<BillingAssociatedTenantResource> lro = await billingAssociatedTenant.UpdateAsync(WaitUntil.Completed, data);
            BillingAssociatedTenantResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingAssociatedTenantData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
