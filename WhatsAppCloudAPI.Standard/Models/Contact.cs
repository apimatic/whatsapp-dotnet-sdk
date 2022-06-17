// <copyright file="Contact.cs" company="APIMatic">
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
    /// Contact.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="emails">emails.</param>
        /// <param name="org">org.</param>
        /// <param name="phones">phones.</param>
        /// <param name="urls">urls.</param>
        public Contact(
            Models.Name name,
            List<Models.Address> addresses = null,
            string birthday = "YYYY-MM-DD formatted string.",
            List<Models.EmailObject> emails = null,
            Models.Org org = null,
            List<Models.PhoneObject> phones = null,
            List<Models.UrlObject> urls = null)
        {
            this.Addresses = addresses;
            this.Birthday = birthday;
            this.Emails = emails;
            this.Name = name;
            this.Org = org;
            this.Phones = phones;
            this.Urls = urls;
        }

        /// <summary>
        /// Full contact address(es)
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets Birthday.
        /// </summary>
        [JsonProperty("birthday", NullValueHandling = NullValueHandling.Ignore)]
        public string Birthday { get; set; }

        /// <summary>
        /// Contact email address(es)
        /// </summary>
        [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EmailObject> Emails { get; set; }

        /// <summary>
        /// Full contact name
        /// </summary>
        [JsonProperty("name")]
        public Models.Name Name { get; set; }

        /// <summary>
        /// Contact organization information
        /// </summary>
        [JsonProperty("org", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Org Org { get; set; }

        /// <summary>
        /// Contact phone number(s)
        /// </summary>
        [JsonProperty("phones", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PhoneObject> Phones { get; set; }

        /// <summary>
        /// Contact URL(s)
        /// </summary>
        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UrlObject> Urls { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contact : ({string.Join(", ", toStringOutput)})";
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

            return obj is Contact other &&
                ((this.Addresses == null && other.Addresses == null) || (this.Addresses?.Equals(other.Addresses) == true)) &&
                ((this.Birthday == null && other.Birthday == null) || (this.Birthday?.Equals(other.Birthday) == true)) &&
                ((this.Emails == null && other.Emails == null) || (this.Emails?.Equals(other.Emails) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Org == null && other.Org == null) || (this.Org?.Equals(other.Org) == true)) &&
                ((this.Phones == null && other.Phones == null) || (this.Phones?.Equals(other.Phones) == true)) &&
                ((this.Urls == null && other.Urls == null) || (this.Urls?.Equals(other.Urls) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Addresses = {(this.Addresses == null ? "null" : $"[{string.Join(", ", this.Addresses)} ]")}");
            toStringOutput.Add($"this.Birthday = {(this.Birthday == null ? "null" : this.Birthday == string.Empty ? "" : this.Birthday)}");
            toStringOutput.Add($"this.Emails = {(this.Emails == null ? "null" : $"[{string.Join(", ", this.Emails)} ]")}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Org = {(this.Org == null ? "null" : this.Org.ToString())}");
            toStringOutput.Add($"this.Phones = {(this.Phones == null ? "null" : $"[{string.Join(", ", this.Phones)} ]")}");
            toStringOutput.Add($"this.Urls = {(this.Urls == null ? "null" : $"[{string.Join(", ", this.Urls)} ]")}");
        }
    }
}