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
    /// SchemaResponse
    /// </summary>
    [DataContract]
    public partial class SchemaResponse :  IEquatable<SchemaResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaResponse" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="FieldDefinitions">FieldDefinitions.</param>
        /// <param name="FirstRecIdField">FirstRecIdField.</param>
        /// <param name="GridDefinitions">GridDefinitions.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RecIdFields">RecIdFields.</param>
        /// <param name="Relationships">Relationships.</param>
        /// <param name="StateFieldId">StateFieldId.</param>
        /// <param name="States">States.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="HasError">HasError.</param>
        public SchemaResponse(string BusObId = default(string), List<FieldDefinition> FieldDefinitions = default(List<FieldDefinition>), string FirstRecIdField = default(string), List<GridDefinition> GridDefinitions = default(List<GridDefinition>), string Name = default(string), string RecIdFields = default(string), List<Relationship> Relationships = default(List<Relationship>), string StateFieldId = default(string), string States = default(string), string ErrorCode = default(string), string ErrorMessage = default(string), bool? HasError = default(bool?))
        {
            this.BusObId = BusObId;
            this.FieldDefinitions = FieldDefinitions;
            this.FirstRecIdField = FirstRecIdField;
            this.GridDefinitions = GridDefinitions;
            this.Name = Name;
            this.RecIdFields = RecIdFields;
            this.Relationships = Relationships;
            this.StateFieldId = StateFieldId;
            this.States = States;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.HasError = HasError;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        /// <summary>
        /// Gets or Sets FieldDefinitions
        /// </summary>
        [DataMember(Name="fieldDefinitions", EmitDefaultValue=false)]
        public List<FieldDefinition> FieldDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets FirstRecIdField
        /// </summary>
        [DataMember(Name="firstRecIdField", EmitDefaultValue=false)]
        public string FirstRecIdField { get; set; }

        /// <summary>
        /// Gets or Sets GridDefinitions
        /// </summary>
        [DataMember(Name="gridDefinitions", EmitDefaultValue=false)]
        public List<GridDefinition> GridDefinitions { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RecIdFields
        /// </summary>
        [DataMember(Name="recIdFields", EmitDefaultValue=false)]
        public string RecIdFields { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name="relationships", EmitDefaultValue=false)]
        public List<Relationship> Relationships { get; set; }

        /// <summary>
        /// Gets or Sets StateFieldId
        /// </summary>
        [DataMember(Name="stateFieldId", EmitDefaultValue=false)]
        public string StateFieldId { get; set; }

        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [DataMember(Name="states", EmitDefaultValue=false)]
        public string States { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaResponse {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append("\n");
            sb.Append("  FirstRecIdField: ").Append(FirstRecIdField).Append("\n");
            sb.Append("  GridDefinitions: ").Append(GridDefinitions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecIdFields: ").Append(RecIdFields).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("  StateFieldId: ").Append(StateFieldId).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
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
            return this.Equals(input as SchemaResponse);
        }

        /// <summary>
        /// Returns true if SchemaResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SchemaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaResponse input)
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
                    this.FieldDefinitions == input.FieldDefinitions ||
                    this.FieldDefinitions != null &&
                    this.FieldDefinitions.SequenceEqual(input.FieldDefinitions)
                ) && 
                (
                    this.FirstRecIdField == input.FirstRecIdField ||
                    (this.FirstRecIdField != null &&
                    this.FirstRecIdField.Equals(input.FirstRecIdField))
                ) && 
                (
                    this.GridDefinitions == input.GridDefinitions ||
                    this.GridDefinitions != null &&
                    this.GridDefinitions.SequenceEqual(input.GridDefinitions)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RecIdFields == input.RecIdFields ||
                    (this.RecIdFields != null &&
                    this.RecIdFields.Equals(input.RecIdFields))
                ) && 
                (
                    this.Relationships == input.Relationships ||
                    this.Relationships != null &&
                    this.Relationships.SequenceEqual(input.Relationships)
                ) && 
                (
                    this.StateFieldId == input.StateFieldId ||
                    (this.StateFieldId != null &&
                    this.StateFieldId.Equals(input.StateFieldId))
                ) && 
                (
                    this.States == input.States ||
                    (this.States != null &&
                    this.States.Equals(input.States))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.HasError == input.HasError ||
                    (this.HasError != null &&
                    this.HasError.Equals(input.HasError))
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
                if (this.FieldDefinitions != null)
                    hashCode = hashCode * 59 + this.FieldDefinitions.GetHashCode();
                if (this.FirstRecIdField != null)
                    hashCode = hashCode * 59 + this.FirstRecIdField.GetHashCode();
                if (this.GridDefinitions != null)
                    hashCode = hashCode * 59 + this.GridDefinitions.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RecIdFields != null)
                    hashCode = hashCode * 59 + this.RecIdFields.GetHashCode();
                if (this.Relationships != null)
                    hashCode = hashCode * 59 + this.Relationships.GetHashCode();
                if (this.StateFieldId != null)
                    hashCode = hashCode * 59 + this.StateFieldId.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.HasError != null)
                    hashCode = hashCode * 59 + this.HasError.GetHashCode();
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
