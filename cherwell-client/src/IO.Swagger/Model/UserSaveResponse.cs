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
    /// UserSaveResponse
    /// </summary>
    [DataContract]
    public partial class UserSaveResponse :  IEquatable<UserSaveResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSaveResponse" /> class.
        /// </summary>
        /// <param name="BusObPublicId">BusObPublicId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="Error">Error.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="HasError">HasError.</param>
        public UserSaveResponse(string BusObPublicId = default(string), string BusObRecId = default(string), string Error = default(string), string ErrorCode = default(string), bool? HasError = default(bool?))
        {
            this.BusObPublicId = BusObPublicId;
            this.BusObRecId = BusObRecId;
            this.Error = Error;
            this.ErrorCode = ErrorCode;
            this.HasError = HasError;
        }
        
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
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

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
            sb.Append("class UserSaveResponse {\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
            return this.Equals(input as UserSaveResponse);
        }

        /// <summary>
        /// Returns true if UserSaveResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSaveResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSaveResponse input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
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
                if (this.BusObPublicId != null)
                    hashCode = hashCode * 59 + this.BusObPublicId.GetHashCode();
                if (this.BusObRecId != null)
                    hashCode = hashCode * 59 + this.BusObRecId.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
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