// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.DotNet.ImageBuilder.Model
{
    public class Manifest
    {
        public string ReadmePath { get; set; }
        public string Registry { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Repo[] Repos { get; set; }

        public IDictionary<string, string> Variables { get; set; }

        public Manifest()
        {
        }
    }
}
