// <copyright file="SendMessageResponse.cs" company="APIMatic">
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
    /// SendMessageResponse.
    /// </summary>
    public class SendMessageResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageResponse"/> class.
        /// </summary>
        public SendMessageResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageResponse"/> class.
        /// </summary>
        /// <param name="messagingProduct">messaging_product.</param>
        /// <param name="contacts">contacts.</param>
        /// <param name="messages">messages.</param>
        public SendMessageResponse(
            string messagingProduct,
            List<Models.ResponseContact> contacts,
            List<Models.ResponseMessage> messages)
        {
            this.MessagingProduct = messagingProduct;
            this.Contacts = contacts;
            this.Messages = messages;
        }

        /// <summary>
        /// Gets or sets MessagingProduct.
        /// </summary>
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        /// <summary>
        /// Gets or sets Contacts.
        /// </summary>
        [JsonProperty("contacts")]
        public List<Models.ResponseContact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets Messages.
        /// </summary>
        [JsonProperty("messages")]
        public List<Models.ResponseMessage> Messages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SendMessageResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is SendMessageResponse other &&
                ((this.MessagingProduct == null && other.MessagingProduct == null) || (this.MessagingProduct?.Equals(other.MessagingProduct) == true)) &&
                ((this.Contacts == null && other.Contacts == null) || (this.Contacts?.Equals(other.Contacts) == true)) &&
                ((this.Messages == null && other.Messages == null) || (this.Messages?.Equals(other.Messages) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MessagingProduct = {(this.MessagingProduct == null ? "null" : this.MessagingProduct == string.Empty ? "" : this.MessagingProduct)}");
            toStringOutput.Add($"this.Contacts = {(this.Contacts == null ? "null" : $"[{string.Join(", ", this.Contacts)} ]")}");
            toStringOutput.Add($"this.Messages = {(this.Messages == null ? "null" : $"[{string.Join(", ", this.Messages)} ]")}");
        }
    }
}