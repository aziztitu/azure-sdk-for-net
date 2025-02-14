// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.FormRecognizer;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted selection mark. </summary>
    internal partial class SelectionMark
    {
        /// <summary> Initializes a new instance of <see cref="SelectionMark"/>. </summary>
        /// <param name="boundingBox"> Bounding box of the selection mark. </param>
        /// <param name="confidence"> Confidence value. </param>
        /// <param name="state"> State of the selection mark. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="boundingBox"/> is null. </exception>
        internal SelectionMark(IEnumerable<float> boundingBox, float confidence, SelectionMarkState state)
        {
            Argument.AssertNotNull(boundingBox, nameof(boundingBox));

            BoundingBox = boundingBox.ToList();
            Confidence = confidence;
            State = state;
        }

        /// <summary> Initializes a new instance of <see cref="SelectionMark"/>. </summary>
        /// <param name="boundingBox"> Bounding box of the selection mark. </param>
        /// <param name="confidence"> Confidence value. </param>
        /// <param name="state"> State of the selection mark. </param>
        internal SelectionMark(IReadOnlyList<float> boundingBox, float confidence, SelectionMarkState state)
        {
            BoundingBox = boundingBox;
            Confidence = confidence;
            State = state;
        }

        /// <summary> Bounding box of the selection mark. </summary>
        public IReadOnlyList<float> BoundingBox { get; }
        /// <summary> Confidence value. </summary>
        public float Confidence { get; }
        /// <summary> State of the selection mark. </summary>
        public SelectionMarkState State { get; }
    }
}
