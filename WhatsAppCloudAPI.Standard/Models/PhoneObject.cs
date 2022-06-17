// <copyright file="PhoneObject.cs" company="APIMatic">
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
    /// PhoneObject.
    /// </summary>
    public class PhoneObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneObject"/> class.
        /// </summary>
        public PhoneObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneObject"/> class.
        /// </summary>
        /// <param name="phone">phone.</param>
        /// <param name="waId">wa_id.</param>
        /// <param name="type">type.</param>
        public PhoneObject(
            string phone = null,
            string waId = null,
            Models.PhoneTypeEnum? type = null)
        {
            this.Phone = phone;
            this.WaId = waId;
            this.Type = type;
        }

        /// <summary>
        /// Automatically populated with the wa_id value as a formatted phone number.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// WhatsApp ID.
        /// </summary>
        [JsonProperty("wa_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WaId { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.PhoneTypeEnum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PhoneObject : ({string.Join(", ", toStringOutput)})";
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

            return obj is PhoneObject other &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.WaId == null && other.WaId == null) || (this.WaId?.Equals(other.WaId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone == string.Empty ? "" : this.Phone)}");
            toStringOutput.Add($"this.WaId = {(this.WaId == null ? "null" : this.WaId == string.Empty ? "" : this.WaId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}