// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A time series result type. The discriminator value is always TimeSeries
    /// in this case.
    /// </summary>
    public partial class TimeSeriesElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeSeriesElement class.
        /// </summary>
        public TimeSeriesElement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeSeriesElement class.
        /// </summary>
        /// <param name="metadatavalues">the metadata values returned if
        /// $filter was specified in the call.</param>
        /// <param name="data">An array of data points representing the metric
        /// values.  This is only returned if a result type of data is
        /// specified.</param>
        public TimeSeriesElement(IList<MetadataValueInner> metadatavalues = default(IList<MetadataValueInner>), IList<MetricValue> data = default(IList<MetricValue>))
        {
            Metadatavalues = metadatavalues;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the metadata values returned if $filter was specified
        /// in the call.
        /// </summary>
        [JsonProperty(PropertyName = "metadatavalues")]
        public IList<MetadataValueInner> Metadatavalues { get; set; }

        /// <summary>
        /// Gets or sets an array of data points representing the metric
        /// values.  This is only returned if a result type of data is
        /// specified.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<MetricValue> Data { get; set; }

    }
}