/* 
 * Cherwell Rest API
 *
 * <a href=\"../../index.html\">Cherwell Rest API Documentation</a><br>Select version options from the header drop-down list (to the left of the Client Key box). Then, click Explore to view different versions of operations.
 *
 * OpenAPI spec version: 9.1.0
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SaveLinkAttachmentRequest
    /// </summary>
    [DataContract]
    public partial class SaveLinkAttachmentRequest :  IEquatable<SaveLinkAttachmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveLinkAttachmentRequest" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObName">BusObName.</param>
        /// <param name="BusObPublicId">BusObPublicId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="Comment">Comment.</param>
        /// <param name="DisplayText">DisplayText.</param>
        /// <param name="IncludeLinks">IncludeLinks.</param>
        /// <param name="UncFilePath">UncFilePath.</param>
        public SaveLinkAttachmentRequest(string BusObId = default(string), string BusObName = default(string), string BusObPublicId = default(string), string BusObRecId = default(string), string Comment = default(string), string DisplayText = default(string), bool? IncludeLinks = default(bool?), string UncFilePath = default(string))
        {
            this.BusObId = BusObId;
            this.BusObName = BusObName;
            this.BusObPublicId = BusObPublicId;
            this.BusObRecId = BusObRecId;
            this.Comment = Comment;
            this.DisplayText = DisplayText;
            this.IncludeLinks = IncludeLinks;
            this.UncFilePath = UncFilePath;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets BusObName
        /// </summary>
        [DataMember(Name="busObName", EmitDefaultValue=false)]
        public string BusObName { get; set; }

        /// <summary>
        /// Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name="busObPublicId", EmitDefaultValue=false)]
        public string BusObPublicId { get; set; }

        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=false)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets IncludeLinks
        /// </summary>
        [DataMember(Name="includeLinks", EmitDefaultValue=false)]
        public bool? IncludeLinks { get; set; }

        /// <summary>
        /// Gets or Sets UncFilePath
        /// </summary>
        [DataMember(Name="uncFilePath", EmitDefaultValue=false)]
        public string UncFilePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveLinkAttachmentRequest {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObName: ").Append(BusObName).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append("\n");
            sb.Append("  UncFilePath: ").Append(UncFilePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as SaveLinkAttachmentRequest);
        }

        /// <summary>
        /// Returns true if SaveLinkAttachmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveLinkAttachmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveLinkAttachmentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusObId == input.BusObId ||
                    (this.BusObId != null &&
                    this.BusObId.Equals(input.BusObId))
                ) && 
                (
                    this.BusObName == input.BusObName ||
                    (this.BusObName != null &&
                    this.BusObName.Equals(input.BusObName))
                ) && 
                (
                    this.BusObPublicId == input.BusObPublicId ||
                    (this.BusObPublicId != null &&
                    this.BusObPublicId.Equals(input.BusObPublicId))
                ) && 
                (
                    this.BusObRecId == input.BusObRecId ||
                    (this.BusObRecId != null &&
                    this.BusObRecId.Equals(input.BusObRecId))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.IncludeLinks == input.IncludeLinks ||
                    (this.IncludeLinks != null &&
                    this.IncludeLinks.Equals(input.IncludeLinks))
                ) && 
                (
                    this.UncFilePath == input.UncFilePath ||
                    (this.UncFilePath != null &&
                    this.UncFilePath.Equals(input.UncFilePath))
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
                if (this.BusObId != null)
                    hashCode = hashCode * 59 + this.BusObId.GetHashCode();
                if (this.BusObName != null)
                    hashCode = hashCode * 59 + this.BusObName.GetHashCode();
                if (this.BusObPublicId != null)
                    hashCode = hashCode * 59 + this.BusObPublicId.GetHashCode();
                if (this.BusObRecId != null)
                    hashCode = hashCode * 59 + this.BusObRecId.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.IncludeLinks != null)
                    hashCode = hashCode * 59 + this.IncludeLinks.GetHashCode();
                if (this.UncFilePath != null)
                    hashCode = hashCode * 59 + this.UncFilePath.GetHashCode();
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
