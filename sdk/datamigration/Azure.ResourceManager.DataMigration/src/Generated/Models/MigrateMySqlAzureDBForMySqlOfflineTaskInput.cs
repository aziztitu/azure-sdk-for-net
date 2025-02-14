// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that migrates MySQL databases to Azure Database for MySQL for offline migrations. </summary>
    public partial class MigrateMySqlAzureDBForMySqlOfflineTaskInput
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

        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for source MySQL. </param>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for MySQL. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/> or <paramref name="selectedDatabases"/> is null. </exception>
        public MigrateMySqlAzureDBForMySqlOfflineTaskInput(MySqlConnectionInfo sourceConnectionInfo, MySqlConnectionInfo targetConnectionInfo, IEnumerable<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput> selectedDatabases)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));

            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases.ToList();
            OptionalAgentSettings = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for source MySQL. </param>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for MySQL. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="makeSourceServerReadOnly"> Setting to set the source server read only. </param>
        /// <param name="startedOn"> Parameter to specify when the migration started. </param>
        /// <param name="optionalAgentSettings"> Optional parameters for fine tuning the data transfer rate during migration. </param>
        /// <param name="encryptedKeyForSecureFields"> encrypted key for secure fields. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateMySqlAzureDBForMySqlOfflineTaskInput(MySqlConnectionInfo sourceConnectionInfo, MySqlConnectionInfo targetConnectionInfo, IList<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput> selectedDatabases, bool? makeSourceServerReadOnly, DateTimeOffset? startedOn, IDictionary<string, string> optionalAgentSettings, string encryptedKeyForSecureFields, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            SelectedDatabases = selectedDatabases;
            MakeSourceServerReadOnly = makeSourceServerReadOnly;
            StartedOn = startedOn;
            OptionalAgentSettings = optionalAgentSettings;
            EncryptedKeyForSecureFields = encryptedKeyForSecureFields;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskInput"/> for deserialization. </summary>
        internal MigrateMySqlAzureDBForMySqlOfflineTaskInput()
        {
        }

        /// <summary> Connection information for source MySQL. </summary>
        public MySqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Connection information for target Azure Database for MySQL. </summary>
        public MySqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Databases to migrate. </summary>
        public IList<MigrateMySqlAzureDBForMySqlOfflineDatabaseInput> SelectedDatabases { get; }
        /// <summary> Setting to set the source server read only. </summary>
        public bool? MakeSourceServerReadOnly { get; set; }
        /// <summary> Parameter to specify when the migration started. </summary>
        public DateTimeOffset? StartedOn { get; set; }
        /// <summary> Optional parameters for fine tuning the data transfer rate during migration. </summary>
        public IDictionary<string, string> OptionalAgentSettings { get; }
        /// <summary> encrypted key for secure fields. </summary>
        public string EncryptedKeyForSecureFields { get; set; }
    }
}
