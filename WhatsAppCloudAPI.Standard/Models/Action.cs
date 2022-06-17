// <copyright file="Action.cs" company="APIMatic">
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
    /// Action.
    /// </summary>
    public class Action
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Action"/> class.
        /// </summary>
        public Action()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Action"/> class.
        /// </summary>
        /// <param name="button">button.</param>
        /// <param name="buttons">buttons.</param>
        /// <param name="sections">sections.</param>
        public Action(
            string button = null,
            List<Models.Button> buttons = null,
            List<Models.Section> sections = null)
        {
            this.Button = button;
            this.Buttons = buttons;
            this.Sections = sections;
        }

        /// <summary>
        /// Required for List Messages. Button content. It cannot be an empty string and must be unique within the message. Emojis are supported, markdown is not.
        /// </summary>
        [JsonProperty("button", NullValueHandling = NullValueHandling.Ignore)]
        public string Button { get; set; }

        /// <summary>
        /// Required for Reply Buttons. You can have up to 3 buttons. You cannot have leading or trailing spaces when setting the ID.
        /// </summary>
        [JsonProperty("buttons", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Button> Buttons { get; set; }

        /// <summary>
        /// Required for List Messages.
        /// </summary>
        [JsonProperty("sections", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Section> Sections { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Action : ({string.Join(", ", toStringOutput)})";
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

            return obj is Action other &&
                ((this.Button == null && other.Button == null) || (this.Button?.Equals(other.Button) == true)) &&
                ((this.Buttons == null && other.Buttons == null) || (this.Buttons?.Equals(other.Buttons) == true)) &&
                ((this.Sections == null && other.Sections == null) || (this.Sections?.Equals(other.Sections) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Button = {(this.Button == null ? "null" : this.Button == string.Empty ? "" : this.Button)}");
            toStringOutput.Add($"this.Buttons = {(this.Buttons == null ? "null" : $"[{string.Join(", ", this.Buttons)} ]")}");
            toStringOutput.Add($"this.Sections = {(this.Sections == null ? "null" : $"[{string.Join(", ", this.Sections)} ]")}");
        }
    }
}