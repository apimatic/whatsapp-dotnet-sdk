// <copyright file="ResponseContact.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace WhatsAppCloudAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using WhatsAppCloudAPI.Standard;
    using WhatsAppCloudAPI.Standard.Utilities;

    /// <summary>
    /// ResponseContact.
    /// </summary>
    public class ResponseContact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseContact"/> class.
        /// </summary>
        public ResponseContact()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseContact"/> class.
        /// </summary>
        /// <param name="input">input.</param>
        /// <param name="waId">wa_id.</param>
        public ResponseContact(
            string input,
            string waId)
        {
            this.Input = input;
            this.WaId = waId;
        }

        /// <summary>
        /// Gets or sets Input.
        /// </summary>
        [JsonProperty("input")]
        public string Input { get; set; }

        /// <summary>
        /// Gets or sets WaId.
        /// </summary>
        [JsonProperty("wa_id")]
        public string WaId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseContact : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is ResponseContact other &&
                ((this.Input == null && other.Input == null) || (this.Input?.Equals(other.Input) == true)) &&
                ((this.WaId == null && other.WaId == null) || (this.WaId?.Equals(other.WaId) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Input = {(this.Input == null ? "null" : this.Input == string.Empty ? "" : this.Input)}");
            toStringOutput.Add($"this.WaId = {(this.WaId == null ? "null" : this.WaId == string.Empty ? "" : this.WaId)}");
        }
    }
}