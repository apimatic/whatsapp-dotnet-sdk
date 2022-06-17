// <copyright file="HeaderTypeEnum.cs" company="APIMatic">
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
    /// HeaderTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HeaderTypeEnum
    {
        /// <summary>
        ///Used for List Messages and Reply Buttons.
        /// Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        ///Used for Reply Buttons.
        /// Document.
        /// </summary>
        [EnumMember(Value = "document")]
        Document,

        /// <summary>
        ///Used for Reply Buttons.
        /// Image.
        /// </summary>
        [EnumMember(Value = "image")]
        Image,

        /// <summary>
        ///Used for Reply Buttons.
        /// Video.
        /// </summary>
        [EnumMember(Value = "video")]
        Video
    }
}