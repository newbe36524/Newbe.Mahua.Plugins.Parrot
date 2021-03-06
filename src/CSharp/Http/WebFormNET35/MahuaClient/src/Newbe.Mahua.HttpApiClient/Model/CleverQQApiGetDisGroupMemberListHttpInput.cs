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
    /// 取出讨论组成员列表 （返回格式为 换行符分割开的）
    /// </summary>
    [DataContract]
    public partial class CleverQQApiGetDisGroupMemberListHttpInput :  IEquatable<CleverQQApiGetDisGroupMemberListHttpInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleverQQApiGetDisGroupMemberListHttpInput" /> class.
        /// </summary>
        /// <param name="响应QQ">机器人QQ.</param>
        /// <param name="讨论组ID">需获取的讨论组ID.</param>
        public CleverQQApiGetDisGroupMemberListHttpInput(string 响应QQ = default(string), string 讨论组ID = default(string))
        {
            this.响应QQ = 响应QQ;
            this.讨论组ID = 讨论组ID;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应QQ", EmitDefaultValue=false)]
        public string 响应QQ { get; set; }

        /// <summary>
        /// 需获取的讨论组ID
        /// </summary>
        /// <value>需获取的讨论组ID</value>
        [DataMember(Name="讨论组ID", EmitDefaultValue=false)]
        public string 讨论组ID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleverQQApiGetDisGroupMemberListHttpInput {\n");
            sb.Append("  响应QQ: ").Append(响应QQ).Append("\n");
            sb.Append("  讨论组ID: ").Append(讨论组ID).Append("\n");
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
            return this.Equals(input as CleverQQApiGetDisGroupMemberListHttpInput);
        }

        /// <summary>
        /// Returns true if CleverQQApiGetDisGroupMemberListHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CleverQQApiGetDisGroupMemberListHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleverQQApiGetDisGroupMemberListHttpInput input)
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
                return hashCode;
            }
        }

    }

}
