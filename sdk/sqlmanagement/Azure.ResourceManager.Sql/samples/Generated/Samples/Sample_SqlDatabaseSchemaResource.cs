// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlDatabaseSchemaResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDatabaseSchema()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/DatabaseSchemaGet.json
            // this example is just showing the usage of "DatabaseSchemas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseSchemaResource created on azure
            // for more information of creating SqlDatabaseSchemaResource, please refer to the document of SqlDatabaseSchemaResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "myRG";
            string serverName = "serverName";
            string databaseName = "myDatabase";
            string schemaName = "dbo";
            ResourceIdentifier sqlDatabaseSchemaResourceId = SqlDatabaseSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, schemaName);
            SqlDatabaseSchemaResource sqlDatabaseSchema = client.GetSqlDatabaseSchemaResource(sqlDatabaseSchemaResourceId);

            // invoke the operation
            SqlDatabaseSchemaResource result = await sqlDatabaseSchema.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
