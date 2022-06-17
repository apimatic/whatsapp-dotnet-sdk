// <copyright file="MessageTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace WhatsAppCloudAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using WhatsAppCloudAPI.Standard;
    using WhatsAppCloudAPI.Standard.Utilities;

    /// <summary>
    /// MessageTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageTypeEnum
    {
        /// <summary>
        /// Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Audio.
        /// </summary>
        [EnumMember(Value = "audio")]
        Audio,

        /// <summary>
        /// Contacts.
        /// </summary>
        [EnumMember(Value = "contacts")]
        Contacts,

        /// <summary>
        /// Document.
        /// </summary>
        [EnumMember(Value = "document")]
        Document,

        /// <summary>
        /// Image.
        /// </summary>
        [EnumMember(Value = "image")]
        Image,

        /// <summary>
        /// Interactive.
        /// </summary>
        [EnumMember(Value = "interactive")]
        Interactive,

        /// <summary>
        /// Location.
        /// </summary>
        [EnumMember(Value = "location")]
        Location,

        /// <summary>
        /// Sticker.
        /// </summary>
        [EnumMember(Value = "sticker")]
        Sticker,

        /// <summary>
        /// Template.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,

        /// <summary>
        /// Video.
        /// </summary>
        [EnumMember(Value = "video")]
        Video
    }
}