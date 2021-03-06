// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ManagementPolicyAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseBlob))
            {
                writer.WritePropertyName("baseBlob");
                writer.WriteObjectValue(BaseBlob);
            }
            if (Optional.IsDefined(Snapshot))
            {
                writer.WritePropertyName("snapshot");
                writer.WriteObjectValue(Snapshot);
            }
            writer.WriteEndObject();
        }

        internal static ManagementPolicyAction DeserializeManagementPolicyAction(JsonElement element)
        {
            Optional<ManagementPolicyBaseBlob> baseBlob = default;
            Optional<ManagementPolicySnapShot> snapshot = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseBlob"))
                {
                    baseBlob = ManagementPolicyBaseBlob.DeserializeManagementPolicyBaseBlob(property.Value);
                    continue;
                }
                if (property.NameEquals("snapshot"))
                {
                    snapshot = ManagementPolicySnapShot.DeserializeManagementPolicySnapShot(property.Value);
                    continue;
                }
            }
            return new ManagementPolicyAction(baseBlob.Value, snapshot.Value);
        }
    }
}
