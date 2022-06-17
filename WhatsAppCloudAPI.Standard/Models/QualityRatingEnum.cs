// <copyright file="QualityRatingEnum.cs" company="APIMatic">
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
    /// QualityRatingEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QualityRatingEnum
    {
        /// <summary>
        ///High Quality.
        /// Green.
        /// </summary>
        [EnumMember(Value = "GREEN")]
        Green,

        /// <summary>
        ///Medium Quality.
        /// Yellow.
        /// </summary>
        [EnumMember(Value = "YELLOW")]
        Yellow,

        /// <summary>
        ///Low Quality.
        /// Red.
        /// </summary>
        [EnumMember(Value = "RED")]
        Red,

        /// <summary>
        ///Quality has not been determined.
        /// NA.
        /// </summary>
        [EnumMember(Value = "NA")]
        NA
    }
}