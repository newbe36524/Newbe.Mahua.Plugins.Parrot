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
    /// 登录指定QQ，应确保QQ号码在列表中已存在
    /// </summary>
    [DataContract]
    public partial class CleverQQApiLoginQQHttpInput :  IEquatable<CleverQQApiLoginQQHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiLoginQQHttpInput" /> class.
        /// </summary>
        /// <param name="登录QQ">登录QQ.</param>
        public CleverQQApiLoginQQHttpInput(string 登录QQ = default(string))
        {
            this.登录QQ = 登录QQ;
        }
        
        /// <summary>
        /// Gets or Sets 登录QQ
        /// </summary>
        [DataMember(Name="登录QQ", EmitDefaultValue=false)]
        public string 登录QQ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiLoginQQHttpInput {\n");
            sb.Append("  登录QQ: ").Append(登录QQ).Append("\n");
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
            return this.Equals(input as CleverQQApiLoginQQHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiLoginQQHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiLoginQQHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiLoginQQHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.登录QQ == input.登录QQ ||
                    (this.登录QQ != null &&
                    this.登录QQ.Equals(input.登录QQ))
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
                if (this.登录QQ != null)
                    hashCode = hashCode * 59 + this.登录QQ.GetHashCode();
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