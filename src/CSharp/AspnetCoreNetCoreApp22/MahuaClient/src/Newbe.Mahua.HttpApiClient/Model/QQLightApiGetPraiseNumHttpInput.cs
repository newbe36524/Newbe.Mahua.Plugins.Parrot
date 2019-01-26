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
    /// 取得某个QQ的名片赞数量
    /// </summary>
    [DataContract]
    public partial class QQLightApiGetPraiseNumHttpInput :  IEquatable<QQLightApiGetPraiseNumHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QQLightApiGetPraiseNumHttpInput" /> class.
        /// </summary>
        /// <param name="qQ号">qQ号.</param>
        public QQLightApiGetPraiseNumHttpInput(string qQ号 = default(string))
        {
            this.QQ号 = qQ号;
        }
        
        /// <summary>
        /// Gets or Sets QQ号
        /// </summary>
        [DataMember(Name="qQ号", EmitDefaultValue=false)]
        public string QQ号 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QQLightApiGetPraiseNumHttpInput {\n");
            sb.Append("  QQ号: ").Append(QQ号).Append("\n");
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
            return this.Equals(input as QQLightApiGetPraiseNumHttpInput);
        }

        /// <summary>
        /// Returns true if QQLightApiGetPraiseNumHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of QQLightApiGetPraiseNumHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QQLightApiGetPraiseNumHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QQ号 == input.QQ号 ||
                    (this.QQ号 != null &&
                    this.QQ号.Equals(input.QQ号))
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
                if (this.QQ号 != null)
                    hashCode = hashCode * 59 + this.QQ号.GetHashCode();
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
