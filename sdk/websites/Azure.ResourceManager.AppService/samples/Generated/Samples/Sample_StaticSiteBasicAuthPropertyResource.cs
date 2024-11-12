// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_StaticSiteBasicAuthPropertyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheBasicAuthPropertiesForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetStaticSiteBasicAuth.json
            // this example is just showing the usage of "StaticSites_GetBasicAuth" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBasicAuthPropertyResource created on azure
            // for more information of creating StaticSiteBasicAuthPropertyResource, please refer to the document of StaticSiteBasicAuthPropertyResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            StaticSiteBasicAuthName basicAuthName = StaticSiteBasicAuthName.Default;
            ResourceIdentifier staticSiteBasicAuthPropertyResourceId = StaticSiteBasicAuthPropertyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, basicAuthName);
            StaticSiteBasicAuthPropertyResource staticSiteBasicAuthProperty = client.GetStaticSiteBasicAuthPropertyResource(staticSiteBasicAuthPropertyResourceId);

            // invoke the operation
            StaticSiteBasicAuthPropertyResource result = await staticSiteBasicAuthProperty.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteBasicAuthPropertyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesOrUpdatesBasicAuthPropertiesForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/CreateOrUpdateStaticSiteBasicAuth.json
            // this example is just showing the usage of "StaticSites_CreateOrUpdateBasicAuth" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBasicAuthPropertyResource created on azure
            // for more information of creating StaticSiteBasicAuthPropertyResource, please refer to the document of StaticSiteBasicAuthPropertyResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            StaticSiteBasicAuthName basicAuthName = StaticSiteBasicAuthName.Default;
            ResourceIdentifier staticSiteBasicAuthPropertyResourceId = StaticSiteBasicAuthPropertyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, basicAuthName);
            StaticSiteBasicAuthPropertyResource staticSiteBasicAuthProperty = client.GetStaticSiteBasicAuthPropertyResource(staticSiteBasicAuthPropertyResourceId);

            // invoke the operation
            StaticSiteBasicAuthPropertyData data = new StaticSiteBasicAuthPropertyData()
            {
                Password = "**********************",
                SecretUri = null,
                ApplicableEnvironmentsMode = "AllEnvironments",
                Environments =
{
},
            };
            ArmOperation<StaticSiteBasicAuthPropertyResource> lro = await staticSiteBasicAuthProperty.UpdateAsync(WaitUntil.Completed, data);
            StaticSiteBasicAuthPropertyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteBasicAuthPropertyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
