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
    /// list of blocked domains
    /// </summary>
    [DataContract]
    public partial class GetBlockedDomains :  IEquatable<GetBlockedDomains>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockedDomains" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetBlockedDomains() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockedDomains" /> class.
        /// </summary>
        /// <param name="domains">List of all blocked domains (required).</param>
        public GetBlockedDomains(List<string> domains = default(List<string>))
        {
            // to ensure "domains" is required (not null)
            if (domains == null)
            {
                throw new InvalidDataException("domains is a required property for GetBlockedDomains and cannot be null");
            }
            else
            {
                this.Domains = domains;
            }
        }
        
        /// <summary>
        /// List of all blocked domains
        /// </summary>
        /// <value>List of all blocked domains</value>
        [DataMember(Name="domains", EmitDefaultValue=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBlockedDomains {\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
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
            return this.Equals(input as GetBlockedDomains);
        }

        /// <summary>
        /// Returns true if GetBlockedDomains instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBlockedDomains to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBlockedDomains input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
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
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                return hashCode;
            }
        }
    }

}