// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Capacity pool patch resource. </summary>
    public partial class CapacityPoolPatch : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="CapacityPoolPatch"/>. </summary>
        /// <param name="location"> The location. </param>
        public CapacityPoolPatch(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="CapacityPoolPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="size"> Provisioned size of the pool (in bytes). Allowed values are in 1TiB chunks (value must be multiple of 1099511627776). </param>
        /// <param name="qosType"> The qos type of the pool. </param>
        /// <param name="isCoolAccessEnabled"> If enabled (true) the pool can contain cool Access enabled volumes. </param>
        /// <param name="customThroughputMibps"> Maximum throughput in MiB/s that can be achieved by this pool and this will be accepted as input only for manual qosType pool with Flexible service level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CapacityPoolPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, long? size, CapacityPoolQosType? qosType, bool? isCoolAccessEnabled, float? customThroughputMibps, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Size = size;
            QosType = qosType;
            IsCoolAccessEnabled = isCoolAccessEnabled;
            CustomThroughputMibps = customThroughputMibps;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CapacityPoolPatch"/> for deserialization. </summary>
        internal CapacityPoolPatch()
        {
        }

        /// <summary> Provisioned size of the pool (in bytes). Allowed values are in 1TiB chunks (value must be multiple of 1099511627776). </summary>
        public long? Size { get; set; }
        /// <summary> The qos type of the pool. </summary>
        public CapacityPoolQosType? QosType { get; set; }
        /// <summary> If enabled (true) the pool can contain cool Access enabled volumes. </summary>
        public bool? IsCoolAccessEnabled { get; set; }
        /// <summary> Maximum throughput in MiB/s that can be achieved by this pool and this will be accepted as input only for manual qosType pool with Flexible service level. </summary>
        public float? CustomThroughputMibps { get; set; }
    }
}
