// <copyright file="InteractiveTypeEnum.cs" company="APIMatic">
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
    /// InteractiveTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InteractiveTypeEnum
    {
        /// <summary>
        /// List.
        /// </summary>
        [EnumMember(Value = "list")]
        List,

        /// <summary>
        /// Button.
        /// </summary>
        [EnumMember(Value = "button")]
        Button
    }
}