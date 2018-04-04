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
    /// Right
    /// </summary>
    [DataContract]
    public partial class Right :  IEquatable<Right>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Right" /> class.
        /// </summary>
        /// <param name="Add">Add.</param>
        /// <param name="Allow">Allow.</param>
        /// <param name="CategoryDescription">CategoryDescription.</param>
        /// <param name="CategoryId">CategoryId.</param>
        /// <param name="CategoryName">CategoryName.</param>
        /// <param name="Delete">Delete.</param>
        /// <param name="Edit">Edit.</param>
        /// <param name="IsYesNoRight">IsYesNoRight.</param>
        /// <param name="NonScopeOwnerAdd">NonScopeOwnerAdd.</param>
        /// <param name="NonScopeOwnerDelete">NonScopeOwnerDelete.</param>
        /// <param name="NonScopeOwnerEdit">NonScopeOwnerEdit.</param>
        /// <param name="NonScopeOwnerView">NonScopeOwnerView.</param>
        /// <param name="RightId">RightId.</param>
        /// <param name="RightName">RightName.</param>
        /// <param name="StandardRightName">StandardRightName.</param>
        /// <param name="ViewRunOpen">ViewRunOpen.</param>
        public Right(bool? Add = default(bool?), bool? Allow = default(bool?), string CategoryDescription = default(string), string CategoryId = default(string), string CategoryName = default(string), bool? Delete = default(bool?), bool? Edit = default(bool?), bool? IsYesNoRight = default(bool?), bool? NonScopeOwnerAdd = default(bool?), bool? NonScopeOwnerDelete = default(bool?), bool? NonScopeOwnerEdit = default(bool?), bool? NonScopeOwnerView = default(bool?), string RightId = default(string), string RightName = default(string), string StandardRightName = default(string), bool? ViewRunOpen = default(bool?))
        {
            this.Add = Add;
            this.Allow = Allow;
            this.CategoryDescription = CategoryDescription;
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
            this.Delete = Delete;
            this.Edit = Edit;
            this.IsYesNoRight = IsYesNoRight;
            this.NonScopeOwnerAdd = NonScopeOwnerAdd;
            this.NonScopeOwnerDelete = NonScopeOwnerDelete;
            this.NonScopeOwnerEdit = NonScopeOwnerEdit;
            this.NonScopeOwnerView = NonScopeOwnerView;
            this.RightId = RightId;
            this.RightName = RightName;
            this.StandardRightName = StandardRightName;
            this.ViewRunOpen = ViewRunOpen;
        }
        
        /// <summary>
        /// Gets or Sets Add
        /// </summary>
        [DataMember(Name="add", EmitDefaultValue=false)]
        public bool? Add { get; set; }

        /// <summary>
        /// Gets or Sets Allow
        /// </summary>
        [DataMember(Name="allow", EmitDefaultValue=false)]
        public bool? Allow { get; set; }

        /// <summary>
        /// Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name="categoryDescription", EmitDefaultValue=false)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="categoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or Sets Delete
        /// </summary>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// Gets or Sets Edit
        /// </summary>
        [DataMember(Name="edit", EmitDefaultValue=false)]
        public bool? Edit { get; set; }

        /// <summary>
        /// Gets or Sets IsYesNoRight
        /// </summary>
        [DataMember(Name="isYesNoRight", EmitDefaultValue=false)]
        public bool? IsYesNoRight { get; set; }

        /// <summary>
        /// Gets or Sets NonScopeOwnerAdd
        /// </summary>
        [DataMember(Name="nonScopeOwnerAdd", EmitDefaultValue=false)]
        public bool? NonScopeOwnerAdd { get; set; }

        /// <summary>
        /// Gets or Sets NonScopeOwnerDelete
        /// </summary>
        [DataMember(Name="nonScopeOwnerDelete", EmitDefaultValue=false)]
        public bool? NonScopeOwnerDelete { get; set; }

        /// <summary>
        /// Gets or Sets NonScopeOwnerEdit
        /// </summary>
        [DataMember(Name="nonScopeOwnerEdit", EmitDefaultValue=false)]
        public bool? NonScopeOwnerEdit { get; set; }

        /// <summary>
        /// Gets or Sets NonScopeOwnerView
        /// </summary>
        [DataMember(Name="nonScopeOwnerView", EmitDefaultValue=false)]
        public bool? NonScopeOwnerView { get; set; }

        /// <summary>
        /// Gets or Sets RightId
        /// </summary>
        [DataMember(Name="rightId", EmitDefaultValue=false)]
        public string RightId { get; set; }

        /// <summary>
        /// Gets or Sets RightName
        /// </summary>
        [DataMember(Name="rightName", EmitDefaultValue=false)]
        public string RightName { get; set; }

        /// <summary>
        /// Gets or Sets StandardRightName
        /// </summary>
        [DataMember(Name="standardRightName", EmitDefaultValue=false)]
        public string StandardRightName { get; set; }

        /// <summary>
        /// Gets or Sets ViewRunOpen
        /// </summary>
        [DataMember(Name="viewRunOpen", EmitDefaultValue=false)]
        public bool? ViewRunOpen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Right {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  Allow: ").Append(Allow).Append("\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  IsYesNoRight: ").Append(IsYesNoRight).Append("\n");
            sb.Append("  NonScopeOwnerAdd: ").Append(NonScopeOwnerAdd).Append("\n");
            sb.Append("  NonScopeOwnerDelete: ").Append(NonScopeOwnerDelete).Append("\n");
            sb.Append("  NonScopeOwnerEdit: ").Append(NonScopeOwnerEdit).Append("\n");
            sb.Append("  NonScopeOwnerView: ").Append(NonScopeOwnerView).Append("\n");
            sb.Append("  RightId: ").Append(RightId).Append("\n");
            sb.Append("  RightName: ").Append(RightName).Append("\n");
            sb.Append("  StandardRightName: ").Append(StandardRightName).Append("\n");
            sb.Append("  ViewRunOpen: ").Append(ViewRunOpen).Append("\n");
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
            return this.Equals(input as Right);
        }

        /// <summary>
        /// Returns true if Right instances are equal
        /// </summary>
        /// <param name="input">Instance of Right to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Right input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Add == input.Add ||
                    (this.Add != null &&
                    this.Add.Equals(input.Add))
                ) && 
                (
                    this.Allow == input.Allow ||
                    (this.Allow != null &&
                    this.Allow.Equals(input.Allow))
                ) && 
                (
                    this.CategoryDescription == input.CategoryDescription ||
                    (this.CategoryDescription != null &&
                    this.CategoryDescription.Equals(input.CategoryDescription))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.Delete == input.Delete ||
                    (this.Delete != null &&
                    this.Delete.Equals(input.Delete))
                ) && 
                (
                    this.Edit == input.Edit ||
                    (this.Edit != null &&
                    this.Edit.Equals(input.Edit))
                ) && 
                (
                    this.IsYesNoRight == input.IsYesNoRight ||
                    (this.IsYesNoRight != null &&
                    this.IsYesNoRight.Equals(input.IsYesNoRight))
                ) && 
                (
                    this.NonScopeOwnerAdd == input.NonScopeOwnerAdd ||
                    (this.NonScopeOwnerAdd != null &&
                    this.NonScopeOwnerAdd.Equals(input.NonScopeOwnerAdd))
                ) && 
                (
                    this.NonScopeOwnerDelete == input.NonScopeOwnerDelete ||
                    (this.NonScopeOwnerDelete != null &&
                    this.NonScopeOwnerDelete.Equals(input.NonScopeOwnerDelete))
                ) && 
                (
                    this.NonScopeOwnerEdit == input.NonScopeOwnerEdit ||
                    (this.NonScopeOwnerEdit != null &&
                    this.NonScopeOwnerEdit.Equals(input.NonScopeOwnerEdit))
                ) && 
                (
                    this.NonScopeOwnerView == input.NonScopeOwnerView ||
                    (this.NonScopeOwnerView != null &&
                    this.NonScopeOwnerView.Equals(input.NonScopeOwnerView))
                ) && 
                (
                    this.RightId == input.RightId ||
                    (this.RightId != null &&
                    this.RightId.Equals(input.RightId))
                ) && 
                (
                    this.RightName == input.RightName ||
                    (this.RightName != null &&
                    this.RightName.Equals(input.RightName))
                ) && 
                (
                    this.StandardRightName == input.StandardRightName ||
                    (this.StandardRightName != null &&
                    this.StandardRightName.Equals(input.StandardRightName))
                ) && 
                (
                    this.ViewRunOpen == input.ViewRunOpen ||
                    (this.ViewRunOpen != null &&
                    this.ViewRunOpen.Equals(input.ViewRunOpen))
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
                if (this.Add != null)
                    hashCode = hashCode * 59 + this.Add.GetHashCode();
                if (this.Allow != null)
                    hashCode = hashCode * 59 + this.Allow.GetHashCode();
                if (this.CategoryDescription != null)
                    hashCode = hashCode * 59 + this.CategoryDescription.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.Delete != null)
                    hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.Edit != null)
                    hashCode = hashCode * 59 + this.Edit.GetHashCode();
                if (this.IsYesNoRight != null)
                    hashCode = hashCode * 59 + this.IsYesNoRight.GetHashCode();
                if (this.NonScopeOwnerAdd != null)
                    hashCode = hashCode * 59 + this.NonScopeOwnerAdd.GetHashCode();
                if (this.NonScopeOwnerDelete != null)
                    hashCode = hashCode * 59 + this.NonScopeOwnerDelete.GetHashCode();
                if (this.NonScopeOwnerEdit != null)
                    hashCode = hashCode * 59 + this.NonScopeOwnerEdit.GetHashCode();
                if (this.NonScopeOwnerView != null)
                    hashCode = hashCode * 59 + this.NonScopeOwnerView.GetHashCode();
                if (this.RightId != null)
                    hashCode = hashCode * 59 + this.RightId.GetHashCode();
                if (this.RightName != null)
                    hashCode = hashCode * 59 + this.RightName.GetHashCode();
                if (this.StandardRightName != null)
                    hashCode = hashCode * 59 + this.StandardRightName.GetHashCode();
                if (this.ViewRunOpen != null)
                    hashCode = hashCode * 59 + this.ViewRunOpen.GetHashCode();
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
