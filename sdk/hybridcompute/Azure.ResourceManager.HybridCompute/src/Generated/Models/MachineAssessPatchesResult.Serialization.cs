// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineAssessPatchesResult : IUtf8JsonSerializable, IJsonModel<MachineAssessPatchesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineAssessPatchesResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineAssessPatchesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineAssessPatchesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineAssessPatchesResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AssessmentActivityId))
            {
                writer.WritePropertyName("assessmentActivityId"u8);
                writer.WriteStringValue(AssessmentActivityId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsRebootPending))
            {
                writer.WritePropertyName("rebootPending"u8);
                writer.WriteBooleanValue(IsRebootPending.Value);
            }
            if (Optional.IsDefined(AvailablePatchCountByClassification))
            {
                writer.WritePropertyName("availablePatchCountByClassification"u8);
                writer.WriteObjectValue(AvailablePatchCountByClassification);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedDateTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StartedBy))
            {
                writer.WritePropertyName("startedBy"u8);
                writer.WriteStringValue(StartedBy.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PatchServiceUsed))
            {
                writer.WritePropertyName("patchServiceUsed"u8);
                writer.WriteStringValue(PatchServiceUsed.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorDetails))
            {
                writer.WritePropertyName("errorDetails"u8);
                JsonSerializer.Serialize(writer, ErrorDetails);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MachineAssessPatchesResult IJsonModel<MachineAssessPatchesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineAssessPatchesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineAssessPatchesResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineAssessPatchesResult(document.RootElement, options);
        }

        internal static MachineAssessPatchesResult DeserializeMachineAssessPatchesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineOperationStatus? status = default;
            Guid? assessmentActivityId = default;
            bool? rebootPending = default;
            AvailablePatchCountByClassification availablePatchCountByClassification = default;
            DateTimeOffset? startDateTime = default;
            DateTimeOffset? lastModifiedDateTime = default;
            PatchOperationStartedBy? startedBy = default;
            PatchServiceUsed? patchServiceUsed = default;
            HybridComputeOSType? osType = default;
            ResponseError errorDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessmentActivityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentActivityId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("rebootPending"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootPending = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("availablePatchCountByClassification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availablePatchCountByClassification = AvailablePatchCountByClassification.DeserializeAvailablePatchCountByClassification(property.Value, options);
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedBy = new PatchOperationStartedBy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("patchServiceUsed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchServiceUsed = new PatchServiceUsed(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new HybridComputeOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorDetails = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineAssessPatchesResult(
                status,
                assessmentActivityId,
                rebootPending,
                availablePatchCountByClassification,
                startDateTime,
                lastModifiedDateTime,
                startedBy,
                patchServiceUsed,
                osType,
                errorDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineAssessPatchesResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineAssessPatchesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineAssessPatchesResult)} does not support '{options.Format}' format.");
            }
        }

        MachineAssessPatchesResult IPersistableModel<MachineAssessPatchesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineAssessPatchesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineAssessPatchesResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineAssessPatchesResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineAssessPatchesResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
