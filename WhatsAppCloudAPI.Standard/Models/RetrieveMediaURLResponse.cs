// <copyright file="RetrieveMediaURLResponse.cs" company="APIMatic">
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
    /// RetrieveMediaURLResponse.
    /// </summary>
    public class RetrieveMediaURLResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveMediaURLResponse"/> class.
        /// </summary>
        public RetrieveMediaURLResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveMediaURLResponse"/> class.
        /// </summary>
        /// <param name="messagingProduct">messaging_product.</param>
        /// <param name="url">url.</param>
        /// <param name="mimeType">mime_type.</param>
        /// <param name="sha256">sha256.</param>
        /// <param name="fileSize">file_size.</param>
        /// <param name="id">id.</param>
        public RetrieveMediaURLResponse(
            string messagingProduct,
            string url,
            string mimeType,
            string sha256,
            string fileSize,
            string id)
        {
            this.MessagingProduct = messagingProduct;
            this.Url = url;
            this.MimeType = mimeType;
            this.Sha256 = sha256;
            this.FileSize = fileSize;
            this.Id = id;
        }

        /// <summary>
        /// Gets or sets MessagingProduct.
        /// </summary>
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets MimeType.
        /// </summary>
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets Sha256.
        /// </summary>
        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        /// <summary>
        /// Gets or sets FileSize.
        /// </summary>
        [JsonProperty("file_size")]
        public string FileSize { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RetrieveMediaURLResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is RetrieveMediaURLResponse other &&
                ((this.MessagingProduct == null && other.MessagingProduct == null) || (this.MessagingProduct?.Equals(other.MessagingProduct) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.MimeType == null && other.MimeType == null) || (this.MimeType?.Equals(other.MimeType) == true)) &&
                ((this.Sha256 == null && other.Sha256 == null) || (this.Sha256?.Equals(other.Sha256) == true)) &&
                ((this.FileSize == null && other.FileSize == null) || (this.FileSize?.Equals(other.FileSize) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MessagingProduct = {(this.MessagingProduct == null ? "null" : this.MessagingProduct == string.Empty ? "" : this.MessagingProduct)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.MimeType = {(this.MimeType == null ? "null" : this.MimeType == string.Empty ? "" : this.MimeType)}");
            toStringOutput.Add($"this.Sha256 = {(this.Sha256 == null ? "null" : this.Sha256 == string.Empty ? "" : this.Sha256)}");
            toStringOutput.Add($"this.FileSize = {(this.FileSize == null ? "null" : this.FileSize == string.Empty ? "" : this.FileSize)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
        }
    }
}