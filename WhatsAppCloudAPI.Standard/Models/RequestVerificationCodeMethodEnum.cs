// <copyright file="RequestVerificationCodeMethodEnum.cs" company="APIMatic">
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
    /// RequestVerificationCodeMethodEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequestVerificationCodeMethodEnum
    {
        /// <summary>
        /// SMS.
        /// </summary>
        [EnumMember(Value = "SMS")]
        SMS,

        /// <summary>
        /// VOICE.
        /// </summary>
        [EnumMember(Value = "VOICE")]
        VOICE
    }
}