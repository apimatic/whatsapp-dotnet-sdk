// <copyright file="Audio.cs" company="APIMatic">
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
    /// Audio.
    /// </summary>
    public class Audio
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Audio"/> class.
        /// </summary>
        public Audio()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Audio"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="link">link.</param>
        public Audio(
            string id = null,
            string link = null)
        {
            this.Id = id;
            this.Link = link;
        }

        /// <summary>
        /// The media object ID. Required when you are not using a link.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The protocol and URL of the media to be sent. Use only with HTTP/HTTPS URLs. Required when you are not using an uploaded media ID.
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Audio : ({string.Join(", ", toStringOutput)})";
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

            return obj is Audio other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Link == null && other.Link == null) || (this.Link?.Equals(other.Link) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Link = {(this.Link == null ? "null" : this.Link == string.Empty ? "" : this.Link)}");
        }
    }
}