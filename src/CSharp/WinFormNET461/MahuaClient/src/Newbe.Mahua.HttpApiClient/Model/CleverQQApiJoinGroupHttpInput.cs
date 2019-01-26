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
    /// 申请加群
    /// </summary>
    [DataContract]
    public partial class CleverQQApiJoinGroupHttpInput :  IEquatable<CleverQQApiJoinGroupHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiJoinGroupHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="群号">欲申请加入的群号.</param>
        /// <param name="理由">附加理由，可留空（需回答正确问题时，请填写问题答案）.</param>
        public CleverQQApiJoinGroupHttpInput(string 响应QQ = default(string), string 群号 = default(string), string 理由 = default(string))
        {
            this.响应QQ = 响应QQ;
            this.群号 = 群号;
            this.理由 = 理由;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 欲申请加入的群号
        /// </summary>
        /// <value>欲申请加入的群号</value>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public string 群号 { get; set; }

        /// <summary>
        /// 附加理由，可留空（需回答正确问题时，请填写问题答案）
        /// </summary>
        /// <value>附加理由，可留空（需回答正确问题时，请填写问题答案）</value>
        [DataMember(Name="理由", EmitDefaultValue=false)]
        public string 理由 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiJoinGroupHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
            sb.Append("  理由: ").Append(理由).Append("\n");
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
            return this.Equals(input as CleverQQApiJoinGroupHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiJoinGroupHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiJoinGroupHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiJoinGroupHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.响应QQ == input.响应QQ ||
                    (this.响应QQ != null &&
                    this.响应QQ.Equals(input.响应QQ))
                ) && 
                (
                    this.群号 == input.群号 ||
                    (this.群号 != null &&
                    this.群号.Equals(input.群号))
                ) && 
                (
                    this.理由 == input.理由 ||
                    (this.理由 != null &&
                    this.理由.Equals(input.理由))
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
                if (this.响应QQ != null)
                    hashCode = hashCode * 59 + this.响应QQ.GetHashCode();
                if (this.群号 != null)
                    hashCode = hashCode * 59 + this.群号.GetHashCode();
                if (this.理由 != null)
                    hashCode = hashCode * 59 + this.理由.GetHashCode();
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
