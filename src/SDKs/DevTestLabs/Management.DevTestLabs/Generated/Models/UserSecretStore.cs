// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties of a user's secret store.
    /// </summary>
    public partial class UserSecretStore
    {
        /// <summary>
        /// Initializes a new instance of the UserSecretStore class.
        /// </summary>
        public UserSecretStore() { }

        /// <summary>
        /// Initializes a new instance of the UserSecretStore class.
        /// </summary>
        public UserSecretStore(string keyVaultUri = default(string), string keyVaultId = default(string))
        {
            KeyVaultUri = keyVaultUri;
            KeyVaultId = keyVaultId;
        }

        /// <summary>
        /// The URI of the user's Key vault.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultUri")]
        public string KeyVaultUri { get; set; }

        /// <summary>
        /// The ID of the user's Key vault.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultId")]
        public string KeyVaultId { get; set; }

    }
}