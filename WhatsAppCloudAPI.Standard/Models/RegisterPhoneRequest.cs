// <copyright file="RegisterPhoneRequest.cs" company="APIMatic">
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
    /// RegisterPhoneRequest.
    /// </summary>
    public class RegisterPhoneRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPhoneRequest"/> class.
        /// </summary>
        public RegisterPhoneRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPhoneRequest"/> class.
        /// </summary>
        /// <param name="messagingProduct">messaging_product.</param>
        /// <param name="pin">pin.</param>
        public RegisterPhoneRequest(
            string messagingProduct,
            string pin)
        {
            this.MessagingProduct = messagingProduct;
            this.Pin = pin;
        }

        /// <summary>
        /// Messaging service used. In this case, use "whatsapp".
        /// </summary>
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        /// <summary>
        /// A 6-digit pin you have previously set up - See Set Two-Step Verification.
        /// </summary>
        [JsonProperty("pin")]
        public string Pin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegisterPhoneRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is RegisterPhoneRequest other &&
                ((this.MessagingProduct == null && other.MessagingProduct == null) || (this.MessagingProduct?.Equals(other.MessagingProduct) == true)) &&
                ((this.Pin == null && other.Pin == null) || (this.Pin?.Equals(other.Pin) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MessagingProduct = {(this.MessagingProduct == null ? "null" : this.MessagingProduct == string.Empty ? "" : this.MessagingProduct)}");
            toStringOutput.Add($"this.Pin = {(this.Pin == null ? "null" : this.Pin == string.Empty ? "" : this.Pin)}");
        }
    }
}