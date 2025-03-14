// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary>
    /// Connection properties
    /// Please note <see cref="ConnectionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConnectionPropertiesApiKeyAuth"/>, <see cref="InternalConnectionPropertiesCustomAuth"/> and <see cref="InternalConnectionPropertiesNoAuth"/>.
    /// </summary>
    public abstract partial class ConnectionProperties
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectionProperties"/>. </summary>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="target"> The connection URL to be used for this service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> is null. </exception>
        protected ConnectionProperties(ConnectionType category, string target)
        {
            Argument.AssertNotNull(target, nameof(target));

            Category = category;
            Target = target;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionProperties"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="target"> The connection URL to be used for this service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionProperties(AuthenticationType authType, ConnectionType category, string target, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AuthType = authType;
            Category = category;
            Target = target;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionProperties"/> for deserialization. </summary>
        internal ConnectionProperties()
        {
        }
        /// <summary> Category of the connection. </summary>
        public ConnectionType Category { get; }
        /// <summary> The connection URL to be used for this service. </summary>
        public string Target { get; }
    }
}
