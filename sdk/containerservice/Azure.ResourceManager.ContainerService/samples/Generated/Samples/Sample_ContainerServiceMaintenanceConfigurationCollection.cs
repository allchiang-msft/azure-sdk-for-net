// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerService.Samples
{
    public partial class Sample_ContainerServiceMaintenanceConfigurationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListMaintenanceConfigurationsByManagedCluster()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsList.json
            // this example is just showing the usage of "MaintenanceConfigurations_ListByManagedCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation and iterate over the result
            await foreach (ContainerServiceMaintenanceConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceMaintenanceConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListMaintenanceConfigurationsConfiguredWithMaintenanceWindowByManagedCluster()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsList_MaintenanceWindow.json
            // this example is just showing the usage of "MaintenanceConfigurations_ListByManagedCluster" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation and iterate over the result
            await foreach (ContainerServiceMaintenanceConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceMaintenanceConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetMaintenanceConfiguration()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsGet.json
            // this example is just showing the usage of "MaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation
            string configName = "default";
            ContainerServiceMaintenanceConfigurationResource result = await collection.GetAsync(configName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceMaintenanceConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetMaintenanceConfiguration()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsGet.json
            // this example is just showing the usage of "MaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation
            string configName = "default";
            bool result = await collection.ExistsAsync(configName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetMaintenanceConfiguration()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsGet.json
            // this example is just showing the usage of "MaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation
            string configName = "default";
            NullableResponse<ContainerServiceMaintenanceConfigurationResource> response = await collection.GetIfExistsAsync(configName);
            ContainerServiceMaintenanceConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceMaintenanceConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetMaintenanceConfigurationConfiguredWithMaintenanceWindow()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsGet_MaintenanceWindow.json
            // this example is just showing the usage of "MaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation
            string configName = "aksManagedNodeOSUpgradeSchedule";
            ContainerServiceMaintenanceConfigurationResource result = await collection.GetAsync(configName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceMaintenanceConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetMaintenanceConfigurationConfiguredWithMaintenanceWindow()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsGet_MaintenanceWindow.json
            // this example is just showing the usage of "MaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation
            string configName = "aksManagedNodeOSUpgradeSchedule";
            bool result = await collection.ExistsAsync(configName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetMaintenanceConfigurationConfiguredWithMaintenanceWindow()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsGet_MaintenanceWindow.json
            // this example is just showing the usage of "MaintenanceConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation
            string configName = "aksManagedNodeOSUpgradeSchedule";
            NullableResponse<ContainerServiceMaintenanceConfigurationResource> response = await collection.GetIfExistsAsync(configName);
            ContainerServiceMaintenanceConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceMaintenanceConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateUpdateMaintenanceConfiguration()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsCreate_Update.json
            // this example is just showing the usage of "MaintenanceConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation
            string configName = "default";
            ContainerServiceMaintenanceConfigurationData data = new ContainerServiceMaintenanceConfigurationData()
            {
                TimesInWeek =
{
new ContainerServiceTimeInWeek()
{
Day = ContainerServiceWeekDay.Monday,
HourSlots =
{
1,2
},
}
},
                NotAllowedTimes =
{
new ContainerServiceTimeSpan()
{
StartOn = DateTimeOffset.Parse("2020-11-26T03:00:00Z"),
EndOn = DateTimeOffset.Parse("2020-11-30T12:00:00Z"),
}
},
            };
            ArmOperation<ContainerServiceMaintenanceConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configName, data);
            ContainerServiceMaintenanceConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceMaintenanceConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateUpdateMaintenanceConfigurationWithMaintenanceWindow()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2023-10-01/examples/MaintenanceConfigurationsCreate_Update_MaintenanceWindow.json
            // this example is just showing the usage of "MaintenanceConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceMaintenanceConfigurationResource
            ContainerServiceMaintenanceConfigurationCollection collection = containerServiceManagedCluster.GetContainerServiceMaintenanceConfigurations();

            // invoke the operation
            string configName = "aksManagedAutoUpgradeSchedule";
            ContainerServiceMaintenanceConfigurationData data = new ContainerServiceMaintenanceConfigurationData()
            {
                MaintenanceWindow = new ContainerServiceMaintenanceWindow(new ContainerServiceMaintenanceSchedule()
                {
                    RelativeMonthly = new ContainerServiceMaintenanceRelativeMonthlySchedule(3, ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex.First, ContainerServiceWeekDay.Monday),
                }, 10, "08:30")
                {
                    UtcOffset = "+05:30",
                    StartDate = "2023-01-01",
                    NotAllowedDates =
{
new ContainerServiceDateSpan(DateTimeOffset.Parse("2023-02-18"),DateTimeOffset.Parse("2023-02-25")),new ContainerServiceDateSpan(DateTimeOffset.Parse("2023-12-23"),DateTimeOffset.Parse("2024-01-05"))
},
                },
            };
            ArmOperation<ContainerServiceMaintenanceConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configName, data);
            ContainerServiceMaintenanceConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceMaintenanceConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
