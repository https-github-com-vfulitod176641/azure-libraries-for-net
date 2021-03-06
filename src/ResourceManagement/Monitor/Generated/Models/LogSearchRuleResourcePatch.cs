// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The log search rule resource for patch operations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LogSearchRuleResourcePatch
    {
        /// <summary>
        /// Initializes a new instance of the LogSearchRuleResourcePatch class.
        /// </summary>
        public LogSearchRuleResourcePatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogSearchRuleResourcePatch class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="enabled">The flag which indicates whether the Log
        /// Search rule is enabled. Value should be true or false. Possible
        /// values include: 'true', 'false'</param>
        public LogSearchRuleResourcePatch(IDictionary<string, string> tags = default(IDictionary<string, string>), Enabled enabled = default(Enabled))
        {
            Tags = tags;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the flag which indicates whether the Log Search rule
        /// is enabled. Value should be true or false. Possible values include:
        /// 'true', 'false'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public Enabled Enabled { get; set; }

    }
}
