// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.MediaComposition;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary> An image input. </summary>
    public partial class ImageInput : MediaInput
    {
        /// <summary> Initializes a new instance of <see cref="ImageInput"/>. </summary>
        /// <param name="uri"> Url of the image file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public ImageInput(string uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            Kind = MediaInputType.Image;
        }

        /// <summary> Initializes a new instance of <see cref="ImageInput"/>. </summary>
        /// <param name="kind"> Kind of media input. </param>
        /// <param name="placeholderImageUri"> Image url to be used if participant has no video stream. </param>
        /// <param name="uri"> Url of the image file. </param>
        internal ImageInput(MediaInputType kind, string placeholderImageUri, string uri) : base(kind, placeholderImageUri)
        {
            Uri = uri;
            Kind = kind;
        }

        /// <summary> Url of the image file. </summary>
        public string Uri { get; set; }
    }
}
