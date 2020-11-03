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
    /// EmailExportRecipients
    /// </summary>
    [DataContract]
    public partial class EmailExportRecipients :  IEquatable<EmailExportRecipients>
    {
        /// <summary>
        /// Type of recipients to export for a campaign
        /// </summary>
        /// <value>Type of recipients to export for a campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecipientsTypeEnum
        {
            
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,
            
            /// <summary>
            /// Enum NonClickers for value: nonClickers
            /// </summary>
            [EnumMember(Value = "nonClickers")]
            NonClickers = 2,
            
            /// <summary>
            /// Enum NonOpeners for value: nonOpeners
            /// </summary>
            [EnumMember(Value = "nonOpeners")]
            NonOpeners = 3,
            
            /// <summary>
            /// Enum Clickers for value: clickers
            /// </summary>
            [EnumMember(Value = "clickers")]
            Clickers = 4,
            
            /// <summary>
            /// Enum Openers for value: openers
            /// </summary>
            [EnumMember(Value = "openers")]
            Openers = 5,
            
            /// <summary>
            /// Enum SoftBounces for value: softBounces
            /// </summary>
            [EnumMember(Value = "softBounces")]
            SoftBounces = 6,
            
            /// <summary>
            /// Enum HardBounces for value: hardBounces
            /// </summary>
            [EnumMember(Value = "hardBounces")]
            HardBounces = 7,
            
            /// <summary>
            /// Enum Unsubscribed for value: unsubscribed
            /// </summary>
            [EnumMember(Value = "unsubscribed")]
            Unsubscribed = 8
        }

        /// <summary>
        /// Type of recipients to export for a campaign
        /// </summary>
        /// <value>Type of recipients to export for a campaign</value>
        [DataMember(Name="recipientsType", EmitDefaultValue=false)]
        public RecipientsTypeEnum RecipientsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailExportRecipients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailExportRecipients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailExportRecipients" /> class.
        /// </summary>
        /// <param name="notifyURL">Webhook called once the export process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479.</param>
        /// <param name="recipientsType">Type of recipients to export for a campaign (required).</param>
        public EmailExportRecipients(string notifyURL = default(string), RecipientsTypeEnum recipientsType = default(RecipientsTypeEnum))
        {
            // to ensure "recipientsType" is required (not null)
            if (recipientsType == null)
            {
                throw new InvalidDataException("recipientsType is a required property for EmailExportRecipients and cannot be null");
            }
            else
            {
                this.RecipientsType = recipientsType;
            }
            this.NotifyURL = notifyURL;
        }
        
        /// <summary>
        /// Webhook called once the export process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479
        /// </summary>
        /// <value>Webhook called once the export process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479</value>
        [DataMember(Name="notifyURL", EmitDefaultValue=false)]
        public string NotifyURL { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailExportRecipients {\n");
            sb.Append("  NotifyURL: ").Append(NotifyURL).Append("\n");
            sb.Append("  RecipientsType: ").Append(RecipientsType).Append("\n");
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
            return this.Equals(input as EmailExportRecipients);
        }

        /// <summary>
        /// Returns true if EmailExportRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailExportRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailExportRecipients input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotifyURL == input.NotifyURL ||
                    (this.NotifyURL != null &&
                    this.NotifyURL.Equals(input.NotifyURL))
                ) && 
                (
                    this.RecipientsType == input.RecipientsType ||
                    (this.RecipientsType != null &&
                    this.RecipientsType.Equals(input.RecipientsType))
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
                if (this.NotifyURL != null)
                    hashCode = hashCode * 59 + this.NotifyURL.GetHashCode();
                if (this.RecipientsType != null)
                    hashCode = hashCode * 59 + this.RecipientsType.GetHashCode();
                return hashCode;
            }
        }
    }

}
