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
    /// 修改讨论组名称
    /// </summary>
    [DataContract]
    public partial class CleverQQApiSetDisGroupNameHttpInput :  IEquatable<CleverQQApiSetDisGroupNameHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiSetDisGroupNameHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="讨论组ID">需执行的讨论组ID.</param>
        /// <param name="讨论组名称">需修改的名称.</param>
        public CleverQQApiSetDisGroupNameHttpInput(string 响应QQ = default(string), string 讨论组ID = default(string), string 讨论组名称 = default(string))
        {
            this.响应QQ = 响应QQ;
            this.讨论组ID = 讨论组ID;
            this.讨论组名称 = 讨论组名称;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 需执行的讨论组ID
        /// </summary>
        /// <value>需执行的讨论组ID</value>
        [DataMember(Name="讨论组ID", EmitDefaultValue=false)]
        public string 讨论组ID { get; set; }

        /// <summary>
        /// 需修改的名称
        /// </summary>
        /// <value>需修改的名称</value>
        [DataMember(Name="讨论组名称", EmitDefaultValue=false)]
        public string 讨论组名称 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiSetDisGroupNameHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  讨论组ID: ").Append(讨论组ID).Append("\n");
            sb.Append("  讨论组名称: ").Append(讨论组名称).Append("\n");
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
            return this.Equals(input as CleverQQApiSetDisGroupNameHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiSetDisGroupNameHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiSetDisGroupNameHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiSetDisGroupNameHttpInput input)
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
                    this.讨论组ID == input.讨论组ID ||
                    (this.讨论组ID != null &&
                    this.讨论组ID.Equals(input.讨论组ID))
                ) && 
                (
                    this.讨论组名称 == input.讨论组名称 ||
                    (this.讨论组名称 != null &&
                    this.讨论组名称.Equals(input.讨论组名称))
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
                if (this.讨论组ID != null)
                    hashCode = hashCode * 59 + this.讨论组ID.GetHashCode();
                if (this.讨论组名称 != null)
                    hashCode = hashCode * 59 + this.讨论组名称.GetHashCode();
                return hashCode;
            }
        }

    }

}
