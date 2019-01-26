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
    /// 开关群匿名消息发送功能    成功返回真  失败返回假
    /// </summary>
    [DataContract]
    public partial class CleverQQApiSetAnonHttpInput :  IEquatable<CleverQQApiSetAnonHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiSetAnonHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="群号">需开关群匿名功能群号.</param>
        /// <param name="开关">真开    假关.</param>
        public CleverQQApiSetAnonHttpInput(string 响应QQ = default(string), string 群号 = default(string), bool? 开关 = default(bool?))
        {
            this.响应QQ = 响应QQ;
            this.群号 = 群号;
            this.开关 = 开关;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 需开关群匿名功能群号
        /// </summary>
        /// <value>需开关群匿名功能群号</value>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public string 群号 { get; set; }

        /// <summary>
        /// 真开    假关
        /// </summary>
        /// <value>真开    假关</value>
        [DataMember(Name="开关", EmitDefaultValue=false)]
        public bool? 开关 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiSetAnonHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
            sb.Append("  开关: ").Append(开关).Append("\n");
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
            return this.Equals(input as CleverQQApiSetAnonHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiSetAnonHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiSetAnonHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiSetAnonHttpInput input)
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
                    this.开关 == input.开关 ||
                    (this.开关 != null &&
                    this.开关.Equals(input.开关))
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
                if (this.开关 != null)
                    hashCode = hashCode * 59 + this.开关.GetHashCode();
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
