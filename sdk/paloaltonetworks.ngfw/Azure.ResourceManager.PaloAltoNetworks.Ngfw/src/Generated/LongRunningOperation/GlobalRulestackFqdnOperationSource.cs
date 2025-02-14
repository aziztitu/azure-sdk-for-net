// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal class GlobalRulestackFqdnOperationSource : IOperationSource<GlobalRulestackFqdnResource>
    {
        private readonly ArmClient _client;

        internal GlobalRulestackFqdnOperationSource(ArmClient client)
        {
            _client = client;
        }

        GlobalRulestackFqdnResource IOperationSource<GlobalRulestackFqdnResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GlobalRulestackFqdnData.DeserializeGlobalRulestackFqdnData(document.RootElement);
            return new GlobalRulestackFqdnResource(_client, data);
        }

        async ValueTask<GlobalRulestackFqdnResource> IOperationSource<GlobalRulestackFqdnResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GlobalRulestackFqdnData.DeserializeGlobalRulestackFqdnData(document.RootElement);
            return new GlobalRulestackFqdnResource(_client, data);
        }
    }
}
