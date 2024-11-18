// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The user owned AML workspace for Cognitive Services account. </summary>
    public partial class UserOwnedAmlWorkspace
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

        /// <summary> Initializes a new instance of <see cref="UserOwnedAmlWorkspace"/>. </summary>
        public UserOwnedAmlWorkspace()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UserOwnedAmlWorkspace"/>. </summary>
        /// <param name="resourceId"> Full resource id of a AML workspace resource. </param>
        /// <param name="identityClientId"> Identity Client id of a AML workspace resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserOwnedAmlWorkspace(ResourceIdentifier resourceId, Guid? identityClientId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            IdentityClientId = identityClientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Full resource id of a AML workspace resource. </summary>
        [WirePath("resourceId")]
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Identity Client id of a AML workspace resource. </summary>
        [WirePath("identityClientId")]
        public Guid? IdentityClientId { get; set; }
    }
}
