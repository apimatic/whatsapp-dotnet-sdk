// <copyright file="BusinessProfile.cs" company="APIMatic">
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
    /// BusinessProfile.
    /// </summary>
    public class BusinessProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessProfile"/> class.
        /// </summary>
        public BusinessProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessProfile"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="messagingProduct">messaging_product.</param>
        /// <param name="address">address.</param>
        /// <param name="description">description.</param>
        /// <param name="vertical">vertical.</param>
        /// <param name="email">email.</param>
        /// <param name="websites">websites.</param>
        /// <param name="profilePictureUrl">profile_picture_url.</param>
        public BusinessProfile(
            string id,
            string messagingProduct,
            string address,
            string description,
            Models.VerticalEnum? vertical = null,
            string email = null,
            List<string> websites = null,
            string profilePictureUrl = null)
        {
            this.Id = id;
            this.MessagingProduct = messagingProduct;
            this.Address = address;
            this.Description = description;
            this.Vertical = vertical;
            this.Email = email;
            this.Websites = websites;
            this.ProfilePictureUrl = profilePictureUrl;
        }

        /// <summary>
        /// ID of the business profile object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The messaging service used for the request. Always set it to "whatsapp" if you are using the WhatsApp Business API.
        /// </summary>
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        /// <summary>
        /// Address of the business.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Description of the business.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Industry of the business. This can be either an empty string or one of the accepted values.
        /// </summary>
        [JsonProperty("vertical", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.VerticalEnum? Vertical { get; set; }

        /// <summary>
        /// The contact email address (in valid email format) of the business.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// The URLs associated with the business. For instance, a website, Facebook Page, or Instagram. You must include the http:// or https:// portion of the URL.
        /// </summary>
        [JsonProperty("websites", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Websites { get; set; }

        /// <summary>
        /// URL of the profile picture generated from a call to the Resumable Upload API.
        /// </summary>
        [JsonProperty("profile_picture_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfilePictureUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BusinessProfile : ({string.Join(", ", toStringOutput)})";
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

            return obj is BusinessProfile other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.MessagingProduct == null && other.MessagingProduct == null) || (this.MessagingProduct?.Equals(other.MessagingProduct) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Vertical == null && other.Vertical == null) || (this.Vertical?.Equals(other.Vertical) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Websites == null && other.Websites == null) || (this.Websites?.Equals(other.Websites) == true)) &&
                ((this.ProfilePictureUrl == null && other.ProfilePictureUrl == null) || (this.ProfilePictureUrl?.Equals(other.ProfilePictureUrl) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.MessagingProduct = {(this.MessagingProduct == null ? "null" : this.MessagingProduct == string.Empty ? "" : this.MessagingProduct)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address == string.Empty ? "" : this.Address)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.Vertical = {(this.Vertical == null ? "null" : this.Vertical.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Websites = {(this.Websites == null ? "null" : $"[{string.Join(", ", this.Websites)} ]")}");
            toStringOutput.Add($"this.ProfilePictureUrl = {(this.ProfilePictureUrl == null ? "null" : this.ProfilePictureUrl == string.Empty ? "" : this.ProfilePictureUrl)}");
        }
    }
}