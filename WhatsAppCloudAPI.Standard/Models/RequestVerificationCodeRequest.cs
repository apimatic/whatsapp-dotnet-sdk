// <copyright file="RequestVerificationCodeRequest.cs" company="APIMatic">
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
    /// RequestVerificationCodeRequest.
    /// </summary>
    public class RequestVerificationCodeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVerificationCodeRequest"/> class.
        /// </summary>
        public RequestVerificationCodeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVerificationCodeRequest"/> class.
        /// </summary>
        /// <param name="codeMethod">code_method.</param>
        /// <param name="locale">locale.</param>
        public RequestVerificationCodeRequest(
            Models.RequestVerificationCodeMethodEnum codeMethod,
            string locale)
        {
            this.CodeMethod = codeMethod;
            this.Locale = locale;
        }

        /// <summary>
        /// Chosen method for verification.
        /// </summary>
        [JsonProperty("code_method", ItemConverterType = typeof(StringEnumConverter))]
        public Models.RequestVerificationCodeMethodEnum CodeMethod { get; set; }

        /// <summary>
        /// Your locale. For example: "en_US".
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequestVerificationCodeRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is RequestVerificationCodeRequest other &&
                this.CodeMethod.Equals(other.CodeMethod) &&
                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CodeMethod = {this.CodeMethod}");
            toStringOutput.Add($"this.Locale = {(this.Locale == null ? "null" : this.Locale == string.Empty ? "" : this.Locale)}");
        }
    }
}