// <copyright file="Document.cs" company="APIMatic">
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
    /// Document.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class.
        /// </summary>
        public Document()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="link">link.</param>
        /// <param name="caption">caption.</param>
        /// <param name="filename">filename.</param>
        public Document(
            string id = null,
            string link = null,
            string caption = null,
            string filename = null)
        {
            this.Id = id;
            this.Link = link;
            this.Caption = caption;
            this.Filename = filename;
        }

        /// <summary>
        /// It is the media object ID. Required when you are not using a link.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The protocol and URL of the media to be sent. Use only with HTTP/HTTPS URLs. Required when you are not using an uploaded media ID.
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// Describes the specified document media.
        /// </summary>
        [JsonProperty("caption", NullValueHandling = NullValueHandling.Ignore)]
        public string Caption { get; set; }

        /// <summary>
        /// Describes the filename for the specific document.
        /// </summary>
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Document : ({string.Join(", ", toStringOutput)})";
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

            return obj is Document other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Link == null && other.Link == null) || (this.Link?.Equals(other.Link) == true)) &&
                ((this.Caption == null && other.Caption == null) || (this.Caption?.Equals(other.Caption) == true)) &&
                ((this.Filename == null && other.Filename == null) || (this.Filename?.Equals(other.Filename) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Link = {(this.Link == null ? "null" : this.Link == string.Empty ? "" : this.Link)}");
            toStringOutput.Add($"this.Caption = {(this.Caption == null ? "null" : this.Caption == string.Empty ? "" : this.Caption)}");
            toStringOutput.Add($"this.Filename = {(this.Filename == null ? "null" : this.Filename == string.Empty ? "" : this.Filename)}");
        }
    }
}