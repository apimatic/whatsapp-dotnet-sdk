// <copyright file="GetPhoneNumberByIDResponse.cs" company="APIMatic">
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
    /// GetPhoneNumberByIDResponse.
    /// </summary>
    public class GetPhoneNumberByIDResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberByIDResponse"/> class.
        /// </summary>
        public GetPhoneNumberByIDResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberByIDResponse"/> class.
        /// </summary>
        /// <param name="verifiedName">verified_name.</param>
        /// <param name="displayPhoneNumber">display_phone_number.</param>
        /// <param name="id">id.</param>
        /// <param name="qualityRating">quality_rating.</param>
        public GetPhoneNumberByIDResponse(
            string verifiedName,
            string displayPhoneNumber,
            string id,
            Models.QualityRatingEnum qualityRating)
        {
            this.VerifiedName = verifiedName;
            this.DisplayPhoneNumber = displayPhoneNumber;
            this.Id = id;
            this.QualityRating = qualityRating;
        }

        /// <summary>
        /// The verified name associated with the phone number.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }

        /// <summary>
        /// The string representation of the phone number.
        /// </summary>
        [JsonProperty("display_phone_number")]
        public string DisplayPhoneNumber { get; set; }

        /// <summary>
        /// The ID associated with the phone number.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The quality rating of the phone number based on how messages have been received by recipients in recent days.
        /// </summary>
        [JsonProperty("quality_rating", ItemConverterType = typeof(StringEnumConverter))]
        public Models.QualityRatingEnum QualityRating { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetPhoneNumberByIDResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetPhoneNumberByIDResponse other &&
                ((this.VerifiedName == null && other.VerifiedName == null) || (this.VerifiedName?.Equals(other.VerifiedName) == true)) &&
                ((this.DisplayPhoneNumber == null && other.DisplayPhoneNumber == null) || (this.DisplayPhoneNumber?.Equals(other.DisplayPhoneNumber) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.QualityRating.Equals(other.QualityRating);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.VerifiedName = {(this.VerifiedName == null ? "null" : this.VerifiedName == string.Empty ? "" : this.VerifiedName)}");
            toStringOutput.Add($"this.DisplayPhoneNumber = {(this.DisplayPhoneNumber == null ? "null" : this.DisplayPhoneNumber == string.Empty ? "" : this.DisplayPhoneNumber)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.QualityRating = {this.QualityRating}");
        }
    }
}