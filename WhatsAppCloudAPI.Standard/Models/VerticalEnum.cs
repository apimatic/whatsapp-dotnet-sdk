// <copyright file="VerticalEnum.cs" company="APIMatic">
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
    /// VerticalEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VerticalEnum
    {
        /// <summary>
        /// UNDEFINED.
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED,

        /// <summary>
        /// OTHER.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER,

        /// <summary>
        /// AUTO.
        /// </summary>
        [EnumMember(Value = "AUTO")]
        AUTO,

        /// <summary>
        /// BEAUTY.
        /// </summary>
        [EnumMember(Value = "BEAUTY")]
        BEAUTY,

        /// <summary>
        /// APPAREL.
        /// </summary>
        [EnumMember(Value = "APPAREL")]
        APPAREL,

        /// <summary>
        /// EDU.
        /// </summary>
        [EnumMember(Value = "EDU")]
        EDU,

        /// <summary>
        /// ENTERTAIN.
        /// </summary>
        [EnumMember(Value = "ENTERTAIN")]
        ENTERTAIN,

        /// <summary>
        /// EVENTPLAN.
        /// </summary>
        [EnumMember(Value = "EVENT_PLAN")]
        EVENTPLAN,

        /// <summary>
        /// FINANCE.
        /// </summary>
        [EnumMember(Value = "FINANCE")]
        FINANCE,

        /// <summary>
        /// GROCERY.
        /// </summary>
        [EnumMember(Value = "GROCERY")]
        GROCERY,

        /// <summary>
        /// GOVT.
        /// </summary>
        [EnumMember(Value = "GOVT")]
        GOVT,

        /// <summary>
        /// HOTEL.
        /// </summary>
        [EnumMember(Value = "HOTEL")]
        HOTEL,

        /// <summary>
        /// HEALTH.
        /// </summary>
        [EnumMember(Value = "HEALTH")]
        HEALTH,

        /// <summary>
        /// NONPROFIT.
        /// </summary>
        [EnumMember(Value = "NONPROFIT")]
        NONPROFIT,

        /// <summary>
        /// PROFSERVICES.
        /// </summary>
        [EnumMember(Value = "PROF_SERVICES")]
        PROFSERVICES,

        /// <summary>
        /// RETAIL.
        /// </summary>
        [EnumMember(Value = "RETAIL")]
        RETAIL,

        /// <summary>
        /// TRAVEL.
        /// </summary>
        [EnumMember(Value = "TRAVEL")]
        TRAVEL,

        /// <summary>
        /// RESTAURANT.
        /// </summary>
        [EnumMember(Value = "RESTAURANT")]
        RESTAURANT,

        /// <summary>
        /// NOTABIZ.
        /// </summary>
        [EnumMember(Value = "NOT_A_BIZ")]
        NOTABIZ
    }
}