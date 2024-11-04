// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    public partial class TranslationGlossary : IUtf8JsonSerializable, IJsonModel<TranslationGlossary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TranslationGlossary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TranslationGlossary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslationGlossary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranslationGlossary)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("glossaryUrl"u8);
            writer.WriteStringValue(GlossaryUri.AbsoluteUri);
            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format);
            if (Optional.IsDefined(FormatVersion))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(FormatVersion);
            }
            if (Optional.IsDefined(StorageSource))
            {
                writer.WritePropertyName("storageSource"u8);
                writer.WriteStringValue(StorageSource);
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
        }

        TranslationGlossary IJsonModel<TranslationGlossary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslationGlossary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranslationGlossary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTranslationGlossary(document.RootElement, options);
        }

        internal static TranslationGlossary DeserializeTranslationGlossary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri glossaryUrl = default;
            string format = default;
            string version = default;
            string storageSource = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("glossaryUrl"u8))
                {
                    glossaryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("format"u8))
                {
                    format = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageSource"u8))
                {
                    storageSource = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TranslationGlossary(glossaryUrl, format, version, storageSource, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TranslationGlossary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslationGlossary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TranslationGlossary)} does not support writing '{options.Format}' format.");
            }
        }

        TranslationGlossary IPersistableModel<TranslationGlossary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranslationGlossary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTranslationGlossary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TranslationGlossary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TranslationGlossary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TranslationGlossary FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTranslationGlossary(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
