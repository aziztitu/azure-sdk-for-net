// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The fields mapping for Relationships. </summary>
    public partial class RelationshipLinkFieldMapping
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

        /// <summary> Initializes a new instance of <see cref="RelationshipLinkFieldMapping"/>. </summary>
        /// <param name="interactionFieldName"> The field name on the Interaction Type. </param>
        /// <param name="relationshipFieldName"> The field name on the Relationship metadata. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionFieldName"/> or <paramref name="relationshipFieldName"/> is null. </exception>
        public RelationshipLinkFieldMapping(string interactionFieldName, string relationshipFieldName)
        {
            Argument.AssertNotNull(interactionFieldName, nameof(interactionFieldName));
            Argument.AssertNotNull(relationshipFieldName, nameof(relationshipFieldName));

            InteractionFieldName = interactionFieldName;
            RelationshipFieldName = relationshipFieldName;
        }

        /// <summary> Initializes a new instance of <see cref="RelationshipLinkFieldMapping"/>. </summary>
        /// <param name="interactionFieldName"> The field name on the Interaction Type. </param>
        /// <param name="linkType"> Link type. </param>
        /// <param name="relationshipFieldName"> The field name on the Relationship metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelationshipLinkFieldMapping(string interactionFieldName, LinkType? linkType, string relationshipFieldName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InteractionFieldName = interactionFieldName;
            LinkType = linkType;
            RelationshipFieldName = relationshipFieldName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RelationshipLinkFieldMapping"/> for deserialization. </summary>
        internal RelationshipLinkFieldMapping()
        {
        }

        /// <summary> The field name on the Interaction Type. </summary>
        public string InteractionFieldName { get; set; }
        /// <summary> Link type. </summary>
        public LinkType? LinkType { get; set; }
        /// <summary> The field name on the Relationship metadata. </summary>
        public string RelationshipFieldName { get; set; }
    }
}
