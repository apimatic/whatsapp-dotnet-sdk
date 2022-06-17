// <copyright file="SetTwoStepVerificationCodeRequest.cs" company="APIMatic">
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
    /// SetTwoStepVerificationCodeRequest.
    /// </summary>
    public class SetTwoStepVerificationCodeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetTwoStepVerificationCodeRequest"/> class.
        /// </summary>
        public SetTwoStepVerificationCodeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTwoStepVerificationCodeRequest"/> class.
        /// </summary>
        /// <param name="pin">pin.</param>
        public SetTwoStepVerificationCodeRequest(
            string pin)
        {
            this.Pin = pin;
        }

        /// <summary>
        /// Gets or sets Pin.
        /// </summary>
        [JsonProperty("pin")]
        public string Pin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SetTwoStepVerificationCodeRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is SetTwoStepVerificationCodeRequest other &&
                ((this.Pin == null && other.Pin == null) || (this.Pin?.Equals(other.Pin) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Pin = {(this.Pin == null ? "null" : this.Pin == string.Empty ? "" : this.Pin)}");
        }
    }
}