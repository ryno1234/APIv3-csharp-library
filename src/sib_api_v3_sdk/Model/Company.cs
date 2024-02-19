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
    /// Company Details
    /// </summary>
    [DataContract]
    public partial class Company :  IEquatable<Company>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="id">Unique company id.</param>
        /// <param name="attributes">Company attributes with values.</param>
        /// <param name="linkedContactsIds">Contact ids for contacts linked to this company.</param>
        /// <param name="linkedDealsIds">Deals ids for companies linked to this company.</param>
        public Company(string id = default(string), Object attributes = default(Object), List<int?> linkedContactsIds = default(List<int?>), List<string> linkedDealsIds = default(List<string>))
        {
            this.Id = id;
            this.Attributes = attributes;
            this.LinkedContactsIds = linkedContactsIds;
            this.LinkedDealsIds = linkedDealsIds;
        }
        
        /// <summary>
        /// Unique company id
        /// </summary>
        /// <value>Unique company id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Company attributes with values
        /// </summary>
        /// <value>Company attributes with values</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Contact ids for contacts linked to this company
        /// </summary>
        /// <value>Contact ids for contacts linked to this company</value>
        [DataMember(Name="linkedContactsIds", EmitDefaultValue=false)]
        public List<int?> LinkedContactsIds { get; set; }

        /// <summary>
        /// Deals ids for companies linked to this company
        /// </summary>
        /// <value>Deals ids for companies linked to this company</value>
        [DataMember(Name="linkedDealsIds", EmitDefaultValue=false)]
        public List<string> LinkedDealsIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  LinkedContactsIds: ").Append(LinkedContactsIds).Append("\n");
            sb.Append("  LinkedDealsIds: ").Append(LinkedDealsIds).Append("\n");
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
            return this.Equals(input as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="input">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company input)
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
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.LinkedContactsIds == input.LinkedContactsIds ||
                    this.LinkedContactsIds != null &&
                    this.LinkedContactsIds.SequenceEqual(input.LinkedContactsIds)
                ) && 
                (
                    this.LinkedDealsIds == input.LinkedDealsIds ||
                    this.LinkedDealsIds != null &&
                    this.LinkedDealsIds.SequenceEqual(input.LinkedDealsIds)
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.LinkedContactsIds != null)
                    hashCode = hashCode * 59 + this.LinkedContactsIds.GetHashCode();
                if (this.LinkedDealsIds != null)
                    hashCode = hashCode * 59 + this.LinkedDealsIds.GetHashCode();
                return hashCode;
            }
        }
    }

}