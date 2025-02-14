// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A class representing the BatchApplication data model.
    /// Contains information about an application in a Batch account.
    /// </summary>
    public partial class BatchApplicationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="BatchApplicationData"/>. </summary>
        public BatchApplicationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplicationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The display name for the application. </param>
        /// <param name="allowUpdates"> A value indicating whether packages within the application may be overwritten using the same version string. </param>
        /// <param name="defaultVersion"> The package to use if a client requests the application but does not specify a version. This property can only be set to the name of an existing package. </param>
        /// <param name="etag"> The ETag of the resource, used for concurrency statements. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchApplicationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, bool? allowUpdates, string defaultVersion, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            AllowUpdates = allowUpdates;
            DefaultVersion = defaultVersion;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The display name for the application. </summary>
        public string DisplayName { get; set; }
        /// <summary> A value indicating whether packages within the application may be overwritten using the same version string. </summary>
        public bool? AllowUpdates { get; set; }
        /// <summary> The package to use if a client requests the application but does not specify a version. This property can only be set to the name of an existing package. </summary>
        public string DefaultVersion { get; set; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
