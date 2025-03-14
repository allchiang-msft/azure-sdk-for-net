// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Connection properties for connections with Custom authentication. </summary>
    public partial class InternalConnectionPropertiesCustomAuth : ConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="InternalConnectionPropertiesCustomAuth"/>. </summary>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="target"> The connection URL to be used for this service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> is null. </exception>
        internal InternalConnectionPropertiesCustomAuth(ConnectionType category, string target) : base(category, target)
        {
            Argument.AssertNotNull(target, nameof(target));

            AuthType = AuthenticationType.Custom;
        }

        /// <summary> Initializes a new instance of <see cref="InternalConnectionPropertiesCustomAuth"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="target"> The connection URL to be used for this service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalConnectionPropertiesCustomAuth(AuthenticationType authType, ConnectionType category, string target, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(authType, category, target, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="InternalConnectionPropertiesCustomAuth"/> for deserialization. </summary>
        internal InternalConnectionPropertiesCustomAuth()
        {
        }
    }
}
