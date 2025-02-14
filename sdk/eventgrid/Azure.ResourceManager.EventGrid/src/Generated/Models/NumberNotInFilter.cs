// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> NumberNotIn Filter. </summary>
    public partial class NumberNotInFilter : EventGridFilter
    {
        /// <summary> Initializes a new instance of <see cref="NumberNotInFilter"/>. </summary>
        public NumberNotInFilter()
        {
            Values = new ChangeTrackingList<double>();
            OperatorType = FilterOperatorType.NumberNotIn;
        }

        /// <summary> Initializes a new instance of <see cref="NumberNotInFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="values"> The set of filter values. </param>
        internal NumberNotInFilter(FilterOperatorType operatorType, string key, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<double> values) : base(operatorType, key, serializedAdditionalRawData)
        {
            Values = values;
            OperatorType = operatorType;
        }

        /// <summary> The set of filter values. </summary>
        public IList<double> Values { get; }
    }
}
