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
    /// AddUserToTeamRequest
    /// </summary>
    [DataContract]
    public partial class AddUserToTeamRequest :  IEquatable<AddUserToTeamRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserToTeamRequest" /> class.
        /// </summary>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="UserIsTeamManager">UserIsTeamManager.</param>
        /// <param name="UserRecordId">UserRecordId.</param>
        public AddUserToTeamRequest(string TeamId = default(string), bool? UserIsTeamManager = default(bool?), string UserRecordId = default(string))
        {
            this.TeamId = TeamId;
            this.UserIsTeamManager = UserIsTeamManager;
            this.UserRecordId = UserRecordId;
        }
        
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets UserIsTeamManager
        /// </summary>
        [DataMember(Name="userIsTeamManager", EmitDefaultValue=false)]
        public bool? UserIsTeamManager { get; set; }

        /// <summary>
        /// Gets or Sets UserRecordId
        /// </summary>
        [DataMember(Name="userRecordId", EmitDefaultValue=false)]
        public string UserRecordId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddUserToTeamRequest {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  UserIsTeamManager: ").Append(UserIsTeamManager).Append("\n");
            sb.Append("  UserRecordId: ").Append(UserRecordId).Append("\n");
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
            return this.Equals(input as AddUserToTeamRequest);
        }

        /// <summary>
        /// Returns true if AddUserToTeamRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddUserToTeamRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddUserToTeamRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.UserIsTeamManager == input.UserIsTeamManager ||
                    (this.UserIsTeamManager != null &&
                    this.UserIsTeamManager.Equals(input.UserIsTeamManager))
                ) && 
                (
                    this.UserRecordId == input.UserRecordId ||
                    (this.UserRecordId != null &&
                    this.UserRecordId.Equals(input.UserRecordId))
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
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.UserIsTeamManager != null)
                    hashCode = hashCode * 59 + this.UserIsTeamManager.GetHashCode();
                if (this.UserRecordId != null)
                    hashCode = hashCode * 59 + this.UserRecordId.GetHashCode();
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