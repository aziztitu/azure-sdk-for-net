// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Operation status for the operation. </summary>
    public partial class OperationResult
    {
        /// <summary> Initializes a new instance of <see cref="OperationResult"/>. </summary>
        internal OperationResult()
        {
            Details = new ChangeTrackingList<CloudError>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationResult"/>. </summary>
        /// <param name="status"> Operation status. </param>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="target"> Property name/path in request associated with error. </param>
        /// <param name="details"> Array with additional error details. </param>
        internal OperationResult(string status, string code, string message, string target, IReadOnlyList<CloudError> details)
        {
            Status = status;
            Code = code;
            Message = message;
            Target = target;
            Details = details;
        }

        /// <summary> Operation status. </summary>
        public string Status { get; }
        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Property name/path in request associated with error. </summary>
        public string Target { get; }
        /// <summary> Array with additional error details. </summary>
        public IReadOnlyList<CloudError> Details { get; }
    }
}
