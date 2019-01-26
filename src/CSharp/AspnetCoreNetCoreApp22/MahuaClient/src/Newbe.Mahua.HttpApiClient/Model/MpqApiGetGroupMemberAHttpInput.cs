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
    /// 通过qun.qq.com接口取得群成员列表 成功返回转码后的JSON格式文本&#x60;
    /// </summary>
    [DataContract]
    public partial class MpqApiGetGroupMemberAHttpInput :  IEquatable<MpqApiGetGroupMemberAHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MpqApiGetGroupMemberAHttpInput" /> class.
        /// </summary>
        /// <param name="响应的QQ">响应的QQ.</param>
        /// <param name="群号">群号.</param>
        public MpqApiGetGroupMemberAHttpInput(string 响应的QQ = default(string), string 群号 = default(string))
        {
            this.响应的QQ = 响应的QQ;
            this.群号 = 群号;
        }
        
        /// <summary>
        /// Gets or Sets 响应的QQ
        /// </summary>
        [DataMember(Name="响应的QQ", EmitDefaultValue=false)]
        public string 响应的QQ { get; set; }

        /// <summary>
        /// Gets or Sets 群号
        /// </summary>
        [DataMember(Name="群号", EmitDefaultValue=false)]
        public string 群号 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpqApiGetGroupMemberAHttpInput {\n");
            sb.Append("  响应的QQ: ").Append(响应的QQ).Append("\n");
            sb.Append("  群号: ").Append(群号).Append("\n");
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
            return this.Equals(input as MpqApiGetGroupMemberAHttpInput);
        }

        /// <summary>
        /// Returns true if MpqApiGetGroupMemberAHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MpqApiGetGroupMemberAHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MpqApiGetGroupMemberAHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.响应的QQ == input.响应的QQ ||
                    (this.响应的QQ != null &&
                    this.响应的QQ.Equals(input.响应的QQ))
                ) && 
                (
                    this.群号 == input.群号 ||
                    (this.群号 != null &&
                    this.群号.Equals(input.群号))
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
                if (this.响应的QQ != null)
                    hashCode = hashCode * 59 + this.响应的QQ.GetHashCode();
                if (this.群号 != null)
                    hashCode = hashCode * 59 + this.群号.GetHashCode();
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
