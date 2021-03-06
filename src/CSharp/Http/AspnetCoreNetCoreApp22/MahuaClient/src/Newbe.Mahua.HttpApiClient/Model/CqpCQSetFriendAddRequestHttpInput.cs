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
    /// 置好友添加请求
    /// </summary>
    [DataContract]
    public partial class CqpCQSetFriendAddRequestHttpInput :  IEquatable<CqpCQSetFriendAddRequestHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CqpCQSetFriendAddRequestHttpInput" /> class.
        /// </summary>
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数.</param>
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝.</param>
        /// <param name="备注">添加后的好友备注.</param>
        public CqpCQSetFriendAddRequestHttpInput(string 请求反馈标识 = default(string), int? 反馈类型 = default(int?), string 备注 = default(string))
        {
            this.请求反馈标识 = 请求反馈标识;
            this.反馈类型 = 反馈类型;
            this.备注 = 备注;
        }
        
        /// <summary>
        /// 请求事件收到的“反馈标识”参数
        /// </summary>
        /// <value>请求事件收到的“反馈标识”参数</value>
        [DataMember(Name="请求反馈标识", EmitDefaultValue=false)]
        public string 请求反馈标识 { get; set; }

        /// <summary>
        /// #请求_通过 或 #请求_拒绝
        /// </summary>
        /// <value>#请求_通过 或 #请求_拒绝</value>
        [DataMember(Name="反馈类型", EmitDefaultValue=false)]
        public int? 反馈类型 { get; set; }

        /// <summary>
        /// 添加后的好友备注
        /// </summary>
        /// <value>添加后的好友备注</value>
        [DataMember(Name="备注", EmitDefaultValue=false)]
        public string 备注 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CqpCQSetFriendAddRequestHttpInput {\n");
            sb.Append("  请求反馈标识: ").Append(请求反馈标识).Append("\n");
            sb.Append("  反馈类型: ").Append(反馈类型).Append("\n");
            sb.Append("  备注: ").Append(备注).Append("\n");
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
            return this.Equals(input as CqpCQSetFriendAddRequestHttpInput);
        }

        /// <summary>
        /// Returns true if CqpCQSetFriendAddRequestHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CqpCQSetFriendAddRequestHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CqpCQSetFriendAddRequestHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.请求反馈标识 == input.请求反馈标识 ||
                    (this.请求反馈标识 != null &&
                    this.请求反馈标识.Equals(input.请求反馈标识))
                ) && 
                (
                    this.反馈类型 == input.反馈类型 ||
                    (this.反馈类型 != null &&
                    this.反馈类型.Equals(input.反馈类型))
                ) && 
                (
                    this.备注 == input.备注 ||
                    (this.备注 != null &&
                    this.备注.Equals(input.备注))
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
                if (this.请求反馈标识 != null)
                    hashCode = hashCode * 59 + this.请求反馈标识.GetHashCode();
                if (this.反馈类型 != null)
                    hashCode = hashCode * 59 + this.反馈类型.GetHashCode();
                if (this.备注 != null)
                    hashCode = hashCode * 59 + this.备注.GetHashCode();
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
