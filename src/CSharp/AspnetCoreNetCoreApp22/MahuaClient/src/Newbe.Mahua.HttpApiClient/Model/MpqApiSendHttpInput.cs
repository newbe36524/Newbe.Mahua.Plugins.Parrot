/* 
 * Newbe.Mahua.HttpApi
 *
 * this is http api document for Newbe.Mahua. You can get some help from http://www.newbe.pro
 *
 * OpenAPI spec version: v1
 * Contact: 472158246@qq.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Newbe.Mahua.HttpApiClient.Client.SwaggerDateConverter;

namespace Newbe.Mahua.HttpApiClient.Model
{
    /// <summary>
    /// 发送封包&#x60;
    /// </summary>
    [DataContract]
    public partial class MpqApiSendHttpInput :  IEquatable<MpqApiSendHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MpqApiSendHttpInput" /> class.
        /// </summary>
        /// <param name="封包内容">封包内容.</param>
        public MpqApiSendHttpInput(string 封包内容 = default(string))
        {
            this.封包内容 = 封包内容;
        }
        
        /// <summary>
        /// Gets or Sets 封包内容
        /// </summary>
        [DataMember(Name="封包内容", EmitDefaultValue=false)]
        public string 封包内容 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpqApiSendHttpInput {\n");
            sb.Append("  封包内容: ").Append(封包内容).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MpqApiSendHttpInput);
        }

        /// <summary>
        /// Returns true if MpqApiSendHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MpqApiSendHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MpqApiSendHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.封包内容 == input.封包内容 ||
                    (this.封包内容 != null &&
                    this.封包内容.Equals(input.封包内容))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.封包内容 != null)
                    hashCode = hashCode * 59 + this.封包内容.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
