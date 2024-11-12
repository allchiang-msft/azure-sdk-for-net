// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.RedisEnterprise.Samples
{
    public partial class Sample_AccessPolicyAssignmentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_RedisEnterpriseAccessPolicyAssignmentCreateUpdate()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseAccessPolicyAssignmentCreateUpdate.json
            // this example is just showing the usage of "AccessPolicyAssignment_CreateUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // get the collection of this AccessPolicyAssignmentResource
            AccessPolicyAssignmentCollection collection = redisEnterpriseDatabase.GetAccessPolicyAssignments();

            // invoke the operation
            string accessPolicyAssignmentName = "defaultTestEntraApp1";
            AccessPolicyAssignmentData data = new AccessPolicyAssignmentData()
            {
                AccessPolicyName = "default",
                UserObjectId = Guid.Parse("6497c918-11ad-41e7-1b0f-7c518a87d0b0"),
            };
            ArmOperation<AccessPolicyAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accessPolicyAssignmentName, data);
            AccessPolicyAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AccessPolicyAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RedisEnterpriseAccessPolicyAssignmentGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseAccessPolicyAssignmentGet.json
            // this example is just showing the usage of "AccessPolicyAssignment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // get the collection of this AccessPolicyAssignmentResource
            AccessPolicyAssignmentCollection collection = redisEnterpriseDatabase.GetAccessPolicyAssignments();

            // invoke the operation
            string accessPolicyAssignmentName = "accessPolicyAssignmentName1";
            AccessPolicyAssignmentResource result = await collection.GetAsync(accessPolicyAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AccessPolicyAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RedisEnterpriseAccessPolicyAssignmentGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseAccessPolicyAssignmentGet.json
            // this example is just showing the usage of "AccessPolicyAssignment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // get the collection of this AccessPolicyAssignmentResource
            AccessPolicyAssignmentCollection collection = redisEnterpriseDatabase.GetAccessPolicyAssignments();

            // invoke the operation
            string accessPolicyAssignmentName = "accessPolicyAssignmentName1";
            bool result = await collection.ExistsAsync(accessPolicyAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RedisEnterpriseAccessPolicyAssignmentGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseAccessPolicyAssignmentGet.json
            // this example is just showing the usage of "AccessPolicyAssignment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // get the collection of this AccessPolicyAssignmentResource
            AccessPolicyAssignmentCollection collection = redisEnterpriseDatabase.GetAccessPolicyAssignments();

            // invoke the operation
            string accessPolicyAssignmentName = "accessPolicyAssignmentName1";
            NullableResponse<AccessPolicyAssignmentResource> response = await collection.GetIfExistsAsync(accessPolicyAssignmentName);
            AccessPolicyAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AccessPolicyAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_RedisEnterpriseAccessPolicyAssignmentList()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseAccessPolicyAssignmentsList.json
            // this example is just showing the usage of "AccessPolicyAssignment_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseDatabaseResource created on azure
            // for more information of creating RedisEnterpriseDatabaseResource, please refer to the document of RedisEnterpriseDatabaseResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string databaseName = "default";
            ResourceIdentifier redisEnterpriseDatabaseResourceId = RedisEnterpriseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName);
            RedisEnterpriseDatabaseResource redisEnterpriseDatabase = client.GetRedisEnterpriseDatabaseResource(redisEnterpriseDatabaseResourceId);

            // get the collection of this AccessPolicyAssignmentResource
            AccessPolicyAssignmentCollection collection = redisEnterpriseDatabase.GetAccessPolicyAssignments();

            // invoke the operation and iterate over the result
            await foreach (AccessPolicyAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AccessPolicyAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
