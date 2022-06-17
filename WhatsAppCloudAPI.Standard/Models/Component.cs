// <copyright file="Component.cs" company="APIMatic">
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
    /// Component.
    /// </summary>
    public class Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class.
        /// </summary>
        public Component()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="subType">sub_type.</param>
        /// <param name="index">index.</param>
        public Component(
            Models.ComponentTypeEnum type,
            object parameters,
            Models.SubTypeEnum? subType = null,
            string index = null)
        {
            this.Type = type;
            this.SubType = subType;
            this.Parameters = parameters;
            this.Index = index;
        }

        /// <summary>
        /// Describes the component type. For text-based templates, we only support the type=body.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ComponentTypeEnum Type { get; set; }

        /// <summary>
        /// Required when type=button. Not used for the other types. Type of button to create.
        /// </summary>
        [JsonProperty("sub_type", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubTypeEnum? SubType { get; set; }

        /// <summary>
        /// Required when type=button. Array of parameter objects with the content of the message. For components of type=button, see the button parameter object.
        /// </summary>
        [JsonProperty("parameters")]
        public object Parameters { get; set; }

        /// <summary>
        /// Required when type=button. Not used for the other types. Position index of the button. You can have up to 3 buttons using index values of 0 to 2.
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public string Index { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Component : ({string.Join(", ", toStringOutput)})";
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

            return obj is Component other &&
                this.Type.Equals(other.Type) &&
                ((this.SubType == null && other.SubType == null) || (this.SubType?.Equals(other.SubType) == true)) &&
                ((this.Parameters == null && other.Parameters == null) || (this.Parameters?.Equals(other.Parameters) == true)) &&
                ((this.Index == null && other.Index == null) || (this.Index?.Equals(other.Index) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.SubType = {(this.SubType == null ? "null" : this.SubType.ToString())}");
            toStringOutput.Add($"Parameters = {(this.Parameters == null ? "null" : this.Parameters.ToString())}");
            toStringOutput.Add($"this.Index = {(this.Index == null ? "null" : this.Index == string.Empty ? "" : this.Index)}");
        }
    }
}