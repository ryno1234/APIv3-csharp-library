/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// SubAccountsResponseSubAccounts
    /// </summary>
    [DataContract]
    public partial class SubAccountsResponseSubAccounts :  IEquatable<SubAccountsResponseSubAccounts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountsResponseSubAccounts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubAccountsResponseSubAccounts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountsResponseSubAccounts" /> class.
        /// </summary>
        /// <param name="id">client id of sub-account organization (required).</param>
        /// <param name="companyName">Name of sub-account organization (required).</param>
        /// <param name="active">Whether organization is active or not (required).</param>
        /// <param name="createdAt">timestamp when the organization was created (required).</param>
        public SubAccountsResponseSubAccounts(long? id = default(long?), string companyName = default(string), bool? active = default(bool?), long? createdAt = default(long?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SubAccountsResponseSubAccounts and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new InvalidDataException("companyName is a required property for SubAccountsResponseSubAccounts and cannot be null");
            }
            else
            {
                this.CompanyName = companyName;
            }
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for SubAccountsResponseSubAccounts and cannot be null");
            }
            else
            {
                this.Active = active;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for SubAccountsResponseSubAccounts and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
        }
        
        /// <summary>
        /// client id of sub-account organization
        /// </summary>
        /// <value>client id of sub-account organization</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name of sub-account organization
        /// </summary>
        /// <value>Name of sub-account organization</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Whether organization is active or not
        /// </summary>
        /// <value>Whether organization is active or not</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// timestamp when the organization was created
        /// </summary>
        /// <value>timestamp when the organization was created</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccountsResponseSubAccounts {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SubAccountsResponseSubAccounts);
        }

        /// <summary>
        /// Returns true if SubAccountsResponseSubAccounts instances are equal
        /// </summary>
        /// <param name="input">Instance of SubAccountsResponseSubAccounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubAccountsResponseSubAccounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
