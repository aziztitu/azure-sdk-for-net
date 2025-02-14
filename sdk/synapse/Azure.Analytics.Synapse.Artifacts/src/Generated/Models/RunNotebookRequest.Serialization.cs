// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunNotebookRequestConverter))]
    public partial class RunNotebookRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Notebook))
            {
                writer.WritePropertyName("notebook"u8);
                writer.WriteStringValue(Notebook);
            }
            if (Optional.IsDefined(SparkPool))
            {
                writer.WritePropertyName("sparkPool"u8);
                writer.WriteStringValue(SparkPool);
            }
            if (Optional.IsDefined(SessionOptions))
            {
                writer.WritePropertyName("sessionOptions"u8);
                writer.WriteObjectValue(SessionOptions);
            }
            if (Optional.IsDefined(HonorSessionTimeToLive))
            {
                writer.WritePropertyName("honorSessionTimeToLive"u8);
                writer.WriteBooleanValue(HonorSessionTimeToLive.Value);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal partial class RunNotebookRequestConverter : JsonConverter<RunNotebookRequest>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RunNotebookRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
    }
}
