// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The Azure Automation Runbook notification receiver. </summary>
    public partial class MonitorAutomationRunbookReceiver
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitorAutomationRunbookReceiver"/>. </summary>
        /// <param name="automationAccountId"> The Azure automation account Id which holds this runbook and authenticate to Azure resource. </param>
        /// <param name="runbookName"> The name for this runbook. </param>
        /// <param name="webhookResourceId"> The resource id for webhook linked to this runbook. </param>
        /// <param name="isGlobalRunbook"> Indicates whether this instance is global runbook. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="automationAccountId"/>, <paramref name="runbookName"/> or <paramref name="webhookResourceId"/> is null. </exception>
        public MonitorAutomationRunbookReceiver(ResourceIdentifier automationAccountId, string runbookName, ResourceIdentifier webhookResourceId, bool isGlobalRunbook)
        {
            Argument.AssertNotNull(automationAccountId, nameof(automationAccountId));
            Argument.AssertNotNull(runbookName, nameof(runbookName));
            Argument.AssertNotNull(webhookResourceId, nameof(webhookResourceId));

            AutomationAccountId = automationAccountId;
            RunbookName = runbookName;
            WebhookResourceId = webhookResourceId;
            IsGlobalRunbook = isGlobalRunbook;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorAutomationRunbookReceiver"/>. </summary>
        /// <param name="automationAccountId"> The Azure automation account Id which holds this runbook and authenticate to Azure resource. </param>
        /// <param name="runbookName"> The name for this runbook. </param>
        /// <param name="webhookResourceId"> The resource id for webhook linked to this runbook. </param>
        /// <param name="isGlobalRunbook"> Indicates whether this instance is global runbook. </param>
        /// <param name="name"> Indicates name of the webhook. </param>
        /// <param name="serviceUri"> The URI where webhooks should be sent. </param>
        /// <param name="useCommonAlertSchema"> Indicates whether to use common alert schema. </param>
        /// <param name="managedIdentity"> The principal id of the managed identity. The value can be "None", "SystemAssigned". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorAutomationRunbookReceiver(ResourceIdentifier automationAccountId, string runbookName, ResourceIdentifier webhookResourceId, bool isGlobalRunbook, string name, Uri serviceUri, bool? useCommonAlertSchema, string managedIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AutomationAccountId = automationAccountId;
            RunbookName = runbookName;
            WebhookResourceId = webhookResourceId;
            IsGlobalRunbook = isGlobalRunbook;
            Name = name;
            ServiceUri = serviceUri;
            UseCommonAlertSchema = useCommonAlertSchema;
            ManagedIdentity = managedIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorAutomationRunbookReceiver"/> for deserialization. </summary>
        internal MonitorAutomationRunbookReceiver()
        {
        }

        /// <summary> The Azure automation account Id which holds this runbook and authenticate to Azure resource. </summary>
        public ResourceIdentifier AutomationAccountId { get; set; }
        /// <summary> The name for this runbook. </summary>
        public string RunbookName { get; set; }
        /// <summary> The resource id for webhook linked to this runbook. </summary>
        public ResourceIdentifier WebhookResourceId { get; set; }
        /// <summary> Indicates whether this instance is global runbook. </summary>
        public bool IsGlobalRunbook { get; set; }
        /// <summary> Indicates name of the webhook. </summary>
        public string Name { get; set; }
        /// <summary> The URI where webhooks should be sent. </summary>
        public Uri ServiceUri { get; set; }
        /// <summary> Indicates whether to use common alert schema. </summary>
        public bool? UseCommonAlertSchema { get; set; }
        /// <summary> The principal id of the managed identity. The value can be "None", "SystemAssigned". </summary>
        public string ManagedIdentity { get; set; }
    }
}
