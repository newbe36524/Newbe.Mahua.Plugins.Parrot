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
    /// 登录一个现存的QQ&#x60;
    /// </summary>
    [DataContract]
    public partial class MpqApiLoginHttpInput :  IEquatable<MpqApiLoginHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MpqApiLoginHttpInput" /> class.
        /// </summary>
        /// <param name="qq">欲登录的Q.</param>
        public MpqApiLoginHttpInput(string qq = default(string))
        {
            this.Qq = qq;
        }
        
        /// <summary>
        /// 欲登录的Q
        /// </summary>
        /// <value>欲登录的Q</value>
        [DataMember(Name="qq", EmitDefaultValue=false)]
        public string Qq { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpqApiLoginHttpInput {\n");
            sb.Append("  Qq: ").Append(Qq).Append("\n");
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
            return this.Equals(input as MpqApiLoginHttpInput);
        }

        /// <summary>
        /// Returns true if MpqApiLoginHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MpqApiLoginHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MpqApiLoginHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Qq == input.Qq ||
                    (this.Qq != null &&
                    this.Qq.Equals(input.Qq))
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
                if (this.Qq != null)
                    hashCode = hashCode * 59 + this.Qq.GetHashCode();
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
