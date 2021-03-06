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
    /// SimpleResultsListItem
    /// </summary>
    [DataContract]
    public partial class SimpleResultsListItem :  IEquatable<SimpleResultsListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleResultsListItem" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="DocRepositoryItemId">DocRepositoryItemId.</param>
        /// <param name="GalleryImage">GalleryImage.</param>
        /// <param name="Links">Links.</param>
        /// <param name="PublicId">PublicId.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        /// <param name="SubTitle">SubTitle.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Title">Title.</param>
        public SimpleResultsListItem(string BusObId = default(string), string BusObRecId = default(string), string DocRepositoryItemId = default(string), string GalleryImage = default(string), List<Link> Links = default(List<Link>), string PublicId = default(string), string Scope = default(string), string ScopeOwner = default(string), string SubTitle = default(string), string Text = default(string), string Title = default(string))
        {
            this.BusObId = BusObId;
            this.BusObRecId = BusObRecId;
            this.DocRepositoryItemId = DocRepositoryItemId;
            this.GalleryImage = GalleryImage;
            this.Links = Links;
            this.PublicId = PublicId;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
            this.SubTitle = SubTitle;
            this.Text = Text;
            this.Title = Title;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        /// <summary>
        /// Gets or Sets DocRepositoryItemId
        /// </summary>
        [DataMember(Name="docRepositoryItemId", EmitDefaultValue=false)]
        public string DocRepositoryItemId { get; set; }

        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name="galleryImage", EmitDefaultValue=false)]
        public string GalleryImage { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets PublicId
        /// </summary>
        [DataMember(Name="publicId", EmitDefaultValue=false)]
        public string PublicId { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }

        /// <summary>
        /// Gets or Sets SubTitle
        /// </summary>
        [DataMember(Name="subTitle", EmitDefaultValue=false)]
        public string SubTitle { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleResultsListItem {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  DocRepositoryItemId: ").Append(DocRepositoryItemId).Append("\n");
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  SubTitle: ").Append(SubTitle).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as SimpleResultsListItem);
        }

        /// <summary>
        /// Returns true if SimpleResultsListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleResultsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleResultsListItem input)
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
                    this.BusObRecId == input.BusObRecId ||
                    (this.BusObRecId != null &&
                    this.BusObRecId.Equals(input.BusObRecId))
                ) && 
                (
                    this.DocRepositoryItemId == input.DocRepositoryItemId ||
                    (this.DocRepositoryItemId != null &&
                    this.DocRepositoryItemId.Equals(input.DocRepositoryItemId))
                ) && 
                (
                    this.GalleryImage == input.GalleryImage ||
                    (this.GalleryImage != null &&
                    this.GalleryImage.Equals(input.GalleryImage))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.ScopeOwner == input.ScopeOwner ||
                    (this.ScopeOwner != null &&
                    this.ScopeOwner.Equals(input.ScopeOwner))
                ) && 
                (
                    this.SubTitle == input.SubTitle ||
                    (this.SubTitle != null &&
                    this.SubTitle.Equals(input.SubTitle))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.BusObRecId != null)
                    hashCode = hashCode * 59 + this.BusObRecId.GetHashCode();
                if (this.DocRepositoryItemId != null)
                    hashCode = hashCode * 59 + this.DocRepositoryItemId.GetHashCode();
                if (this.GalleryImage != null)
                    hashCode = hashCode * 59 + this.GalleryImage.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.PublicId != null)
                    hashCode = hashCode * 59 + this.PublicId.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hashCode = hashCode * 59 + this.ScopeOwner.GetHashCode();
                if (this.SubTitle != null)
                    hashCode = hashCode * 59 + this.SubTitle.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
