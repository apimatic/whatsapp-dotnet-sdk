// <copyright file="Message.cs" company="APIMatic">
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
    /// Message.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        public Message()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="messagingProduct">messaging_product.</param>
        /// <param name="to">to.</param>
        /// <param name="audio">audio.</param>
        /// <param name="contacts">contacts.</param>
        /// <param name="document">document.</param>
        /// <param name="image">image.</param>
        /// <param name="interactive">interactive.</param>
        /// <param name="location">location.</param>
        /// <param name="recipientType">recipient_type.</param>
        /// <param name="sticker">sticker.</param>
        /// <param name="template">template.</param>
        /// <param name="text">text.</param>
        /// <param name="type">type.</param>
        /// <param name="video">video.</param>
        public Message(
            string messagingProduct,
            string to,
            Models.Audio audio = null,
            List<Models.Contact> contacts = null,
            Models.Document document = null,
            Models.Image image = null,
            Models.Interactive interactive = null,
            Models.Location location = null,
            string recipientType = "individual",
            Models.Sticker sticker = null,
            Models.Template template = null,
            Models.Text text = null,
            Models.MessageTypeEnum? type = null,
            Models.Video video = null)
        {
            this.Audio = audio;
            this.Contacts = contacts;
            this.Document = document;
            this.Image = image;
            this.Interactive = interactive;
            this.Location = location;
            this.MessagingProduct = messagingProduct;
            this.RecipientType = recipientType;
            this.Sticker = sticker;
            this.Template = template;
            this.Text = text;
            this.To = to;
            this.Type = type;
            this.Video = video;
        }

        /// <summary>
        /// A media object containing audio. Required when type=audio.
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Audio Audio { get; set; }

        /// <summary>
        /// A contact object. Required when type=contacts.
        /// </summary>
        [JsonProperty("contacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Contact> Contacts { get; set; }

        /// <summary>
        /// A media object containing a document. Required when type=document.
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Document Document { get; set; }

        /// <summary>
        /// A media object containing an image. Required when type=image.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Image Image { get; set; }

        /// <summary>
        /// This option is used to send List Messages and Reply Buttons. The components of each interactive object generally follow a consistent pattern: header, body, footer, and action. Required when type=interactive.
        /// </summary>
        [JsonProperty("interactive", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Interactive Interactive { get; set; }

        /// <summary>
        /// A location object. Required when type=location.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Location Location { get; set; }

        /// <summary>
        /// Messaging service used for the request.
        /// </summary>
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        /// <summary>
        /// Currently, you can only send messages to individuals.
        /// </summary>
        [JsonProperty("recipient_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecipientType { get; set; }

        /// <summary>
        /// A media object containing a sticker. Currently, we support inbound both and outbound stickers: For outbound, we only support static third-party stickers. For inbound, we support all types of stickers. The sticker needs to be 512x512 pixels and the file’s size needs to be less than 100 KB. Required when type=sticker.
        /// </summary>
        [JsonProperty("sticker", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Sticker Sticker { get; set; }

        /// <summary>
        /// A template object. Required when type=template.
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Template Template { get; set; }

        /// <summary>
        /// Required for text messages.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Text Text { get; set; }

        /// <summary>
        /// WhatsApp ID or phone number for the person you want to send a message to.
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// The type of message you want to send.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.MessageTypeEnum? Type { get; set; }

        /// <summary>
        /// A media object containing a video. Required when type=video.
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Video Video { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Message : ({string.Join(", ", toStringOutput)})";
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

            return obj is Message other &&
                ((this.Audio == null && other.Audio == null) || (this.Audio?.Equals(other.Audio) == true)) &&
                ((this.Contacts == null && other.Contacts == null) || (this.Contacts?.Equals(other.Contacts) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Interactive == null && other.Interactive == null) || (this.Interactive?.Equals(other.Interactive) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.MessagingProduct == null && other.MessagingProduct == null) || (this.MessagingProduct?.Equals(other.MessagingProduct) == true)) &&
                ((this.RecipientType == null && other.RecipientType == null) || (this.RecipientType?.Equals(other.RecipientType) == true)) &&
                ((this.Sticker == null && other.Sticker == null) || (this.Sticker?.Equals(other.Sticker) == true)) &&
                ((this.Template == null && other.Template == null) || (this.Template?.Equals(other.Template) == true)) &&
                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true)) &&
                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Video == null && other.Video == null) || (this.Video?.Equals(other.Video) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Audio = {(this.Audio == null ? "null" : this.Audio.ToString())}");
            toStringOutput.Add($"this.Contacts = {(this.Contacts == null ? "null" : $"[{string.Join(", ", this.Contacts)} ]")}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document.ToString())}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image.ToString())}");
            toStringOutput.Add($"this.Interactive = {(this.Interactive == null ? "null" : this.Interactive.ToString())}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location.ToString())}");
            toStringOutput.Add($"this.MessagingProduct = {(this.MessagingProduct == null ? "null" : this.MessagingProduct == string.Empty ? "" : this.MessagingProduct)}");
            toStringOutput.Add($"this.RecipientType = {(this.RecipientType == null ? "null" : this.RecipientType == string.Empty ? "" : this.RecipientType)}");
            toStringOutput.Add($"this.Sticker = {(this.Sticker == null ? "null" : this.Sticker.ToString())}");
            toStringOutput.Add($"this.Template = {(this.Template == null ? "null" : this.Template.ToString())}");
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text.ToString())}");
            toStringOutput.Add($"this.To = {(this.To == null ? "null" : this.To == string.Empty ? "" : this.To)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Video = {(this.Video == null ? "null" : this.Video.ToString())}");
        }
    }
}