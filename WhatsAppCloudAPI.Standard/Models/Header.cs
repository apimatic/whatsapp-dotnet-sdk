// <copyright file="Header.cs" company="APIMatic">
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
    /// Header.
    /// </summary>
    public class Header
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Header"/> class.
        /// </summary>
        public Header()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Header"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="text">text.</param>
        /// <param name="video">video.</param>
        /// <param name="image">image.</param>
        /// <param name="document">document.</param>
        public Header(
            Models.HeaderTypeEnum type,
            string text = null,
            Models.Video video = null,
            Models.Image image = null,
            Models.Document document = null)
        {
            this.Type = type;
            this.Text = text;
            this.Video = video;
            this.Image = image;
            this.Document = document;
        }

        /// <summary>
        /// The header type you would like to use.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.HeaderTypeEnum Type { get; set; }

        /// <summary>
        /// Required if type is set to text. Text for the header. Formatting allows emojis, but not markdown.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Required if type is set to video. Contains the media object for this video.
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Video Video { get; set; }

        /// <summary>
        /// Required if type is set to image. Contains the media object for this image.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Image Image { get; set; }

        /// <summary>
        /// Required if type is set to document. Contains the media object for this document.
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Document Document { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Header : ({string.Join(", ", toStringOutput)})";
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

            return obj is Header other &&
                this.Type.Equals(other.Type) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.Video == null && other.Video == null) || (this.Video?.Equals(other.Video) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
            toStringOutput.Add($"this.Video = {(this.Video == null ? "null" : this.Video.ToString())}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image.ToString())}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document.ToString())}");
        }
    }
}