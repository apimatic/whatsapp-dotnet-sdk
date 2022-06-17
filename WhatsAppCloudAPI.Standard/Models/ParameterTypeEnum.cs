// <copyright file="ParameterTypeEnum.cs" company="APIMatic">
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
    /// ParameterTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParameterTypeEnum
    {
        /// <summary>
        /// Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Currency.
        /// </summary>
        [EnumMember(Value = "currency")]
        Currency,

        /// <summary>
        /// DateTime.
        /// </summary>
        [EnumMember(Value = "date_time")]
        DateTime,

        /// <summary>
        /// Image.
        /// </summary>
        [EnumMember(Value = "image")]
        Image,

        /// <summary>
        /// Document.
        /// </summary>
        [EnumMember(Value = "document")]
        Document,

        /// <summary>
        /// Video.
        /// </summary>
        [EnumMember(Value = "video")]
        Video
    }
}