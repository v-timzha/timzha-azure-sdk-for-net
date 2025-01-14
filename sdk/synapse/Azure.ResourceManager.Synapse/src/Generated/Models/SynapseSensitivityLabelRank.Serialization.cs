// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    internal static partial class SynapseSensitivityLabelRankExtensions
    {
        public static string ToSerialString(this SynapseSensitivityLabelRank value) => value switch
        {
            SynapseSensitivityLabelRank.None => "None",
            SynapseSensitivityLabelRank.Low => "Low",
            SynapseSensitivityLabelRank.Medium => "Medium",
            SynapseSensitivityLabelRank.High => "High",
            SynapseSensitivityLabelRank.Critical => "Critical",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSensitivityLabelRank value.")
        };

        public static SynapseSensitivityLabelRank ToSynapseSensitivityLabelRank(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return SynapseSensitivityLabelRank.None;
            if (string.Equals(value, "Low", StringComparison.InvariantCultureIgnoreCase)) return SynapseSensitivityLabelRank.Low;
            if (string.Equals(value, "Medium", StringComparison.InvariantCultureIgnoreCase)) return SynapseSensitivityLabelRank.Medium;
            if (string.Equals(value, "High", StringComparison.InvariantCultureIgnoreCase)) return SynapseSensitivityLabelRank.High;
            if (string.Equals(value, "Critical", StringComparison.InvariantCultureIgnoreCase)) return SynapseSensitivityLabelRank.Critical;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSensitivityLabelRank value.");
        }
    }
}
