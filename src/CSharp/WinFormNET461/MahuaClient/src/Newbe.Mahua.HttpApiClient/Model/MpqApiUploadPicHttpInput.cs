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
    /// 返回值:成功返回图片GUID用于发送该图片.失败返回空.  图片尺寸应小于4MB&#x60;
    /// </summary>
    [DataContract]
    public partial class MpqApiUploadPicHttpInput :  IEquatable<MpqApiUploadPicHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MpqApiUploadPicHttpInput" /> class.
        /// </summary>
        /// <param name="响应的QQ">机器人QQ.</param>
        /// <param name="参上传类型">1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1.</param>
        /// <param name="参参考对象">上传该图片所属的群号或QQ.</param>
        /// <param name="参图片数据">址, 图片字节集数据或字节集数据指针().</param>
        public MpqApiUploadPicHttpInput(string 响应的QQ = default(string), int? 参上传类型 = default(int?), string 参参考对象 = default(string), string 参图片数据 = default(string))
        {
            this.响应的QQ = 响应的QQ;
            this.参上传类型 = 参上传类型;
            this.参参考对象 = 参参考对象;
            this.参图片数据 = 参图片数据;
        }
        
        /// <summary>
        /// 机器人QQ
        /// </summary>
        /// <value>机器人QQ</value>
        [DataMember(Name="响应的QQ", EmitDefaultValue=false)]
        public string 响应的QQ { get; set; }

        /// <summary>
        /// 1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1
        /// </summary>
        /// <value>1好友2群 注:好友图和群图的GUID并不相同并不通用 需要非别上传。群、讨论组用类型2 临时会话、好友信息需要类型1</value>
        [DataMember(Name="参_上传类型", EmitDefaultValue=false)]
        public int? 参上传类型 { get; set; }

        /// <summary>
        /// 上传该图片所属的群号或QQ
        /// </summary>
        /// <value>上传该图片所属的群号或QQ</value>
        [DataMember(Name="参_参考对象", EmitDefaultValue=false)]
        public string 参参考对象 { get; set; }

        /// <summary>
        /// 址, 图片字节集数据或字节集数据指针()
        /// </summary>
        /// <value>址, 图片字节集数据或字节集数据指针()</value>
        [DataMember(Name="参_图片数据", EmitDefaultValue=false)]
        public string 参图片数据 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MpqApiUploadPicHttpInput {\n");
            sb.Append("  响应的QQ: ").Append(响应的QQ).Append("\n");
            sb.Append("  参上传类型: ").Append(参上传类型).Append("\n");
            sb.Append("  参参考对象: ").Append(参参考对象).Append("\n");
            sb.Append("  参图片数据: ").Append(参图片数据).Append("\n");
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
            return this.Equals(input as MpqApiUploadPicHttpInput);
        }

        /// <summary>
        /// Returns true if MpqApiUploadPicHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of MpqApiUploadPicHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MpqApiUploadPicHttpInput input)
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
                    this.参上传类型 == input.参上传类型 ||
                    (this.参上传类型 != null &&
                    this.参上传类型.Equals(input.参上传类型))
                ) && 
                (
                    this.参参考对象 == input.参参考对象 ||
                    (this.参参考对象 != null &&
                    this.参参考对象.Equals(input.参参考对象))
                ) && 
                (
                    this.参图片数据 == input.参图片数据 ||
                    (this.参图片数据 != null &&
                    this.参图片数据.Equals(input.参图片数据))
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
                if (this.参上传类型 != null)
                    hashCode = hashCode * 59 + this.参上传类型.GetHashCode();
                if (this.参参考对象 != null)
                    hashCode = hashCode * 59 + this.参参考对象.GetHashCode();
                if (this.参图片数据 != null)
                    hashCode = hashCode * 59 + this.参图片数据.GetHashCode();
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
