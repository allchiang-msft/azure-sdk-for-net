// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SecurityConnectorGitLabGroupCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListGitLabGroups()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/ListGitLabGroups_example.json
            // this example is just showing the usage of "GitLabGroups_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this SecurityConnectorGitLabGroupResource
            SecurityConnectorGitLabGroupCollection collection = devOpsConfiguration.GetSecurityConnectorGitLabGroups();

            // invoke the operation and iterate over the result
            await foreach (SecurityConnectorGitLabGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityConnectorGitLabGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetGitLabGroups()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetGitLabGroups_example.json
            // this example is just showing the usage of "GitLabGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this SecurityConnectorGitLabGroupResource
            SecurityConnectorGitLabGroupCollection collection = devOpsConfiguration.GetSecurityConnectorGitLabGroups();

            // invoke the operation
            string groupFQName = "myGitLabGroup$mySubGroup";
            SecurityConnectorGitLabGroupResource result = await collection.GetAsync(groupFQName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityConnectorGitLabGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetGitLabGroups()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetGitLabGroups_example.json
            // this example is just showing the usage of "GitLabGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this SecurityConnectorGitLabGroupResource
            SecurityConnectorGitLabGroupCollection collection = devOpsConfiguration.GetSecurityConnectorGitLabGroups();

            // invoke the operation
            string groupFQName = "myGitLabGroup$mySubGroup";
            bool result = await collection.ExistsAsync(groupFQName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetGitLabGroups()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/GetGitLabGroups_example.json
            // this example is just showing the usage of "GitLabGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this SecurityConnectorGitLabGroupResource
            SecurityConnectorGitLabGroupCollection collection = devOpsConfiguration.GetSecurityConnectorGitLabGroups();

            // invoke the operation
            string groupFQName = "myGitLabGroup$mySubGroup";
            NullableResponse<SecurityConnectorGitLabGroupResource> response = await collection.GetIfExistsAsync(groupFQName);
            SecurityConnectorGitLabGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityConnectorGitLabGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetGitLabSubgroups_ListGitLabSubgroups()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2023-09-01-preview/examples/SecurityConnectorsDevOps/ListGitLabSubgroups_example.json
            // this example is just showing the usage of "GitLabSubgroups_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevOpsConfigurationResource created on azure
            // for more information of creating DevOpsConfigurationResource, please refer to the document of DevOpsConfigurationResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            ResourceIdentifier devOpsConfigurationResourceId = DevOpsConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName);
            DevOpsConfigurationResource devOpsConfiguration = client.GetDevOpsConfigurationResource(devOpsConfigurationResourceId);

            // get the collection of this SecurityConnectorGitLabGroupResource
            SecurityConnectorGitLabGroupCollection collection = devOpsConfiguration.GetSecurityConnectorGitLabGroups();

            // invoke the operation and iterate over the result
            string groupFQName = "myGitLabGroup";
            await foreach (SecurityConnectorGitLabGroupResource item in collection.GetGitLabSubgroupsAsync(groupFQName))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityConnectorGitLabGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
