// <copyright file="Org.cs" company="APIMatic">
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
    /// Org.
    /// </summary>
    public class Org
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Org"/> class.
        /// </summary>
        public Org()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Org"/> class.
        /// </summary>
        /// <param name="company">company.</param>
        /// <param name="department">department.</param>
        /// <param name="title">title.</param>
        public Org(
            string company = null,
            string department = null,
            string title = null)
        {
            this.Company = company;
            this.Department = department;
            this.Title = title;
        }

        /// <summary>
        /// Name of the contact's company.
        /// </summary>
        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        /// <summary>
        /// Name of the contact's department.
        /// </summary>
        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public string Department { get; set; }

        /// <summary>
        /// Contact's business title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Org : ({string.Join(", ", toStringOutput)})";
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

            return obj is Org other &&
                ((this.Company == null && other.Company == null) || (this.Company?.Equals(other.Company) == true)) &&
                ((this.Department == null && other.Department == null) || (this.Department?.Equals(other.Department) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Company = {(this.Company == null ? "null" : this.Company == string.Empty ? "" : this.Company)}");
            toStringOutput.Add($"this.Department = {(this.Department == null ? "null" : this.Department == string.Empty ? "" : this.Department)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
        }
    }
}