// <copyright file="ComponentTypeEnum.cs" company="APIMatic">
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
    /// ComponentTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComponentTypeEnum
    {
        /// <summary>
        /// Header.
        /// </summary>
        [EnumMember(Value = "header")]
        Header,

        /// <summary>
        /// Body.
        /// </summary>
        [EnumMember(Value = "body")]
        Body,

        /// <summary>
        /// Button.
        /// </summary>
        [EnumMember(Value = "button")]
        Button
    }
}