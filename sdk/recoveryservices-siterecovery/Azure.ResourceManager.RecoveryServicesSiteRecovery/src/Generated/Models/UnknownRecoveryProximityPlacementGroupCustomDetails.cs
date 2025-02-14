// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownRecoveryProximityPlacementGroupCustomDetails. </summary>
    internal partial class UnknownRecoveryProximityPlacementGroupCustomDetails : RecoveryProximityPlacementGroupCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryProximityPlacementGroupCustomDetails"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRecoveryProximityPlacementGroupCustomDetails(string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(resourceType, serializedAdditionalRawData)
        {
            ResourceType = resourceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryProximityPlacementGroupCustomDetails"/> for deserialization. </summary>
        internal UnknownRecoveryProximityPlacementGroupCustomDetails()
        {
        }
    }
}
