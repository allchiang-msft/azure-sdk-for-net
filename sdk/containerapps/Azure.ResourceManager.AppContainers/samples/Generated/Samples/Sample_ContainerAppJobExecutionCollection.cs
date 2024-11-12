// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppJobExecutionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAContainerAppsJobExecutions()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/Job_Executions_Get.json
            // this example is just showing the usage of "JobsExecutions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerappsjob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // get the collection of this ContainerAppJobExecutionResource
            ContainerAppJobExecutionCollection collection = containerAppJob.GetContainerAppJobExecutions();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppJobExecutionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppJobExecutionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetASingleJobExecution()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/Job_Execution_Get.json
            // this example is just showing the usage of "JobExecution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerappsjob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // get the collection of this ContainerAppJobExecutionResource
            ContainerAppJobExecutionCollection collection = containerAppJob.GetContainerAppJobExecutions();

            // invoke the operation
            string jobExecutionName = "jobExecution1";
            ContainerAppJobExecutionResource result = await collection.GetAsync(jobExecutionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppJobExecutionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetASingleJobExecution()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/Job_Execution_Get.json
            // this example is just showing the usage of "JobExecution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerappsjob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // get the collection of this ContainerAppJobExecutionResource
            ContainerAppJobExecutionCollection collection = containerAppJob.GetContainerAppJobExecutions();

            // invoke the operation
            string jobExecutionName = "jobExecution1";
            bool result = await collection.ExistsAsync(jobExecutionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetASingleJobExecution()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/stable/2024-03-01/examples/Job_Execution_Get.json
            // this example is just showing the usage of "JobExecution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppJobResource created on azure
            // for more information of creating ContainerAppJobResource, please refer to the document of ContainerAppJobResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string jobName = "testcontainerappsjob0";
            ResourceIdentifier containerAppJobResourceId = ContainerAppJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            ContainerAppJobResource containerAppJob = client.GetContainerAppJobResource(containerAppJobResourceId);

            // get the collection of this ContainerAppJobExecutionResource
            ContainerAppJobExecutionCollection collection = containerAppJob.GetContainerAppJobExecutions();

            // invoke the operation
            string jobExecutionName = "jobExecution1";
            NullableResponse<ContainerAppJobExecutionResource> response = await collection.GetIfExistsAsync(jobExecutionName);
            ContainerAppJobExecutionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppJobExecutionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
