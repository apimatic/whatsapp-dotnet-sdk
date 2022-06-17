// <copyright file="Text.cs" company="APIMatic">
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
    /// Text.
    /// </summary>
    public class Text
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Text"/> class.
        /// </summary>
        public Text()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Text"/> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="previewUrl">preview_url.</param>
        public Text(
            string body,
            bool? previewUrl = false)
        {
            this.Body = body;
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Required for text messages. The text of the text message which can contain URLs which begin with http:// or https:// and formatting. See available formatting options here. If you include URLs in your text and want to include a preview box in text messages (preview_url: true), make sure the URL starts with http:// or https:// —https:// URLs are preferred. You must include a hostname, since IP addresses will not be matched.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// By default, WhatsApp recognizes URLs and makes them clickable, but you can also include a preview box with more information about the link. Set this field to true if you want to include a URL preview box. The majority of the time, the receiver will see a URL they can click on when you send an URL, set preview_url to true, and provide a body object with a http or https link. URL previews are only rendered after one of the following has happened: The business has sent a message template to the user. The user initiates a conversation with a "click to chat" link. The user adds the business phone number to their address book and initiates a conversation.
        /// </summary>
        [JsonProperty("preview_url", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreviewUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Text : ({string.Join(", ", toStringOutput)})";
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

            return obj is Text other &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true)) &&
                ((this.PreviewUrl == null && other.PreviewUrl == null) || (this.PreviewUrl?.Equals(other.PreviewUrl) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body == string.Empty ? "" : this.Body)}");
            toStringOutput.Add($"this.PreviewUrl = {(this.PreviewUrl == null ? "null" : this.PreviewUrl.ToString())}");
        }
    }
}