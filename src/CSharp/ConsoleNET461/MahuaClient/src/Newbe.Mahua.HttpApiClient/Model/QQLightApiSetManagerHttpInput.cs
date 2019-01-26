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
    /// QQLightApiSetManagerHttpInput
    /// </summary>
    [DataContract]
    public partial class QQLightApiSetManagerHttpInput :  IEquatable<QQLightApiSetManagerHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QQLightApiSetManagerHttpInput" /> class.
        /// </summary>
        /// <param name="群号">群号.</param>
        /// <param name="qQ号">qQ号.</param>
        /// <param name="是否设置为管理员">真,设置  假,取消.</param>
        public QQLightApiSetManagerHttpInput(string 群号 = default(string), string qQ号 = default(string), bool? 是否设置为管理员 = default(bool?))
        {
            this.群号 = 群号;
            this.QQ号 = qQ号;
            this.是否设置为管理员 = 是否设置为管理员;
        }
        
        /// <summary>
        /// Gets or Sets 群号
        /// </summary>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public string 群号 { get; set; }

        /// <summary>
        /// Gets or Sets QQ号
        /// </summary>
        [DataMember(Name="qQ号", EmitDefaultValue=false)]
        public string QQ号 { get; set; }

        /// <summary>
        /// 真,设置  假,取消
        /// </summary>
        /// <value>真,设置  假,取消</value>
        [DataMember(Name="是否设置为管理员", EmitDefaultValue=false)]
        public bool? 是否设置为管理员 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QQLightApiSetManagerHttpInput {\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
            sb.Append("  QQ号: ").Append(QQ号).Append("\n");
            sb.Append("  是否设置为管理员: ").Append(是否设置为管理员).Append("\n");
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
            return this.Equals(input as QQLightApiSetManagerHttpInput);
        }

        /// <summary>
        /// Returns true if QQLightApiSetManagerHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of QQLightApiSetManagerHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QQLightApiSetManagerHttpInput input)
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
                    this.QQ号 == input.QQ号 ||
                    (this.QQ号 != null &&
                    this.QQ号.Equals(input.QQ号))
                ) && 
                (
                    this.是否设置为管理员 == input.是否设置为管理员 ||
                    (this.是否设置为管理员 != null &&
                    this.是否设置为管理员.Equals(input.是否设置为管理员))
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
                if (this.QQ号 != null)
                    hashCode = hashCode * 59 + this.QQ号.GetHashCode();
                if (this.是否设置为管理员 != null)
                    hashCode = hashCode * 59 + this.是否设置为管理员.GetHashCode();
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
