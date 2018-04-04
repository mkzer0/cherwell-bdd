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
    /// BatchDeleteRequest
    /// </summary>
    [DataContract]
    public partial class BatchDeleteRequest :  IEquatable<BatchDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="DeleteRequests">DeleteRequests.</param>
        /// <param name="StopOnError">StopOnError.</param>
        public BatchDeleteRequest(List<DeleteRequest> DeleteRequests = default(List<DeleteRequest>), bool? StopOnError = default(bool?))
        {
            this.DeleteRequests = DeleteRequests;
            this.StopOnError = StopOnError;
        }
        
        /// <summary>
        /// Gets or Sets DeleteRequests
        /// </summary>
        [DataMember(Name="deleteRequests", EmitDefaultValue=false)]
        public List<DeleteRequest> DeleteRequests { get; set; }

        /// <summary>
        /// Gets or Sets StopOnError
        /// </summary>
        [DataMember(Name="stopOnError", EmitDefaultValue=false)]
        public bool? StopOnError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteRequest {\n");
            sb.Append("  DeleteRequests: ").Append(DeleteRequests).Append("\n");
            sb.Append("  StopOnError: ").Append(StopOnError).Append("\n");
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
            return this.Equals(input as BatchDeleteRequest);
        }

        /// <summary>
        /// Returns true if BatchDeleteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchDeleteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteRequests == input.DeleteRequests ||
                    this.DeleteRequests != null &&
                    this.DeleteRequests.SequenceEqual(input.DeleteRequests)
                ) && 
                (
                    this.StopOnError == input.StopOnError ||
                    (this.StopOnError != null &&
                    this.StopOnError.Equals(input.StopOnError))
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
                if (this.DeleteRequests != null)
                    hashCode = hashCode * 59 + this.DeleteRequests.GetHashCode();
                if (this.StopOnError != null)
                    hashCode = hashCode * 59 + this.StopOnError.GetHashCode();
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
