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
    /// FieldPermission
    /// </summary>
    [DataContract]
    public partial class FieldPermission :  IEquatable<FieldPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldPermission" /> class.
        /// </summary>
        /// <param name="DepartmentMemberEdit">DepartmentMemberEdit.</param>
        /// <param name="DepartmentMemberView">DepartmentMemberView.</param>
        /// <param name="Edit">Edit.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="ManagerOfOwnerEdit">ManagerOfOwnerEdit.</param>
        /// <param name="ManagerOfOwnerView">ManagerOfOwnerView.</param>
        /// <param name="OwnerEdit">OwnerEdit.</param>
        /// <param name="OwnerView">OwnerView.</param>
        /// <param name="TeamEdit">TeamEdit.</param>
        /// <param name="TeamManagerOfOwnerEdit">TeamManagerOfOwnerEdit.</param>
        /// <param name="TeamManagerOfOwnerView">TeamManagerOfOwnerView.</param>
        /// <param name="TeamView">TeamView.</param>
        /// <param name="View">View.</param>
        public FieldPermission(bool? DepartmentMemberEdit = default(bool?), bool? DepartmentMemberView = default(bool?), bool? Edit = default(bool?), string FieldId = default(string), string FieldName = default(string), bool? ManagerOfOwnerEdit = default(bool?), bool? ManagerOfOwnerView = default(bool?), bool? OwnerEdit = default(bool?), bool? OwnerView = default(bool?), bool? TeamEdit = default(bool?), bool? TeamManagerOfOwnerEdit = default(bool?), bool? TeamManagerOfOwnerView = default(bool?), bool? TeamView = default(bool?), bool? View = default(bool?))
        {
            this.DepartmentMemberEdit = DepartmentMemberEdit;
            this.DepartmentMemberView = DepartmentMemberView;
            this.Edit = Edit;
            this.FieldId = FieldId;
            this.FieldName = FieldName;
            this.ManagerOfOwnerEdit = ManagerOfOwnerEdit;
            this.ManagerOfOwnerView = ManagerOfOwnerView;
            this.OwnerEdit = OwnerEdit;
            this.OwnerView = OwnerView;
            this.TeamEdit = TeamEdit;
            this.TeamManagerOfOwnerEdit = TeamManagerOfOwnerEdit;
            this.TeamManagerOfOwnerView = TeamManagerOfOwnerView;
            this.TeamView = TeamView;
            this.View = View;
        }
        
        /// <summary>
        /// Gets or Sets DepartmentMemberEdit
        /// </summary>
        [DataMember(Name="departmentMemberEdit", EmitDefaultValue=false)]
        public bool? DepartmentMemberEdit { get; set; }

        /// <summary>
        /// Gets or Sets DepartmentMemberView
        /// </summary>
        [DataMember(Name="departmentMemberView", EmitDefaultValue=false)]
        public bool? DepartmentMemberView { get; set; }

        /// <summary>
        /// Gets or Sets Edit
        /// </summary>
        [DataMember(Name="edit", EmitDefaultValue=false)]
        public bool? Edit { get; set; }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets ManagerOfOwnerEdit
        /// </summary>
        [DataMember(Name="managerOfOwnerEdit", EmitDefaultValue=false)]
        public bool? ManagerOfOwnerEdit { get; set; }

        /// <summary>
        /// Gets or Sets ManagerOfOwnerView
        /// </summary>
        [DataMember(Name="managerOfOwnerView", EmitDefaultValue=false)]
        public bool? ManagerOfOwnerView { get; set; }

        /// <summary>
        /// Gets or Sets OwnerEdit
        /// </summary>
        [DataMember(Name="ownerEdit", EmitDefaultValue=false)]
        public bool? OwnerEdit { get; set; }

        /// <summary>
        /// Gets or Sets OwnerView
        /// </summary>
        [DataMember(Name="ownerView", EmitDefaultValue=false)]
        public bool? OwnerView { get; set; }

        /// <summary>
        /// Gets or Sets TeamEdit
        /// </summary>
        [DataMember(Name="teamEdit", EmitDefaultValue=false)]
        public bool? TeamEdit { get; set; }

        /// <summary>
        /// Gets or Sets TeamManagerOfOwnerEdit
        /// </summary>
        [DataMember(Name="teamManagerOfOwnerEdit", EmitDefaultValue=false)]
        public bool? TeamManagerOfOwnerEdit { get; set; }

        /// <summary>
        /// Gets or Sets TeamManagerOfOwnerView
        /// </summary>
        [DataMember(Name="teamManagerOfOwnerView", EmitDefaultValue=false)]
        public bool? TeamManagerOfOwnerView { get; set; }

        /// <summary>
        /// Gets or Sets TeamView
        /// </summary>
        [DataMember(Name="teamView", EmitDefaultValue=false)]
        public bool? TeamView { get; set; }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name="view", EmitDefaultValue=false)]
        public bool? View { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldPermission {\n");
            sb.Append("  DepartmentMemberEdit: ").Append(DepartmentMemberEdit).Append("\n");
            sb.Append("  DepartmentMemberView: ").Append(DepartmentMemberView).Append("\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  ManagerOfOwnerEdit: ").Append(ManagerOfOwnerEdit).Append("\n");
            sb.Append("  ManagerOfOwnerView: ").Append(ManagerOfOwnerView).Append("\n");
            sb.Append("  OwnerEdit: ").Append(OwnerEdit).Append("\n");
            sb.Append("  OwnerView: ").Append(OwnerView).Append("\n");
            sb.Append("  TeamEdit: ").Append(TeamEdit).Append("\n");
            sb.Append("  TeamManagerOfOwnerEdit: ").Append(TeamManagerOfOwnerEdit).Append("\n");
            sb.Append("  TeamManagerOfOwnerView: ").Append(TeamManagerOfOwnerView).Append("\n");
            sb.Append("  TeamView: ").Append(TeamView).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
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
            return this.Equals(input as FieldPermission);
        }

        /// <summary>
        /// Returns true if FieldPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldPermission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DepartmentMemberEdit == input.DepartmentMemberEdit ||
                    (this.DepartmentMemberEdit != null &&
                    this.DepartmentMemberEdit.Equals(input.DepartmentMemberEdit))
                ) && 
                (
                    this.DepartmentMemberView == input.DepartmentMemberView ||
                    (this.DepartmentMemberView != null &&
                    this.DepartmentMemberView.Equals(input.DepartmentMemberView))
                ) && 
                (
                    this.Edit == input.Edit ||
                    (this.Edit != null &&
                    this.Edit.Equals(input.Edit))
                ) && 
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.ManagerOfOwnerEdit == input.ManagerOfOwnerEdit ||
                    (this.ManagerOfOwnerEdit != null &&
                    this.ManagerOfOwnerEdit.Equals(input.ManagerOfOwnerEdit))
                ) && 
                (
                    this.ManagerOfOwnerView == input.ManagerOfOwnerView ||
                    (this.ManagerOfOwnerView != null &&
                    this.ManagerOfOwnerView.Equals(input.ManagerOfOwnerView))
                ) && 
                (
                    this.OwnerEdit == input.OwnerEdit ||
                    (this.OwnerEdit != null &&
                    this.OwnerEdit.Equals(input.OwnerEdit))
                ) && 
                (
                    this.OwnerView == input.OwnerView ||
                    (this.OwnerView != null &&
                    this.OwnerView.Equals(input.OwnerView))
                ) && 
                (
                    this.TeamEdit == input.TeamEdit ||
                    (this.TeamEdit != null &&
                    this.TeamEdit.Equals(input.TeamEdit))
                ) && 
                (
                    this.TeamManagerOfOwnerEdit == input.TeamManagerOfOwnerEdit ||
                    (this.TeamManagerOfOwnerEdit != null &&
                    this.TeamManagerOfOwnerEdit.Equals(input.TeamManagerOfOwnerEdit))
                ) && 
                (
                    this.TeamManagerOfOwnerView == input.TeamManagerOfOwnerView ||
                    (this.TeamManagerOfOwnerView != null &&
                    this.TeamManagerOfOwnerView.Equals(input.TeamManagerOfOwnerView))
                ) && 
                (
                    this.TeamView == input.TeamView ||
                    (this.TeamView != null &&
                    this.TeamView.Equals(input.TeamView))
                ) && 
                (
                    this.View == input.View ||
                    (this.View != null &&
                    this.View.Equals(input.View))
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
                if (this.DepartmentMemberEdit != null)
                    hashCode = hashCode * 59 + this.DepartmentMemberEdit.GetHashCode();
                if (this.DepartmentMemberView != null)
                    hashCode = hashCode * 59 + this.DepartmentMemberView.GetHashCode();
                if (this.Edit != null)
                    hashCode = hashCode * 59 + this.Edit.GetHashCode();
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.ManagerOfOwnerEdit != null)
                    hashCode = hashCode * 59 + this.ManagerOfOwnerEdit.GetHashCode();
                if (this.ManagerOfOwnerView != null)
                    hashCode = hashCode * 59 + this.ManagerOfOwnerView.GetHashCode();
                if (this.OwnerEdit != null)
                    hashCode = hashCode * 59 + this.OwnerEdit.GetHashCode();
                if (this.OwnerView != null)
                    hashCode = hashCode * 59 + this.OwnerView.GetHashCode();
                if (this.TeamEdit != null)
                    hashCode = hashCode * 59 + this.TeamEdit.GetHashCode();
                if (this.TeamManagerOfOwnerEdit != null)
                    hashCode = hashCode * 59 + this.TeamManagerOfOwnerEdit.GetHashCode();
                if (this.TeamManagerOfOwnerView != null)
                    hashCode = hashCode * 59 + this.TeamManagerOfOwnerView.GetHashCode();
                if (this.TeamView != null)
                    hashCode = hashCode * 59 + this.TeamView.GetHashCode();
                if (this.View != null)
                    hashCode = hashCode * 59 + this.View.GetHashCode();
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