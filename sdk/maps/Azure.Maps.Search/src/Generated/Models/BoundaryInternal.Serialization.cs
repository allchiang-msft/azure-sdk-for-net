// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    internal partial class BoundaryInternal
    {
        internal static BoundaryInternal DeserializeBoundaryInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string copyright = default;
            string copyrightURL = default;
            IReadOnlyList<GeometryCopyright> geometriesCopyright = default;
            GeoJsonGeometry geometry = default;
            object properties = default;
            string id = default;
            string featureType = default;
            GeoJsonObjectType type = default;
            IReadOnlyList<double> boundingBox = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyright"u8))
                {
                    copyright = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyrightURL"u8))
                {
                    copyrightURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("geometriesCopyright"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GeometryCopyright> array = new List<GeometryCopyright>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeometryCopyright.DeserializeGeometryCopyright(item));
                    }
                    geometriesCopyright = array;
                    continue;
                }
                if (property.NameEquals("geometry"u8))
                {
                    geometry = GeoJsonGeometry.DeserializeGeoJsonGeometry(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("featureType"u8))
                {
                    featureType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new GeoJsonObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("boundingBox"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    boundingBox = array;
                    continue;
                }
            }
            return new BoundaryInternal(
                type,
                boundingBox ?? new ChangeTrackingList<double>(),
                geometry,
                properties,
                id,
                featureType,
                name,
                copyright,
                copyrightURL,
                geometriesCopyright ?? new ChangeTrackingList<GeometryCopyright>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new BoundaryInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeBoundaryInternal(document.RootElement);
        }
    }
}
