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
    /// 向CleverQQ日志窗口发送一条本插件的日志，可用于调试输出需要的内容，或定位插件错误与运行状态
    /// </summary>
    [DataContract]
    public partial class CleverQQApiOutPutLogHttpInput :  IEquatable<CleverQQApiOutPutLogHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiOutPutLogHttpInput" /> class.
        /// </summary>
        /// <param name="内容">任意想输出的文本格式信息.</param>
        public CleverQQApiOutPutLogHttpInput(string 内容 = default(string))
        {
            this.内容 = 内容;
        }
        
        /// <summary>
        /// 任意想输出的文本格式信息
        /// </summary>
        /// <value>任意想输出的文本格式信息</value>
        [DataMember(Name="内容", EmitDefaultValue=false)]
        public string 内容 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiOutPutLogHttpInput {\n");
            sb.Append("  内容: ").Append(内容).Append("\n");
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
            return this.Equals(input as CleverQQApiOutPutLogHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiOutPutLogHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiOutPutLogHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiOutPutLogHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.内容 == input.内容 ||
                    (this.内容 != null &&
                    this.内容.Equals(input.内容))
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
                if (this.内容 != null)
                    hashCode = hashCode * 59 + this.内容.GetHashCode();
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
