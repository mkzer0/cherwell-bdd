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
    /// SimpleResultsListGroup
    /// </summary>
    [DataContract]
    public partial class SimpleResultsListGroup :  IEquatable<SimpleResultsListGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleResultsListGroup" /> class.
        /// </summary>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="HasError">HasError.</param>
        /// <param name="IsBusObTarget">IsBusObTarget.</param>
        /// <param name="SimpleResultsListItems">SimpleResultsListItems.</param>
        /// <param name="SubTitle">SubTitle.</param>
        /// <param name="TargetId">TargetId.</param>
        /// <param name="Title">Title.</param>
        public SimpleResultsListGroup(string ErrorMessage = default(string), bool? HasError = default(bool?), bool? IsBusObTarget = default(bool?), List<SimpleResultsListItem> SimpleResultsListItems = default(List<SimpleResultsListItem>), string SubTitle = default(string), string TargetId = default(string), string Title = default(string))
        {
            this.ErrorMessage = ErrorMessage;
            this.HasError = HasError;
            this.IsBusObTarget = IsBusObTarget;
            this.SimpleResultsListItems = SimpleResultsListItems;
            this.SubTitle = SubTitle;
            this.TargetId = TargetId;
            this.Title = Title;
        }
        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }

        /// <summary>
        /// Gets or Sets IsBusObTarget
        /// </summary>
        [DataMember(Name="isBusObTarget", EmitDefaultValue=false)]
        public bool? IsBusObTarget { get; set; }

        /// <summary>
        /// Gets or Sets SimpleResultsListItems
        /// </summary>
        [DataMember(Name="simpleResultsListItems", EmitDefaultValue=false)]
        public List<SimpleResultsListItem> SimpleResultsListItems { get; set; }

        /// <summary>
        /// Gets or Sets SubTitle
        /// </summary>
        [DataMember(Name="subTitle", EmitDefaultValue=false)]
        public string SubTitle { get; set; }

        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        [DataMember(Name="targetId", EmitDefaultValue=false)]
        public string TargetId { get; set; }

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
            sb.Append("class SimpleResultsListGroup {\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  IsBusObTarget: ").Append(IsBusObTarget).Append("\n");
            sb.Append("  SimpleResultsListItems: ").Append(SimpleResultsListItems).Append("\n");
            sb.Append("  SubTitle: ").Append(SubTitle).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
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
            return this.Equals(input as SimpleResultsListGroup);
        }

        /// <summary>
        /// Returns true if SimpleResultsListGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleResultsListGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleResultsListGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.HasError == input.HasError ||
                    (this.HasError != null &&
                    this.HasError.Equals(input.HasError))
                ) && 
                (
                    this.IsBusObTarget == input.IsBusObTarget ||
                    (this.IsBusObTarget != null &&
                    this.IsBusObTarget.Equals(input.IsBusObTarget))
                ) && 
                (
                    this.SimpleResultsListItems == input.SimpleResultsListItems ||
                    this.SimpleResultsListItems != null &&
                    this.SimpleResultsListItems.SequenceEqual(input.SimpleResultsListItems)
                ) && 
                (
                    this.SubTitle == input.SubTitle ||
                    (this.SubTitle != null &&
                    this.SubTitle.Equals(input.SubTitle))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
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
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.HasError != null)
                    hashCode = hashCode * 59 + this.HasError.GetHashCode();
                if (this.IsBusObTarget != null)
                    hashCode = hashCode * 59 + this.IsBusObTarget.GetHashCode();
                if (this.SimpleResultsListItems != null)
                    hashCode = hashCode * 59 + this.SimpleResultsListItems.GetHashCode();
                if (this.SubTitle != null)
                    hashCode = hashCode * 59 + this.SubTitle.GetHashCode();
                if (this.TargetId != null)
                    hashCode = hashCode * 59 + this.TargetId.GetHashCode();
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
