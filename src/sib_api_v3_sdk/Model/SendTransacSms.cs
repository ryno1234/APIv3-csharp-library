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
    /// SendTransacSms
    /// </summary>
    [DataContract]
    public partial class SendTransacSms :  IEquatable<SendTransacSms>
    {
        /// <summary>
        /// Type of the SMS. Marketing SMS messages are those sent typically with marketing content. Transactional SMS messages are sent to individuals and are triggered in response to some action, such as a sign-up, purchase, etc.
        /// </summary>
        /// <value>Type of the SMS. Marketing SMS messages are those sent typically with marketing content. Transactional SMS messages are sent to individuals and are triggered in response to some action, such as a sign-up, purchase, etc.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Transactional for value: transactional
            /// </summary>
            [EnumMember(Value = "transactional")]
            Transactional = 1,
            
            /// <summary>
            /// Enum Marketing for value: marketing
            /// </summary>
            [EnumMember(Value = "marketing")]
            Marketing = 2
        }

        /// <summary>
        /// Type of the SMS. Marketing SMS messages are those sent typically with marketing content. Transactional SMS messages are sent to individuals and are triggered in response to some action, such as a sign-up, purchase, etc.
        /// </summary>
        /// <value>Type of the SMS. Marketing SMS messages are those sent typically with marketing content. Transactional SMS messages are sent to individuals and are triggered in response to some action, such as a sign-up, purchase, etc.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTransacSms" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendTransacSms() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTransacSms" /> class.
        /// </summary>
        /// <param name="sender">Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters** (required).</param>
        /// <param name="recipient">Mobile number to send SMS with the country code (required).</param>
        /// <param name="content">Content of the message. If more than 160 characters long, will be sent as multiple text messages (required).</param>
        /// <param name="type">Type of the SMS. Marketing SMS messages are those sent typically with marketing content. Transactional SMS messages are sent to individuals and are triggered in response to some action, such as a sign-up, purchase, etc. (default to TypeEnum.Transactional).</param>
        /// <param name="tag">Tag of the message.</param>
        /// <param name="webUrl">Webhook to call for each event triggered by the message (delivered etc.).</param>
        /// <param name="unicodeEnabled">Format of the message. It indicates whether the content should be treated as unicode or not. (default to false).</param>
        public SendTransacSms(string sender = default(string), string recipient = default(string), string content = default(string), TypeEnum? type = TypeEnum.Transactional, string tag = default(string), string webUrl = default(string), bool? unicodeEnabled = false)
        {
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for SendTransacSms and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new InvalidDataException("recipient is a required property for SendTransacSms and cannot be null");
            }
            else
            {
                this.Recipient = recipient;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for SendTransacSms and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = TypeEnum.Transactional;
            }
            else
            {
                this.Type = type;
            }
            this.Tag = tag;
            this.WebUrl = webUrl;
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
        /// Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters**
        /// </summary>
        /// <value>Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters**</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Mobile number to send SMS with the country code
        /// </summary>
        /// <value>Mobile number to send SMS with the country code</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Content of the message. If more than 160 characters long, will be sent as multiple text messages
        /// </summary>
        /// <value>Content of the message. If more than 160 characters long, will be sent as multiple text messages</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }


        /// <summary>
        /// Tag of the message
        /// </summary>
        /// <value>Tag of the message</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Webhook to call for each event triggered by the message (delivered etc.)
        /// </summary>
        /// <value>Webhook to call for each event triggered by the message (delivered etc.)</value>
        [DataMember(Name="webUrl", EmitDefaultValue=false)]
        public string WebUrl { get; set; }

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
            sb.Append("class SendTransacSms {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
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
            return this.Equals(input as SendTransacSms);
        }

        /// <summary>
        /// Returns true if SendTransacSms instances are equal
        /// </summary>
        /// <param name="input">Instance of SendTransacSms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendTransacSms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
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
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.UnicodeEnabled != null)
                    hashCode = hashCode * 59 + this.UnicodeEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
