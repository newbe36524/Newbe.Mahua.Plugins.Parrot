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
    /// 返回网易云点歌XML
    /// </summary>
    [DataContract]
    public partial class QQLightApi163MusicHttpInput :  IEquatable<QQLightApi163MusicHttpInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QQLightApi163MusicHttpInput" /> class.
        /// </summary>
        /// <param name="歌曲ID">歌曲ID.</param>
        public QQLightApi163MusicHttpInput(string 歌曲ID = default(string))
        {
            this.歌曲ID = 歌曲ID;
        }
        
        /// <summary>
        /// Gets or Sets 歌曲ID
        /// </summary>
        [DataMember(Name="歌曲ID", EmitDefaultValue=false)]
        public string 歌曲ID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QQLightApi163MusicHttpInput {\n");
            sb.Append("  歌曲ID: ").Append(歌曲ID).Append("\n");
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
            return this.Equals(input as QQLightApi163MusicHttpInput);
        }

        /// <summary>
        /// Returns true if QQLightApi163MusicHttpInput instances are equal
        /// </summary>
        /// <param name="input">Instance of QQLightApi163MusicHttpInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QQLightApi163MusicHttpInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.歌曲ID == input.歌曲ID ||
                    (this.歌曲ID != null &&
                    this.歌曲ID.Equals(input.歌曲ID))
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
                if (this.歌曲ID != null)
                    hashCode = hashCode * 59 + this.歌曲ID.GetHashCode();
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
