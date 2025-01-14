// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2SecuritySettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("overrideGroupSigningCertificate"u8);
            writer.WriteBooleanValue(OverrideGroupSigningCertificate);
            if (Optional.IsDefined(SigningCertificateName))
            {
                writer.WritePropertyName("signingCertificateName"u8);
                writer.WriteStringValue(SigningCertificateName);
            }
            if (Optional.IsDefined(EncryptionCertificateName))
            {
                writer.WritePropertyName("encryptionCertificateName"u8);
                writer.WriteStringValue(EncryptionCertificateName);
            }
            writer.WritePropertyName("enableNRRForInboundEncodedMessages"u8);
            writer.WriteBooleanValue(EnableNrrForInboundEncodedMessages);
            writer.WritePropertyName("enableNRRForInboundDecodedMessages"u8);
            writer.WriteBooleanValue(EnableNrrForInboundDecodedMessages);
            writer.WritePropertyName("enableNRRForOutboundMDN"u8);
            writer.WriteBooleanValue(EnableNrrForOutboundMdn);
            writer.WritePropertyName("enableNRRForOutboundEncodedMessages"u8);
            writer.WriteBooleanValue(EnableNrrForOutboundEncodedMessages);
            writer.WritePropertyName("enableNRRForOutboundDecodedMessages"u8);
            writer.WriteBooleanValue(EnableNrrForOutboundDecodedMessages);
            writer.WritePropertyName("enableNRRForInboundMDN"u8);
            writer.WriteBooleanValue(EnableNrrForInboundMdn);
            if (Optional.IsDefined(Sha2AlgorithmFormat))
            {
                writer.WritePropertyName("sha2AlgorithmFormat"u8);
                writer.WriteStringValue(Sha2AlgorithmFormat);
            }
            writer.WriteEndObject();
        }

        internal static AS2SecuritySettings DeserializeAS2SecuritySettings(JsonElement element)
        {
            bool overrideGroupSigningCertificate = default;
            Optional<string> signingCertificateName = default;
            Optional<string> encryptionCertificateName = default;
            bool enableNrrForInboundEncodedMessages = default;
            bool enableNrrForInboundDecodedMessages = default;
            bool enableNrrForOutboundMdn = default;
            bool enableNrrForOutboundEncodedMessages = default;
            bool enableNrrForOutboundDecodedMessages = default;
            bool enableNrrForInboundMdn = default;
            Optional<string> sha2AlgorithmFormat = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("overrideGroupSigningCertificate"u8))
                {
                    overrideGroupSigningCertificate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("signingCertificateName"u8))
                {
                    signingCertificateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionCertificateName"u8))
                {
                    encryptionCertificateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableNRRForInboundEncodedMessages"u8))
                {
                    enableNrrForInboundEncodedMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForInboundDecodedMessages"u8))
                {
                    enableNrrForInboundDecodedMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForOutboundMDN"u8))
                {
                    enableNrrForOutboundMdn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForOutboundEncodedMessages"u8))
                {
                    enableNrrForOutboundEncodedMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForOutboundDecodedMessages"u8))
                {
                    enableNrrForOutboundDecodedMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableNRRForInboundMDN"u8))
                {
                    enableNrrForInboundMdn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sha2AlgorithmFormat"u8))
                {
                    sha2AlgorithmFormat = property.Value.GetString();
                    continue;
                }
            }
            return new AS2SecuritySettings(overrideGroupSigningCertificate, signingCertificateName.Value, encryptionCertificateName.Value, enableNrrForInboundEncodedMessages, enableNrrForInboundDecodedMessages, enableNrrForOutboundMdn, enableNrrForOutboundEncodedMessages, enableNrrForOutboundDecodedMessages, enableNrrForInboundMdn, sha2AlgorithmFormat.Value);
        }
    }
}
