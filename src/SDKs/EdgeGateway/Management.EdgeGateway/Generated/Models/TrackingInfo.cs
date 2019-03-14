// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Tracking courier information.
    /// </summary>
    public partial class TrackingInfo
    {
        /// <summary>
        /// Initializes a new instance of the TrackingInfo class.
        /// </summary>
        public TrackingInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrackingInfo class.
        /// </summary>
        /// <param name="serialNumber">Serial number of the device being
        /// tracked.</param>
        /// <param name="carrierName">Name of the carrier used in the
        /// delivery.</param>
        /// <param name="trackingId">Tracking ID of the shipment.</param>
        /// <param name="trackingUrl">Tracking URL of the shipment.</param>
        public TrackingInfo(string serialNumber = default(string), string carrierName = default(string), string trackingId = default(string), string trackingUrl = default(string))
        {
            SerialNumber = serialNumber;
            CarrierName = carrierName;
            TrackingId = trackingId;
            TrackingUrl = trackingUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets serial number of the device being tracked.
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets name of the carrier used in the delivery.
        /// </summary>
        [JsonProperty(PropertyName = "carrierName")]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or sets tracking ID of the shipment.
        /// </summary>
        [JsonProperty(PropertyName = "trackingId")]
        public string TrackingId { get; set; }

        /// <summary>
        /// Gets or sets tracking URL of the shipment.
        /// </summary>
        [JsonProperty(PropertyName = "trackingUrl")]
        public string TrackingUrl { get; set; }

    }
}