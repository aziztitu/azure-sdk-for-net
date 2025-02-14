// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> DNS Proxy Settings in Firewall Policy. </summary>
    public partial class DnsSettings
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

        /// <summary> Initializes a new instance of <see cref="DnsSettings"/>. </summary>
        public DnsSettings()
        {
            Servers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsSettings"/>. </summary>
        /// <param name="servers"> List of Custom DNS Servers. </param>
        /// <param name="enableProxy"> Enable DNS Proxy on Firewalls attached to the Firewall Policy. </param>
        /// <param name="requireProxyForNetworkRules"> FQDNs in Network Rules are supported when set to true. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsSettings(IList<string> servers, bool? enableProxy, bool? requireProxyForNetworkRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Servers = servers;
            EnableProxy = enableProxy;
            RequireProxyForNetworkRules = requireProxyForNetworkRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Custom DNS Servers. </summary>
        public IList<string> Servers { get; }
        /// <summary> Enable DNS Proxy on Firewalls attached to the Firewall Policy. </summary>
        public bool? EnableProxy { get; set; }
        /// <summary> FQDNs in Network Rules are supported when set to true. </summary>
        public bool? RequireProxyForNetworkRules { get; set; }
    }
}
