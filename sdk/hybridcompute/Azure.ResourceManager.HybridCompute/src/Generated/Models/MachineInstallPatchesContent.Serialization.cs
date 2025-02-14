// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineInstallPatchesContent : IUtf8JsonSerializable, IJsonModel<MachineInstallPatchesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineInstallPatchesContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineInstallPatchesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineInstallPatchesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineInstallPatchesContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("maximumDuration"u8);
            writer.WriteStringValue(MaximumDuration, "P");
            writer.WritePropertyName("rebootSetting"u8);
            writer.WriteStringValue(RebootSetting.ToString());
            if (Optional.IsDefined(WindowsParameters))
            {
                writer.WritePropertyName("windowsParameters"u8);
                writer.WriteObjectValue(WindowsParameters);
            }
            if (Optional.IsDefined(LinuxParameters))
            {
                writer.WritePropertyName("linuxParameters"u8);
                writer.WriteObjectValue(LinuxParameters);
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

        MachineInstallPatchesContent IJsonModel<MachineInstallPatchesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineInstallPatchesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineInstallPatchesContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineInstallPatchesContent(document.RootElement, options);
        }

        internal static MachineInstallPatchesContent DeserializeMachineInstallPatchesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan maximumDuration = default;
            VmGuestPatchRebootSetting rebootSetting = default;
            HybridComputeWindowsParameters windowsParameters = default;
            HybridComputeLinuxParameters linuxParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maximumDuration"u8))
                {
                    maximumDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("rebootSetting"u8))
                {
                    rebootSetting = new VmGuestPatchRebootSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("windowsParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsParameters = HybridComputeWindowsParameters.DeserializeHybridComputeWindowsParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linuxParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxParameters = HybridComputeLinuxParameters.DeserializeHybridComputeLinuxParameters(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineInstallPatchesContent(maximumDuration, rebootSetting, windowsParameters, linuxParameters, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineInstallPatchesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineInstallPatchesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineInstallPatchesContent)} does not support '{options.Format}' format.");
            }
        }

        MachineInstallPatchesContent IPersistableModel<MachineInstallPatchesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineInstallPatchesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineInstallPatchesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineInstallPatchesContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineInstallPatchesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
