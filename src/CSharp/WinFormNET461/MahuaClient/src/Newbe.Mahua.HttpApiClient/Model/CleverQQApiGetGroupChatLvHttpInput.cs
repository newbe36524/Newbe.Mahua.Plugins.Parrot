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
    /// 查询对象或自身群聊等级（返回实际等级 失败返回-1）Pro可用
    /// </summary>
    [DataContract]
    public partial class CleverQQApiGetGroupChatLvHttpInput :  IEquatable<CleverQQApiGetGroupChatLvHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiGetGroupChatLvHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="群号">查询群号.</param>
        /// <param name="对象QQ">需查询对象或机器人QQ.</param>
        public CleverQQApiGetGroupChatLvHttpInput(string 响应QQ = default(string), string 群号 = default(string), string 对象QQ = default(string))
        {
            this.响应QQ = 响应QQ;
            this.群号 = 群号;
            this.对象QQ = 对象QQ;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 查询群号
        /// </summary>
        /// <value>查询群号</value>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public string 群号 { get; set; }

        /// <summary>
        /// 需查询对象或机器人QQ
        /// </summary>
        /// <value>需查询对象或机器人QQ</value>
        [DataMember(Name="对象QQ", EmitDefaultValue=false)]
        public string 对象QQ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiGetGroupChatLvHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
            sb.Append("  对象QQ: ").Append(对象QQ).Append("\n");
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
            return this.Equals(input as CleverQQApiGetGroupChatLvHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiGetGroupChatLvHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiGetGroupChatLvHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiGetGroupChatLvHttpInput input)
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
                    this.对象QQ == input.对象QQ ||
                    (this.对象QQ != null &&
                    this.对象QQ.Equals(input.对象QQ))
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
                if (this.对象QQ != null)
                    hashCode = hashCode * 59 + this.对象QQ.GetHashCode();
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
