// <copyright file="ButtonParameterTypeEnum.cs" company="APIMatic">
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
    /// ButtonParameterTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ButtonParameterTypeEnum
    {
        /// <summary>
        /// Payload.
        /// </summary>
        [EnumMember(Value = "payload")]
        Payload,

        /// <summary>
        /// Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text
    }
}