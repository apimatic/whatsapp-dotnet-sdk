// <copyright file="Currency.cs" company="APIMatic">
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
    /// Currency.
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class.
        /// </summary>
        public Currency()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Currency"/> class.
        /// </summary>
        /// <param name="fallbackValue">fallback_value.</param>
        /// <param name="code">code.</param>
        /// <param name="amount1000">amount_1000.</param>
        public Currency(
            string fallbackValue,
            string code,
            int amount1000)
        {
            this.FallbackValue = fallbackValue;
            this.Code = code;
            this.Amount1000 = amount1000;
        }

        /// <summary>
        /// Default text if localization fails.
        /// </summary>
        [JsonProperty("fallback_value")]
        public string FallbackValue { get; set; }

        /// <summary>
        /// Currency code as defined in ISO 4217.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Amount multiplied by 1000.
        /// </summary>
        [JsonProperty("amount_1000")]
        public int Amount1000 { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Currency : ({string.Join(", ", toStringOutput)})";
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

            return obj is Currency other &&
                ((this.FallbackValue == null && other.FallbackValue == null) || (this.FallbackValue?.Equals(other.FallbackValue) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                this.Amount1000.Equals(other.Amount1000);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FallbackValue = {(this.FallbackValue == null ? "null" : this.FallbackValue == string.Empty ? "" : this.FallbackValue)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Amount1000 = {this.Amount1000}");
        }
    }
}