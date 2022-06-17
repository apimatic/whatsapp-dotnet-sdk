// <copyright file="Interactive.cs" company="APIMatic">
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
    /// Interactive.
    /// </summary>
    public class Interactive
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Interactive"/> class.
        /// </summary>
        public Interactive()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interactive"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="body">body.</param>
        /// <param name="type">type.</param>
        /// <param name="footer">footer.</param>
        /// <param name="header">header.</param>
        public Interactive(
            Models.Action action,
            Models.Body body,
            Models.InteractiveTypeEnum type,
            Models.Footer footer = null,
            Models.Header header = null)
        {
            this.Action = action;
            this.Body = body;
            this.Footer = footer;
            this.Header = header;
            this.Type = type;
        }

        /// <summary>
        /// Action you want the user to perform after reading the message.
        /// </summary>
        [JsonProperty("action")]
        public Models.Action Action { get; set; }

        /// <summary>
        /// The body of the message. Emojis and markdown are supported.
        /// </summary>
        [JsonProperty("body")]
        public Models.Body Body { get; set; }

        /// <summary>
        /// The footer of the message. Emojis and markdown are supported.
        /// </summary>
        [JsonProperty("footer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Footer Footer { get; set; }

        /// <summary>
        /// Header content displayed on top of a message.
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Header Header { get; set; }

        /// <summary>
        /// The type of interactive message you want to send.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.InteractiveTypeEnum Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Interactive : ({string.Join(", ", toStringOutput)})";
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

            return obj is Interactive other &&
                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true)) &&
                ((this.Footer == null && other.Footer == null) || (this.Footer?.Equals(other.Footer) == true)) &&
                ((this.Header == null && other.Header == null) || (this.Header?.Equals(other.Header) == true)) &&
                this.Type.Equals(other.Type);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action.ToString())}");
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body.ToString())}");
            toStringOutput.Add($"this.Footer = {(this.Footer == null ? "null" : this.Footer.ToString())}");
            toStringOutput.Add($"this.Header = {(this.Header == null ? "null" : this.Header.ToString())}");
            toStringOutput.Add($"this.Type = {this.Type}");
        }
    }
}