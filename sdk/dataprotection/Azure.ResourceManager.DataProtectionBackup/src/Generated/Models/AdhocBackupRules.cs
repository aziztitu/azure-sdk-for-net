// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Adhoc backup rules. </summary>
    public partial class AdhocBackupRules
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

        /// <summary> Initializes a new instance of <see cref="AdhocBackupRules"/>. </summary>
        /// <param name="ruleName"></param>
        /// <param name="backupTrigger"> Adhoc backup trigger option. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdhocBackupRules(string ruleName, AdhocBackupTriggerSetting backupTrigger, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RuleName = ruleName;
            BackupTrigger = backupTrigger;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AdhocBackupRules"/> for deserialization. </summary>
        internal AdhocBackupRules()
        {
        }

        /// <summary> Gets the rule name. </summary>
        public string RuleName { get; }
        /// <summary> Adhoc backup trigger option. </summary>
        internal AdhocBackupTriggerSetting BackupTrigger { get; }
        /// <summary> Gets the backup trigger retention tag override. </summary>
        public string BackupTriggerRetentionTagOverride
        {
            get => BackupTrigger?.RetentionTagOverride;
        }
    }
}
