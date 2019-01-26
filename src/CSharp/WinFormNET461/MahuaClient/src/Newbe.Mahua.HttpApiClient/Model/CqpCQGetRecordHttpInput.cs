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
    /// 接收语音
    /// </summary>
    [DataContract]
    public partial class CqpCQGetRecordHttpInput :  IEquatable<CqpCQGetRecordHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CqpCQGetRecordHttpInput" /> class.
        /// </summary>
        /// <param name="file">收到消息中的语音文件名(file).</param>
        /// <param name="outformat">应用所需的格式.</param>
        public CqpCQGetRecordHttpInput(string file = default(string), string outformat = default(string))
        {
            this.File = file;
            this.Outformat = outformat;
        }
        
        /// <summary>
        /// 收到消息中的语音文件名(file)
        /// </summary>
        /// <value>收到消息中的语音文件名(file)</value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; set; }

        /// <summary>
        /// 应用所需的格式
        /// </summary>
        /// <value>应用所需的格式</value>
        [DataMember(Name="outformat", EmitDefaultValue=false)]
        public string Outformat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CqpCQGetRecordHttpInput {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Outformat: ").Append(Outformat).Append("\n");
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
            return this.Equals(input as CqpCQGetRecordHttpInput);
        }

        /// <summary>
        /// Returns true if CqpCQGetRecordHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CqpCQGetRecordHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CqpCQGetRecordHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Outformat == input.Outformat ||
                    (this.Outformat != null &&
                    this.Outformat.Equals(input.Outformat))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Outformat != null)
                    hashCode = hashCode * 59 + this.Outformat.GetHashCode();
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
