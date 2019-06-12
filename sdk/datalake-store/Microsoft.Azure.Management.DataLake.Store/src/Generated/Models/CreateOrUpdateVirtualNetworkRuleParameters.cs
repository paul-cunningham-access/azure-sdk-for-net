// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters used to create a new virtual network rule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CreateOrUpdateVirtualNetworkRuleParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateOrUpdateVirtualNetworkRuleParameters class.
        /// </summary>
        public CreateOrUpdateVirtualNetworkRuleParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateOrUpdateVirtualNetworkRuleParameters class.
        /// </summary>
        /// <param name="subnetId">The resource identifier for the
        /// subnet.</param>
        public CreateOrUpdateVirtualNetworkRuleParameters(string subnetId)
        {
            SubnetId = subnetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource identifier for the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SubnetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubnetId");
            }
        }
    }
}