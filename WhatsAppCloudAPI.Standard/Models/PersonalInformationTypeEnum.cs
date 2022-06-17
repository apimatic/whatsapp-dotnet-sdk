// <copyright file="PersonalInformationTypeEnum.cs" company="APIMatic">
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
    /// PersonalInformationTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonalInformationTypeEnum
    {
        /// <summary>
        /// HOME.
        /// </summary>
        [EnumMember(Value = "HOME")]
        HOME,

        /// <summary>
        /// WORK.
        /// </summary>
        [EnumMember(Value = "WORK")]
        WORK
    }
}