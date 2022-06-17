// <copyright file="VerifyCodeRequest.cs" company="APIMatic">
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
    /// VerifyCodeRequest.
    /// </summary>
    public class VerifyCodeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCodeRequest"/> class.
        /// </summary>
        public VerifyCodeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCodeRequest"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        public VerifyCodeRequest(
            string code)
        {
            this.Code = code;
        }

        /// <summary>
        /// The code you received after calling FROM_PHONE_NUMBER_ID/request_code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VerifyCodeRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is VerifyCodeRequest other &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
        }
    }
}