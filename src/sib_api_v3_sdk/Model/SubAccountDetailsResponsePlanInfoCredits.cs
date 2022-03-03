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
    /// Sub-account messaging quota details
    /// </summary>
    [DataContract]
    public partial class SubAccountDetailsResponsePlanInfoCredits :  IEquatable<SubAccountDetailsResponsePlanInfoCredits>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountDetailsResponsePlanInfoCredits" /> class.
        /// </summary>
        /// <param name="sms">Sms quota of the sub-account.</param>
        /// <param name="emails">emails.</param>
        public SubAccountDetailsResponsePlanInfoCredits(long? sms = default(long?), SubAccountDetailsResponsePlanInfoCreditsEmails emails = default(SubAccountDetailsResponsePlanInfoCreditsEmails))
        {
            this.Sms = sms;
            this.Emails = emails;
        }
        
        /// <summary>
        /// Sms quota of the sub-account
        /// </summary>
        /// <value>Sms quota of the sub-account</value>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public long? Sms { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public SubAccountDetailsResponsePlanInfoCreditsEmails Emails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccountDetailsResponsePlanInfoCredits {\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
            return this.Equals(input as SubAccountDetailsResponsePlanInfoCredits);
        }

        /// <summary>
        /// Returns true if SubAccountDetailsResponsePlanInfoCredits instances are equal
        /// </summary>
        /// <param name="input">Instance of SubAccountDetailsResponsePlanInfoCredits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubAccountDetailsResponsePlanInfoCredits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sms == input.Sms ||
                    (this.Sms != null &&
                    this.Sms.Equals(input.Sms))
                ) && 
                (
                    this.Emails == input.Emails ||
                    (this.Emails != null &&
                    this.Emails.Equals(input.Emails))
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
                if (this.Sms != null)
                    hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                return hashCode;
            }
        }
    }

}
