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
    /// RelatedSaveRequest
    /// </summary>
    [DataContract]
    public partial class RelatedSaveRequest :  IEquatable<RelatedSaveRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedSaveRequest" /> class.
        /// </summary>
        /// <param name="ParentBusObId">ParentBusObId.</param>
        /// <param name="ParentBusObPublicId">ParentBusObPublicId.</param>
        /// <param name="ParentBusObRecId">ParentBusObRecId.</param>
        /// <param name="RelationshipId">RelationshipId.</param>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObPublicId">BusObPublicId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="Fields">Fields.</param>
        public RelatedSaveRequest(string ParentBusObId = default(string), string ParentBusObPublicId = default(string), string ParentBusObRecId = default(string), string RelationshipId = default(string), string BusObId = default(string), string BusObPublicId = default(string), string BusObRecId = default(string), List<FieldTemplateItem> Fields = default(List<FieldTemplateItem>))
        {
            this.ParentBusObId = ParentBusObId;
            this.ParentBusObPublicId = ParentBusObPublicId;
            this.ParentBusObRecId = ParentBusObRecId;
            this.RelationshipId = RelationshipId;
            this.BusObId = BusObId;
            this.BusObPublicId = BusObPublicId;
            this.BusObRecId = BusObRecId;
            this.Fields = Fields;
        }
        
        /// <summary>
        /// Gets or Sets ParentBusObId
        /// </summary>
        [DataMember(Name="parentBusObId", EmitDefaultValue=false)]
        public string ParentBusObId { get; set; }

        /// <summary>
        /// Gets or Sets ParentBusObPublicId
        /// </summary>
        [DataMember(Name="parentBusObPublicId", EmitDefaultValue=false)]
        public string ParentBusObPublicId { get; set; }

        /// <summary>
        /// Gets or Sets ParentBusObRecId
        /// </summary>
        [DataMember(Name="parentBusObRecId", EmitDefaultValue=false)]
        public string ParentBusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipId
        /// </summary>
        [DataMember(Name="relationshipId", EmitDefaultValue=false)]
        public string RelationshipId { get; set; }

        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

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
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldTemplateItem> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelatedSaveRequest {\n");
            sb.Append("  ParentBusObId: ").Append(ParentBusObId).Append("\n");
            sb.Append("  ParentBusObPublicId: ").Append(ParentBusObPublicId).Append("\n");
            sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append("\n");
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as RelatedSaveRequest);
        }

        /// <summary>
        /// Returns true if RelatedSaveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RelatedSaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelatedSaveRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentBusObId == input.ParentBusObId ||
                    (this.ParentBusObId != null &&
                    this.ParentBusObId.Equals(input.ParentBusObId))
                ) && 
                (
                    this.ParentBusObPublicId == input.ParentBusObPublicId ||
                    (this.ParentBusObPublicId != null &&
                    this.ParentBusObPublicId.Equals(input.ParentBusObPublicId))
                ) && 
                (
                    this.ParentBusObRecId == input.ParentBusObRecId ||
                    (this.ParentBusObRecId != null &&
                    this.ParentBusObRecId.Equals(input.ParentBusObRecId))
                ) && 
                (
                    this.RelationshipId == input.RelationshipId ||
                    (this.RelationshipId != null &&
                    this.RelationshipId.Equals(input.RelationshipId))
                ) && 
                (
                    this.BusObId == input.BusObId ||
                    (this.BusObId != null &&
                    this.BusObId.Equals(input.BusObId))
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
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.ParentBusObId != null)
                    hashCode = hashCode * 59 + this.ParentBusObId.GetHashCode();
                if (this.ParentBusObPublicId != null)
                    hashCode = hashCode * 59 + this.ParentBusObPublicId.GetHashCode();
                if (this.ParentBusObRecId != null)
                    hashCode = hashCode * 59 + this.ParentBusObRecId.GetHashCode();
                if (this.RelationshipId != null)
                    hashCode = hashCode * 59 + this.RelationshipId.GetHashCode();
                if (this.BusObId != null)
                    hashCode = hashCode * 59 + this.BusObId.GetHashCode();
                if (this.BusObPublicId != null)
                    hashCode = hashCode * 59 + this.BusObPublicId.GetHashCode();
                if (this.BusObRecId != null)
                    hashCode = hashCode * 59 + this.BusObRecId.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
