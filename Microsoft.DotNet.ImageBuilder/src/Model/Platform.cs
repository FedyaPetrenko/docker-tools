// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;

namespace Microsoft.DotNet.ImageBuilder.Model
{
    public class Platform
    {
        [DefaultValue(Architecture.AMD64)]
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public Architecture Architecture { get; set; }

        public IDictionary<string, string> BuildArgs { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Dockerfile { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(Required = Required.Always)]
        public OS OS { get; set; }

        public string OsVersion { get; set; }

        [JsonProperty(Required = Required.Always)]
        public IDictionary<string, Tag> Tags { get; set; }

        public string Variant { get; set; }

        public Platform()
        {
        }
    }
}
