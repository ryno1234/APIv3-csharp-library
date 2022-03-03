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
    /// CreateSmsCampaign
    /// </summary>
    [DataContract]
    public partial class CreateSmsCampaign :  IEquatable<CreateSmsCampaign>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSmsCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSmsCampaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSmsCampaign" /> class.
        /// </summary>
        /// <param name="name">Name of the campaign (required).</param>
        /// <param name="sender">Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters** (required).</param>
        /// <param name="content">Content of the message. The maximum characters used per SMS is 160, if used more than that, it will be counted as more than one SMS (required).</param>
        /// <param name="recipients">recipients.</param>
        /// <param name="scheduledAt">UTC date-time on which the campaign has to run (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result..</param>
        /// <param name="unicodeEnabled">Format of the message. It indicates whether the content should be treated as unicode or not. (default to false).</param>
        public CreateSmsCampaign(string name = default(string), string sender = default(string), string content = default(string), CreateSmsCampaignRecipients recipients = default(CreateSmsCampaignRecipients), string scheduledAt = default(string), bool? unicodeEnabled = false)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateSmsCampaign and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for CreateSmsCampaign and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for CreateSmsCampaign and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.Recipients = recipients;
            this.ScheduledAt = scheduledAt;
            // use default value if no "unicodeEnabled" provided
            if (unicodeEnabled == null)
            {
                this.UnicodeEnabled = false;
            }
            else
            {
                this.UnicodeEnabled = unicodeEnabled;
            }
        }
        
        /// <summary>
        /// Name of the campaign
        /// </summary>
        /// <value>Name of the campaign</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters**
        /// </summary>
        /// <value>Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters**</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Content of the message. The maximum characters used per SMS is 160, if used more than that, it will be counted as more than one SMS
        /// </summary>
        /// <value>Content of the message. The maximum characters used per SMS is 160, if used more than that, it will be counted as more than one SMS</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public CreateSmsCampaignRecipients Recipients { get; set; }

        /// <summary>
        /// UTC date-time on which the campaign has to run (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result.
        /// </summary>
        /// <value>UTC date-time on which the campaign has to run (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result.</value>
        [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// Format of the message. It indicates whether the content should be treated as unicode or not.
        /// </summary>
        /// <value>Format of the message. It indicates whether the content should be treated as unicode or not.</value>
        [DataMember(Name="unicodeEnabled", EmitDefaultValue=false)]
        public bool? UnicodeEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSmsCampaign {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  UnicodeEnabled: ").Append(UnicodeEnabled).Append("\n");
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
            return this.Equals(input as CreateSmsCampaign);
        }

        /// <summary>
        /// Returns true if CreateSmsCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSmsCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSmsCampaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    (this.Recipients != null &&
                    this.Recipients.Equals(input.Recipients))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.UnicodeEnabled == input.UnicodeEnabled ||
                    (this.UnicodeEnabled != null &&
                    this.UnicodeEnabled.Equals(input.UnicodeEnabled))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.UnicodeEnabled != null)
                    hashCode = hashCode * 59 + this.UnicodeEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
