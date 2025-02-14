// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> StorageApplianceEnableRemoteVendorManagementParameters represents the body of the request to enable remote vendor management of a storage appliance. </summary>
    public partial class StorageApplianceEnableRemoteVendorManagementContent
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

        /// <summary> Initializes a new instance of <see cref="StorageApplianceEnableRemoteVendorManagementContent"/>. </summary>
        public StorageApplianceEnableRemoteVendorManagementContent()
        {
            SupportEndpoints = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageApplianceEnableRemoteVendorManagementContent"/>. </summary>
        /// <param name="supportEndpoints"> Field Deprecated. This field is not used and will be rejected if provided. The list of IPv4 subnets (in CIDR format), IPv6 subnets (in CIDR format), or hostnames that the storage appliance needs accessible in order to turn on the remote vendor management. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageApplianceEnableRemoteVendorManagementContent(IList<string> supportEndpoints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SupportEndpoints = supportEndpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Field Deprecated. This field is not used and will be rejected if provided. The list of IPv4 subnets (in CIDR format), IPv6 subnets (in CIDR format), or hostnames that the storage appliance needs accessible in order to turn on the remote vendor management. </summary>
        public IList<string> SupportEndpoints { get; }
    }
}
