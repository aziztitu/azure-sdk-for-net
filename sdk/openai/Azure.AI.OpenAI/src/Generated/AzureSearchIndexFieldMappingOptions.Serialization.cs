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

namespace Azure.AI.OpenAI
{
    public partial class AzureSearchIndexFieldMappingOptions : IUtf8JsonSerializable, IJsonModel<AzureSearchIndexFieldMappingOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureSearchIndexFieldMappingOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureSearchIndexFieldMappingOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSearchIndexFieldMappingOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureSearchIndexFieldMappingOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TitleFieldName))
            {
                writer.WritePropertyName("title_field"u8);
                writer.WriteStringValue(TitleFieldName);
            }
            if (Optional.IsDefined(UrlFieldName))
            {
                writer.WritePropertyName("url_field"u8);
                writer.WriteStringValue(UrlFieldName);
            }
            if (Optional.IsDefined(FilepathFieldName))
            {
                writer.WritePropertyName("filepath_field"u8);
                writer.WriteStringValue(FilepathFieldName);
            }
            if (Optional.IsCollectionDefined(ContentFieldNames))
            {
                writer.WritePropertyName("content_fields"u8);
                writer.WriteStartArray();
                foreach (var item in ContentFieldNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContentFieldSeparator))
            {
                writer.WritePropertyName("content_fields_separator"u8);
                writer.WriteStringValue(ContentFieldSeparator);
            }
            if (Optional.IsCollectionDefined(VectorFieldNames))
            {
                writer.WritePropertyName("vector_fields"u8);
                writer.WriteStartArray();
                foreach (var item in VectorFieldNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ImageVectorFieldNames))
            {
                writer.WritePropertyName("image_vector_fields"u8);
                writer.WriteStartArray();
                foreach (var item in ImageVectorFieldNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        AzureSearchIndexFieldMappingOptions IJsonModel<AzureSearchIndexFieldMappingOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSearchIndexFieldMappingOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureSearchIndexFieldMappingOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureSearchIndexFieldMappingOptions(document.RootElement, options);
        }

        internal static AzureSearchIndexFieldMappingOptions DeserializeAzureSearchIndexFieldMappingOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string titleField = default;
            string urlField = default;
            string filepathField = default;
            IList<string> contentFields = default;
            string contentFieldsSeparator = default;
            IList<string> vectorFields = default;
            IList<string> imageVectorFields = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title_field"u8))
                {
                    titleField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url_field"u8))
                {
                    urlField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filepath_field"u8))
                {
                    filepathField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content_fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contentFields = array;
                    continue;
                }
                if (property.NameEquals("content_fields_separator"u8))
                {
                    contentFieldsSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vector_fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vectorFields = array;
                    continue;
                }
                if (property.NameEquals("image_vector_fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    imageVectorFields = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureSearchIndexFieldMappingOptions(
                titleField,
                urlField,
                filepathField,
                contentFields ?? new ChangeTrackingList<string>(),
                contentFieldsSeparator,
                vectorFields ?? new ChangeTrackingList<string>(),
                imageVectorFields ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureSearchIndexFieldMappingOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSearchIndexFieldMappingOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureSearchIndexFieldMappingOptions)} does not support '{options.Format}' format.");
            }
        }

        AzureSearchIndexFieldMappingOptions IPersistableModel<AzureSearchIndexFieldMappingOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSearchIndexFieldMappingOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureSearchIndexFieldMappingOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureSearchIndexFieldMappingOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureSearchIndexFieldMappingOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureSearchIndexFieldMappingOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureSearchIndexFieldMappingOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
