// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ProviderResourceType : IUtf8JsonSerializable, IJsonModel<ProviderResourceType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProviderResourceType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProviderResourceType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderResourceType)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(RoutingType))
            {
                writer.WritePropertyName("routingType"u8);
                writer.WriteStringValue(RoutingType.Value.ToString());
            }
            if (Optional.IsDefined(ResourceValidation))
            {
                writer.WritePropertyName("resourceValidation"u8);
                writer.WriteStringValue(ResourceValidation.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedUnauthorizedActions))
            {
                writer.WritePropertyName("allowedUnauthorizedActions"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedUnauthorizedActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AuthorizationActionMappings))
            {
                writer.WritePropertyName("authorizationActionMappings"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationActionMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LinkedAccessChecks))
            {
                writer.WritePropertyName("linkedAccessChecks"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedAccessChecks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultApiVersion))
            {
                writer.WritePropertyName("defaultApiVersion"u8);
                writer.WriteStringValue(DefaultApiVersion);
            }
            if (Optional.IsCollectionDefined(LoggingRules))
            {
                writer.WritePropertyName("loggingRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoggingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ThrottlingRules))
            {
                writer.WritePropertyName("throttlingRules"u8);
                writer.WriteStartArray();
                foreach (var item in ThrottlingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MarketplaceType))
            {
                writer.WritePropertyName("marketplaceType"u8);
                writer.WriteStringValue(MarketplaceType.Value.ToSerialString());
            }
            if (Optional.IsDefined(IdentityManagement))
            {
                writer.WritePropertyName("identityManagement"u8);
                writer.WriteObjectValue(IdentityManagement);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(RequiredFeatures))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FeaturesRule))
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue(FeaturesRule);
            }
            if (Optional.IsCollectionDefined(SubscriptionStateRules))
            {
                writer.WritePropertyName("subscriptionStateRules"u8);
                writer.WriteStartArray();
                foreach (var item in SubscriptionStateRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceTreeInfos))
            {
                writer.WritePropertyName("serviceTreeInfos"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceTreeInfos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestHeaderOptions))
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue(RequestHeaderOptions);
            }
            if (Optional.IsDefined(SkuLink))
            {
                writer.WritePropertyName("skuLink"u8);
                writer.WriteStringValue(SkuLink);
            }
            if (Optional.IsCollectionDefined(DisallowedActionVerbs))
            {
                writer.WritePropertyName("disallowedActionVerbs"u8);
                writer.WriteStartArray();
                foreach (var item in DisallowedActionVerbs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TemplateDeploymentPolicy))
            {
                writer.WritePropertyName("templateDeploymentPolicy"u8);
                writer.WriteObjectValue(TemplateDeploymentPolicy);
            }
            if (Optional.IsCollectionDefined(ExtendedLocations))
            {
                writer.WritePropertyName("extendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedLocations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LinkedOperationRules))
            {
                writer.WritePropertyName("linkedOperationRules"u8);
                writer.WriteStartArray();
                foreach (var item in LinkedOperationRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResourceDeletionPolicy))
            {
                writer.WritePropertyName("resourceDeletionPolicy"u8);
                writer.WriteStringValue(ResourceDeletionPolicy.Value.ToString());
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

        ProviderResourceType IJsonModel<ProviderResourceType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderResourceType)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderResourceType(document.RootElement, options);
        }

        internal static ProviderResourceType DeserializeProviderResourceType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ResourceRoutingType? routingType = default;
            ResourceValidation? resourceValidation = default;
            IReadOnlyList<string> allowedUnauthorizedActions = default;
            IReadOnlyList<AuthorizationActionMapping> authorizationActionMappings = default;
            IReadOnlyList<LinkedAccessCheck> linkedAccessChecks = default;
            string defaultApiVersion = default;
            IReadOnlyList<LoggingRule> loggingRules = default;
            IReadOnlyList<ThrottlingRule> throttlingRules = default;
            IReadOnlyList<ResourceProviderEndpoint> endpoints = default;
            MarketplaceType? marketplaceType = default;
            IdentityManagement identityManagement = default;
            BinaryData metadata = default;
            IReadOnlyList<string> requiredFeatures = default;
            FeaturesRule featuresRule = default;
            IReadOnlyList<ProviderSubscriptionStateRule> subscriptionStateRules = default;
            IReadOnlyList<ServiceTreeInfo> serviceTreeInfos = default;
            RequestHeaderOptions requestHeaderOptions = default;
            string skuLink = default;
            IReadOnlyList<string> disallowedActionVerbs = default;
            TemplateDeploymentPolicy templateDeploymentPolicy = default;
            IReadOnlyList<ProviderHubExtendedLocationOptions> extendedLocations = default;
            IReadOnlyList<LinkedOperationRule> linkedOperationRules = default;
            ManifestResourceDeletionPolicy? resourceDeletionPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingType = new ResourceRoutingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceValidation = new ResourceValidation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedUnauthorizedActions"u8))
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
                    allowedUnauthorizedActions = array;
                    continue;
                }
                if (property.NameEquals("authorizationActionMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuthorizationActionMapping> array = new List<AuthorizationActionMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizationActionMapping.DeserializeAuthorizationActionMapping(item, options));
                    }
                    authorizationActionMappings = array;
                    continue;
                }
                if (property.NameEquals("linkedAccessChecks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedAccessCheck> array = new List<LinkedAccessCheck>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedAccessCheck.DeserializeLinkedAccessCheck(item, options));
                    }
                    linkedAccessChecks = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"u8))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoggingRule> array = new List<LoggingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoggingRule.DeserializeLoggingRule(item, options));
                    }
                    loggingRules = array;
                    continue;
                }
                if (property.NameEquals("throttlingRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThrottlingRule> array = new List<ThrottlingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThrottlingRule.DeserializeThrottlingRule(item, options));
                    }
                    throttlingRules = array;
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderEndpoint> array = new List<ResourceProviderEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderEndpoint.DeserializeResourceProviderEndpoint(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (property.NameEquals("marketplaceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceType = property.Value.GetString().ToMarketplaceType();
                    continue;
                }
                if (property.NameEquals("identityManagement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityManagement = IdentityManagement.DeserializeIdentityManagement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
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
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subscriptionStateRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderSubscriptionStateRule> array = new List<ProviderSubscriptionStateRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderSubscriptionStateRule.DeserializeProviderSubscriptionStateRule(item, options));
                    }
                    subscriptionStateRules = array;
                    continue;
                }
                if (property.NameEquals("serviceTreeInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceTreeInfo> array = new List<ServiceTreeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTreeInfo.DeserializeServiceTreeInfo(item, options));
                    }
                    serviceTreeInfos = array;
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestHeaderOptions = RequestHeaderOptions.DeserializeRequestHeaderOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("skuLink"u8))
                {
                    skuLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disallowedActionVerbs"u8))
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
                    disallowedActionVerbs = array;
                    continue;
                }
                if (property.NameEquals("templateDeploymentPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateDeploymentPolicy = TemplateDeploymentPolicy.DeserializeTemplateDeploymentPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderHubExtendedLocationOptions> array = new List<ProviderHubExtendedLocationOptions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderHubExtendedLocationOptions.DeserializeProviderHubExtendedLocationOptions(item, options));
                    }
                    extendedLocations = array;
                    continue;
                }
                if (property.NameEquals("linkedOperationRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkedOperationRule> array = new List<LinkedOperationRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedOperationRule.DeserializeLinkedOperationRule(item, options));
                    }
                    linkedOperationRules = array;
                    continue;
                }
                if (property.NameEquals("resourceDeletionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceDeletionPolicy = new ManifestResourceDeletionPolicy(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProviderResourceType(
                name,
                routingType,
                resourceValidation,
                allowedUnauthorizedActions ?? new ChangeTrackingList<string>(),
                authorizationActionMappings ?? new ChangeTrackingList<AuthorizationActionMapping>(),
                linkedAccessChecks ?? new ChangeTrackingList<LinkedAccessCheck>(),
                defaultApiVersion,
                loggingRules ?? new ChangeTrackingList<LoggingRule>(),
                throttlingRules ?? new ChangeTrackingList<ThrottlingRule>(),
                endpoints ?? new ChangeTrackingList<ResourceProviderEndpoint>(),
                marketplaceType,
                identityManagement,
                metadata,
                requiredFeatures ?? new ChangeTrackingList<string>(),
                featuresRule,
                subscriptionStateRules ?? new ChangeTrackingList<ProviderSubscriptionStateRule>(),
                serviceTreeInfos ?? new ChangeTrackingList<ServiceTreeInfo>(),
                requestHeaderOptions,
                skuLink,
                disallowedActionVerbs ?? new ChangeTrackingList<string>(),
                templateDeploymentPolicy,
                extendedLocations ?? new ChangeTrackingList<ProviderHubExtendedLocationOptions>(),
                linkedOperationRules ?? new ChangeTrackingList<LinkedOperationRule>(),
                resourceDeletionPolicy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProviderResourceType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProviderResourceType)} does not support '{options.Format}' format.");
            }
        }

        ProviderResourceType IPersistableModel<ProviderResourceType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProviderResourceType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProviderResourceType)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProviderResourceType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
