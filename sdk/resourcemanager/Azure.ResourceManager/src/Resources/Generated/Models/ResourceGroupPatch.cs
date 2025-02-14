// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Resource group information. </summary>
    public partial class ResourceGroupPatch
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

        /// <summary> Initializes a new instance of <see cref="ResourceGroupPatch"/>. </summary>
        public ResourceGroupPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGroupPatch"/>. </summary>
        /// <param name="name"> The name of the resource group. </param>
        /// <param name="properties"> The resource group properties. </param>
        /// <param name="managedBy"> The ID of the resource that manages this resource group. </param>
        /// <param name="tags"> The tags attached to the resource group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceGroupPatch(string name, ResourceGroupProperties properties, string managedBy, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Properties = properties;
            ManagedBy = managedBy;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the resource group. </summary>
        public string Name { get; set; }
        /// <summary> The resource group properties. </summary>
        internal ResourceGroupProperties Properties { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ResourceGroupProvisioningState
        {
            get => Properties is null ? default : Properties.ProvisioningState;
        }

        /// <summary> The ID of the resource that manages this resource group. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The tags attached to the resource group. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
