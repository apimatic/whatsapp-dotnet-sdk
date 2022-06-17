// <copyright file="ButtonParameter.cs" company="APIMatic">
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
    /// ButtonParameter.
    /// </summary>
    public class ButtonParameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonParameter"/> class.
        /// </summary>
        public ButtonParameter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonParameter"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="payload">payload.</param>
        /// <param name="text">text.</param>
        public ButtonParameter(
            Models.ButtonParameterTypeEnum type,
            string payload = null,
            string text = null)
        {
            this.Type = type;
            this.Payload = payload;
            this.Text = text;
        }

        /// <summary>
        /// Indicates the type of parameter for the button.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ButtonParameterTypeEnum Type { get; set; }

        /// <summary>
        /// Required for quick_reply buttons. Developer-defined payload that is returned when the button is clicked in addition to the display text on the button.
        /// </summary>
        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }

        /// <summary>
        /// Required for URL buttons. Developer-provided suffix that is appended to the predefined prefix URL in the template.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ButtonParameter : ({string.Join(", ", toStringOutput)})";
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

            return obj is ButtonParameter other &&
                this.Type.Equals(other.Type) &&
                ((this.Payload == null && other.Payload == null) || (this.Payload?.Equals(other.Payload) == true)) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Payload = {(this.Payload == null ? "null" : this.Payload == string.Empty ? "" : this.Payload)}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text == string.Empty ? "" : this.Text)}");
        }
    }
}