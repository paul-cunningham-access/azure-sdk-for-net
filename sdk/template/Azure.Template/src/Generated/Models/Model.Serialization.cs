// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Template.Models
{
    public partial class Model : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ModelProperty != null)
            {
                writer.WritePropertyName("ModelProperty");
                writer.WriteStringValue(ModelProperty);
            }
            writer.WritePropertyName("Fruit");
            writer.WriteStringValue(Fruit.ToString());
            writer.WritePropertyName("DaysOfWeek");
            writer.WriteStringValue(DaysOfWeek.ToString());
            writer.WriteEndObject();
        }
        internal static Model DeserializeModel(JsonElement element)
        {
            Model result = new Model();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ModelProperty"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ModelProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Fruit"))
                {
                    result.Fruit = new Fruit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("DaysOfWeek"))
                {
                    result.DaysOfWeek = new DaysOfWeek(property.Value.GetString());
                    continue;
                }
            }
            return result;
        }
    }
}
