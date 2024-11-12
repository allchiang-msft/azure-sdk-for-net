// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ManagementPartner.Samples
{
    public partial class Sample_PartnerResponseCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPartnerDetails()
        {
            // Generated from example definition: specification/managementpartner/resource-manager/Microsoft.ManagementPartner/preview/2018-02-01/examples/GetPartnerDetails.json
            // this example is just showing the usage of "Partner_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PartnerResponseResource
            PartnerResponseCollection collection = tenantResource.GetPartnerResponses();

            // invoke the operation
            string partnerId = "123456";
            PartnerResponseResource result = await collection.GetAsync(partnerId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerResponseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetPartnerDetails()
        {
            // Generated from example definition: specification/managementpartner/resource-manager/Microsoft.ManagementPartner/preview/2018-02-01/examples/GetPartnerDetails.json
            // this example is just showing the usage of "Partner_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PartnerResponseResource
            PartnerResponseCollection collection = tenantResource.GetPartnerResponses();

            // invoke the operation
            string partnerId = "123456";
            bool result = await collection.ExistsAsync(partnerId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetPartnerDetails()
        {
            // Generated from example definition: specification/managementpartner/resource-manager/Microsoft.ManagementPartner/preview/2018-02-01/examples/GetPartnerDetails.json
            // this example is just showing the usage of "Partner_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PartnerResponseResource
            PartnerResponseCollection collection = tenantResource.GetPartnerResponses();

            // invoke the operation
            string partnerId = "123456";
            NullableResponse<PartnerResponseResource> response = await collection.GetIfExistsAsync(partnerId);
            PartnerResponseResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PartnerResponseData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutPartnerDetails()
        {
            // Generated from example definition: specification/managementpartner/resource-manager/Microsoft.ManagementPartner/preview/2018-02-01/examples/PutPartnerDetails.json
            // this example is just showing the usage of "Partner_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PartnerResponseResource
            PartnerResponseCollection collection = tenantResource.GetPartnerResponses();

            // invoke the operation
            string partnerId = "123456";
            ArmOperation<PartnerResponseResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, partnerId);
            PartnerResponseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerResponseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
