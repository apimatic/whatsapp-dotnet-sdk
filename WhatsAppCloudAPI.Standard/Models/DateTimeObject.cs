// <copyright file="DateTimeObject.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace WhatsAppCloudAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using WhatsAppCloudAPI.Standard;
    using WhatsAppCloudAPI.Standard.Utilities;

    /// <summary>
    /// DateTimeObject.
    /// </summary>
    public class DateTimeObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeObject"/> class.
        /// </summary>
        public DateTimeObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeObject"/> class.
        /// </summary>
        /// <param name="fallbackValue">fallback_value.</param>
        /// <param name="dayOfWeek">day_of_week.</param>
        /// <param name="year">year.</param>
        /// <param name="month">month.</param>
        /// <param name="dayOfMonth">day_of_month.</param>
        /// <param name="hour">hour.</param>
        /// <param name="minute">minute.</param>
        /// <param name="calendar">calendar.</param>
        public DateTimeObject(
            string fallbackValue,
            int? dayOfWeek = null,
            int? year = null,
            int? month = null,
            int? dayOfMonth = null,
            int? hour = null,
            int? minute = null,
            string calendar = null)
        {
            this.FallbackValue = fallbackValue;
            this.DayOfWeek = dayOfWeek;
            this.Year = year;
            this.Month = month;
            this.DayOfMonth = dayOfMonth;
            this.Hour = hour;
            this.Minute = minute;
            this.Calendar = calendar;
        }

        /// <summary>
        /// Default text. For Cloud API, we always use the fallback value, and we do not attempt to localize using other optional fields.
        /// </summary>
        [JsonProperty("fallback_value")]
        public string FallbackValue { get; set; }

        /// <summary>
        /// Gets or sets DayOfWeek.
        /// </summary>
        [JsonProperty("day_of_week", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets Year.
        /// </summary>
        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or sets Month.
        /// </summary>
        [JsonProperty("month", NullValueHandling = NullValueHandling.Ignore)]
        public int? Month { get; set; }

        /// <summary>
        /// Gets or sets DayOfMonth.
        /// </summary>
        [JsonProperty("day_of_month", NullValueHandling = NullValueHandling.Ignore)]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Gets or sets Hour.
        /// </summary>
        [JsonProperty("hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? Hour { get; set; }

        /// <summary>
        /// Gets or sets Minute.
        /// </summary>
        [JsonProperty("minute", NullValueHandling = NullValueHandling.Ignore)]
        public int? Minute { get; set; }

        /// <summary>
        /// Gets or sets Calendar.
        /// </summary>
        [JsonProperty("calendar", NullValueHandling = NullValueHandling.Ignore)]
        public string Calendar { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DateTimeObject : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is DateTimeObject other &&
                ((this.FallbackValue == null && other.FallbackValue == null) || (this.FallbackValue?.Equals(other.FallbackValue) == true)) &&
                ((this.DayOfWeek == null && other.DayOfWeek == null) || (this.DayOfWeek?.Equals(other.DayOfWeek) == true)) &&
                ((this.Year == null && other.Year == null) || (this.Year?.Equals(other.Year) == true)) &&
                ((this.Month == null && other.Month == null) || (this.Month?.Equals(other.Month) == true)) &&
                ((this.DayOfMonth == null && other.DayOfMonth == null) || (this.DayOfMonth?.Equals(other.DayOfMonth) == true)) &&
                ((this.Hour == null && other.Hour == null) || (this.Hour?.Equals(other.Hour) == true)) &&
                ((this.Minute == null && other.Minute == null) || (this.Minute?.Equals(other.Minute) == true)) &&
                ((this.Calendar == null && other.Calendar == null) || (this.Calendar?.Equals(other.Calendar) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FallbackValue = {(this.FallbackValue == null ? "null" : this.FallbackValue == string.Empty ? "" : this.FallbackValue)}");
            toStringOutput.Add($"this.DayOfWeek = {(this.DayOfWeek == null ? "null" : this.DayOfWeek.ToString())}");
            toStringOutput.Add($"this.Year = {(this.Year == null ? "null" : this.Year.ToString())}");
            toStringOutput.Add($"this.Month = {(this.Month == null ? "null" : this.Month.ToString())}");
            toStringOutput.Add($"this.DayOfMonth = {(this.DayOfMonth == null ? "null" : this.DayOfMonth.ToString())}");
            toStringOutput.Add($"this.Hour = {(this.Hour == null ? "null" : this.Hour.ToString())}");
            toStringOutput.Add($"this.Minute = {(this.Minute == null ? "null" : this.Minute.ToString())}");
            toStringOutput.Add($"this.Calendar = {(this.Calendar == null ? "null" : this.Calendar == string.Empty ? "" : this.Calendar)}");
        }
    }
}