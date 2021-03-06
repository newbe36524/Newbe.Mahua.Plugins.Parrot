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
    /// 置讨论组退出
    /// </summary>
    [DataContract]
    public partial class CqpCQSetDiscussLeaveHttpInput :  IEquatable<CqpCQSetDiscussLeaveHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CqpCQSetDiscussLeaveHttpInput" /> class.
        /// </summary>
        /// <param name="讨论组号">目标讨论组.</param>
        public CqpCQSetDiscussLeaveHttpInput(long? 讨论组号 = default(long?))
        {
            this.讨论组号 = 讨论组号;
        }
        
        /// <summary>
        /// 目标讨论组
        /// </summary>
        /// <value>目标讨论组</value>
        [DataMember(Name="讨论组号", EmitDefaultValue=false)]
        public long? 讨论组号 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CqpCQSetDiscussLeaveHttpInput {\n");
            sb.Append("  讨论组号: ").Append(讨论组号).Append("\n");
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
            return this.Equals(input as CqpCQSetDiscussLeaveHttpInput);
        }

        /// <summary>
        /// Returns true if CqpCQSetDiscussLeaveHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CqpCQSetDiscussLeaveHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CqpCQSetDiscussLeaveHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.讨论组号 == input.讨论组号 ||
                    (this.讨论组号 != null &&
                    this.讨论组号.Equals(input.讨论组号))
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
                if (this.讨论组号 != null)
                    hashCode = hashCode * 59 + this.讨论组号.GetHashCode();
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
