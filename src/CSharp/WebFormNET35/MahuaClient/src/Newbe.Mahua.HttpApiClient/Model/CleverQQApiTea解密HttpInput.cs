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
    /// 腾讯Tea解密
    /// </summary>
    [DataContract]
    public partial class CleverQQApiTea解密HttpInput :  IEquatable<CleverQQApiTea解密HttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiTea解密HttpInput" /> class.
        /// </summary>
        /// <param name="需解密内容">需解密的内容.</param>
        /// <param name="会话KEY">这里填Api_SessionKey.</param>
        public CleverQQApiTea解密HttpInput(string 需解密内容 = default(string), string 会话KEY = default(string))
        {
            this.需解密内容 = 需解密内容;
            this.会话KEY = 会话KEY;
        }
        
        /// <summary>
        /// 需解密的内容
        /// </summary>
        /// <value>需解密的内容</value>
        [DataMember(Name="需解密内容", EmitDefaultValue=false)]
        public string 需解密内容 { get; set; }

        /// <summary>
        /// 这里填Api_SessionKey
        /// </summary>
        /// <value>这里填Api_SessionKey</value>
        [DataMember(Name="会话KEY", EmitDefaultValue=false)]
        public string 会话KEY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiTea解密HttpInput {\n");
            sb.Append("  需解密内容: ").Append(需解密内容).Append("\n");
            sb.Append("  会话KEY: ").Append(会话KEY).Append("\n");
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
            return this.Equals(input as CleverQQApiTea解密HttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiTea解密HttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiTea解密HttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiTea解密HttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.需解密内容 == input.需解密内容 ||
                    (this.需解密内容 != null &&
                    this.需解密内容.Equals(input.需解密内容))
                ) && 
                (
                    this.会话KEY == input.会话KEY ||
                    (this.会话KEY != null &&
                    this.会话KEY.Equals(input.会话KEY))
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
                if (this.需解密内容 != null)
                    hashCode = hashCode * 59 + this.需解密内容.GetHashCode();
                if (this.会话KEY != null)
                    hashCode = hashCode * 59 + this.会话KEY.GetHashCode();
                return hashCode;
            }
        }

    }

}
