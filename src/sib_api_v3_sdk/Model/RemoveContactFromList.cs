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
    /// RemoveContactFromList
    /// </summary>
    [DataContract]
    public partial class RemoveContactFromList :  IEquatable<RemoveContactFromList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveContactFromList" /> class.
        /// </summary>
        /// <param name="emails">Required if &#39;all&#39; is false. Emails to remove from a list. You can pass a maximum of 150 emails for removal in one request..</param>
        /// <param name="ids">Mandatory if Emails are not passed, ignored otherwise. Emails to add to a list. You can pass a maximum of 150 emails for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api..</param>
        /// <param name="all">Required if none of &#39;emails&#39; or &#39;ids&#39; are passed. Remove all existing contacts from a list.  A process will be created in this scenario. You can fetch the process details to know about the progress.</param>
        public RemoveContactFromList(List<string> emails = default(List<string>), List<long?> ids = default(List<long?>), bool? all = default(bool?))
        {
            this.Emails = emails;
            this.Ids = ids;
            this.All = all;
        }
        
        /// <summary>
        /// Required if &#39;all&#39; is false. Emails to remove from a list. You can pass a maximum of 150 emails for removal in one request.
        /// </summary>
        /// <value>Required if &#39;all&#39; is false. Emails to remove from a list. You can pass a maximum of 150 emails for removal in one request.</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Mandatory if Emails are not passed, ignored otherwise. Emails to add to a list. You can pass a maximum of 150 emails for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api.
        /// </summary>
        /// <value>Mandatory if Emails are not passed, ignored otherwise. Emails to add to a list. You can pass a maximum of 150 emails for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api.</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// Required if none of &#39;emails&#39; or &#39;ids&#39; are passed. Remove all existing contacts from a list.  A process will be created in this scenario. You can fetch the process details to know about the progress
        /// </summary>
        /// <value>Required if none of &#39;emails&#39; or &#39;ids&#39; are passed. Remove all existing contacts from a list.  A process will be created in this scenario. You can fetch the process details to know about the progress</value>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public bool? All { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveContactFromList {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
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
            return this.Equals(input as RemoveContactFromList);
        }

        /// <summary>
        /// Returns true if RemoveContactFromList instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveContactFromList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveContactFromList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
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
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
                return hashCode;
            }
        }
    }

}
