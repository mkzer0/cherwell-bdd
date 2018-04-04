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
    /// SearchItemResponse
    /// </summary>
    [DataContract]
    public partial class SearchItemResponse :  IEquatable<SearchItemResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItemResponse" /> class.
        /// </summary>
        /// <param name="Root">Root.</param>
        /// <param name="SupportedAssociations">SupportedAssociations.</param>
        public SearchItemResponse(SearchFolder Root = default(SearchFolder), List<Association> SupportedAssociations = default(List<Association>))
        {
            this.Root = Root;
            this.SupportedAssociations = SupportedAssociations;
        }
        
        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name="root", EmitDefaultValue=false)]
        public SearchFolder Root { get; set; }

        /// <summary>
        /// Gets or Sets SupportedAssociations
        /// </summary>
        [DataMember(Name="supportedAssociations", EmitDefaultValue=false)]
        public List<Association> SupportedAssociations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchItemResponse {\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  SupportedAssociations: ").Append(SupportedAssociations).Append("\n");
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
            return this.Equals(input as SearchItemResponse);
        }

        /// <summary>
        /// Returns true if SearchItemResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchItemResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Root == input.Root ||
                    (this.Root != null &&
                    this.Root.Equals(input.Root))
                ) && 
                (
                    this.SupportedAssociations == input.SupportedAssociations ||
                    this.SupportedAssociations != null &&
                    this.SupportedAssociations.SequenceEqual(input.SupportedAssociations)
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
                if (this.Root != null)
                    hashCode = hashCode * 59 + this.Root.GetHashCode();
                if (this.SupportedAssociations != null)
                    hashCode = hashCode * 59 + this.SupportedAssociations.GetHashCode();
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