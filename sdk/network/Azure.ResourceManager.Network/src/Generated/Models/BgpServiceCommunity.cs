// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Service Community Properties. </summary>
    public partial class BgpServiceCommunity : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="BgpServiceCommunity"/>. </summary>
        public BgpServiceCommunity()
        {
            BgpCommunities = new ChangeTrackingList<BgpCommunity>();
        }

        /// <summary> Initializes a new instance of <see cref="BgpServiceCommunity"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="serviceName"> The name of the bgp community. e.g. Skype. </param>
        /// <param name="bgpCommunities"> A list of bgp communities. </param>
        internal BgpServiceCommunity(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, string serviceName, IList<BgpCommunity> bgpCommunities) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ServiceName = serviceName;
            BgpCommunities = bgpCommunities;
        }

        /// <summary> The name of the bgp community. e.g. Skype. </summary>
        public string ServiceName { get; set; }
        /// <summary> A list of bgp communities. </summary>
        public IList<BgpCommunity> BgpCommunities { get; }
    }
}
