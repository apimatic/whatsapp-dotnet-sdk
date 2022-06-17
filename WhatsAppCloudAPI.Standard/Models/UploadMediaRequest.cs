// <copyright file="UploadMediaRequest.cs" company="APIMatic">
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
    /// UploadMediaRequest.
    /// </summary>
    public class UploadMediaRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest"/> class.
        /// </summary>
        public UploadMediaRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadMediaRequest"/> class.
        /// </summary>
        /// <param name="messagingProduct">messaging_product.</param>
        /// <param name="file">file.</param>
        /// <param name="type">type.</param>
        public UploadMediaRequest(
            string messagingProduct,
            string file,
            string type)
        {
            this.MessagingProduct = messagingProduct;
            this.File = file;
            this.Type = type;
        }

        /// <summary>
        /// Messaging service used for the request. In this case, use whatsapp.
        /// </summary>
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        /// <summary>
        /// Path to the file stored in your local directory. For example: "@/local/path/file.jpg".
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }

        /// <summary>
        /// Type of media file being uploaded. See Supported Media Types for more information.
        ///  Supported options for images are: `image/jpeg`, `image/png`
        ///  Supported options for documents are: `text/plain`, `application/pdf`, `application/vnd.ms-powerpoint`, `application/msword`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`
        /// Supported options for audio are: `audio/aac`, `audio/mp4`, `audio/mpeg`, `audio/amr`, `audio/ogg`, `audio/opus`
        /// Supported options for video are: `video/mp4`, `video/3gp`
        /// Supported options for stickers are: `image/webp`
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UploadMediaRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is UploadMediaRequest other &&
                ((this.MessagingProduct == null && other.MessagingProduct == null) || (this.MessagingProduct?.Equals(other.MessagingProduct) == true)) &&
                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MessagingProduct = {(this.MessagingProduct == null ? "null" : this.MessagingProduct == string.Empty ? "" : this.MessagingProduct)}");
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File == string.Empty ? "" : this.File)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
        }
    }
}