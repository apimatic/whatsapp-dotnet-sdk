// <copyright file="Parameter.cs" company="APIMatic">
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
    /// Parameter.
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class.
        /// </summary>
        public Parameter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parameter"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="text">text.</param>
        /// <param name="currency">currency.</param>
        /// <param name="dateTime">date_time.</param>
        /// <param name="image">image.</param>
        /// <param name="document">document.</param>
        /// <param name="video">video.</param>
        public Parameter(
            Models.ParameterTypeEnum type,
            string text = null,
            Models.Currency currency = null,
            Models.DateTimeObject dateTime = null,
            Models.Image image = null,
            Models.Document document = null,
            Models.Video video = null)
        {
            this.Type = type;
            this.Text = text;
            this.Currency = currency;
            this.DateTime = dateTime;
            this.Image = image;
            this.Document = document;
            this.Video = video;
        }

        /// <summary>
        /// Describes the parameter type. For text-based templates, the only supported parameter types are text, currency, date_time.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ParameterTypeEnum Type { get; set; }

        /// <summary>
        /// Required when type=text. The message’s text. For the header component, the character limit is 60 characters. For the body component, the character limit is 1024 characters.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Required when type=currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Currency Currency { get; set; }

        /// <summary>
        /// Required when type=date_time.
        /// </summary>
        [JsonProperty("date_time", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DateTimeObject DateTime { get; set; }

        /// <summary>
        /// Required when type=image.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Image Image { get; set; }

        /// <summary>
        /// Required when type=document. Only PDF documents are supported for media-based message templates.
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Document Document { get; set; }

        /// <summary>
        /// Required when type=video.
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Video Video { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Parameter : ({string.Join(", ", toStringOutput)})";
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

            return obj is Parameter other &&
                this.Type.Equals(other.Type) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.DateTime == null && other.DateTime == null) || (this.DateTime?.Equals(other.DateTime) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Video == null && other.Video == null) || (this.Video?.Equals(other.Video) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency.ToString())}");
            toStringOutput.Add($"this.DateTime = {(this.DateTime == null ? "null" : this.DateTime.ToString())}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image.ToString())}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document.ToString())}");
            toStringOutput.Add($"this.Video = {(this.Video == null ? "null" : this.Video.ToString())}");
        }
    }
}