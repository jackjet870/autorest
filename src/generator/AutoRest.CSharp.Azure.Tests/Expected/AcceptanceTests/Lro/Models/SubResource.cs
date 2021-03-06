// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro.Models
{
    using Azure;
    using AcceptanceTestsLro;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the SubResource class.
        /// </summary>
        public SubResource() { }

        /// <summary>
        /// Initializes a new instance of the SubResource class.
        /// </summary>
        /// <param name="id">Sub Resource Id</param>
        public SubResource(string id = default(string))
        {
            Id = id;
        }

        /// <summary>
        /// Gets sub Resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; protected set; }

    }
}

