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
    /// 置群退出
    /// </summary>
    [DataContract]
    public partial class CqpCQSetGroupLeaveHttpInput :  IEquatable<CqpCQSetGroupLeaveHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CqpCQSetGroupLeaveHttpInput" /> class.
        /// </summary>
        /// <param name="群号">目标群.</param>
        /// <param name="是否解散">真/解散本群(群主) 假/退出本群(管理、群成员).</param>
        public CqpCQSetGroupLeaveHttpInput(long? 群号 = default(long?), bool? 是否解散 = default(bool?))
        {
            this.群号 = 群号;
            this.是否解散 = 是否解散;
        }
        
        /// <summary>
        /// 目标群
        /// </summary>
        /// <value>目标群</value>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public long? 群号 { get; set; }

        /// <summary>
        /// 真/解散本群(群主) 假/退出本群(管理、群成员)
        /// </summary>
        /// <value>真/解散本群(群主) 假/退出本群(管理、群成员)</value>
        [DataMember(Name="是否解散", EmitDefaultValue=false)]
        public bool? 是否解散 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CqpCQSetGroupLeaveHttpInput {\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
            sb.Append("  是否解散: ").Append(是否解散).Append("\n");
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
            return this.Equals(input as CqpCQSetGroupLeaveHttpInput);
        }

        /// <summary>
        /// Returns true if CqpCQSetGroupLeaveHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CqpCQSetGroupLeaveHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CqpCQSetGroupLeaveHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.群号 == input.群号 ||
                    (this.群号 != null &&
                    this.群号.Equals(input.群号))
                ) && 
                (
                    this.是否解散 == input.是否解散 ||
                    (this.是否解散 != null &&
                    this.是否解散.Equals(input.是否解散))
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
                if (this.群号 != null)
                    hashCode = hashCode * 59 + this.群号.GetHashCode();
                if (this.是否解散 != null)
                    hashCode = hashCode * 59 + this.是否解散.GetHashCode();
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
