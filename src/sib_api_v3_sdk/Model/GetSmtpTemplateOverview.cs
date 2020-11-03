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
    /// GetSmtpTemplateOverview
    /// </summary>
    [DataContract]
    public partial class GetSmtpTemplateOverview :  IEquatable<GetSmtpTemplateOverview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSmtpTemplateOverview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSmtpTemplateOverview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSmtpTemplateOverview" /> class.
        /// </summary>
        /// <param name="id">ID of the template (required).</param>
        /// <param name="name">Name of the template (required).</param>
        /// <param name="subject">Subject of the template (required).</param>
        /// <param name="isActive">Status of template (true&#x3D;active, false&#x3D;inactive) (required).</param>
        /// <param name="testSent">Status of test sending for the template (true&#x3D;test email has been sent, false&#x3D;test email has not been sent) (required).</param>
        /// <param name="sender">sender (required).</param>
        /// <param name="replyTo">Email defined as the &quot;Reply to&quot; for the template (required).</param>
        /// <param name="toField">Customisation of the &quot;to&quot; field for the template (required).</param>
        /// <param name="tag">Tag of the template (required).</param>
        /// <param name="htmlContent">HTML content of the template (required).</param>
        /// <param name="createdAt">Creation UTC date-time of the template (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="modifiedAt">Last modification UTC date-time of the template (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="doiTemplate">It is true if template is a valid Double opt-in (DOI) template, otherwise it is false. This field will be available only in case of single template detail call..</param>
        public GetSmtpTemplateOverview(long? id = default(long?), string name = default(string), string subject = default(string), bool? isActive = default(bool?), bool? testSent = default(bool?), GetSmtpTemplateOverviewSender sender = default(GetSmtpTemplateOverviewSender), string replyTo = default(string), string toField = default(string), string tag = default(string), string htmlContent = default(string), DateTime? createdAt = default(DateTime?), DateTime? modifiedAt = default(DateTime?), bool? doiTemplate = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            // to ensure "isActive" is required (not null)
            if (isActive == null)
            {
                throw new InvalidDataException("isActive is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.IsActive = isActive;
            }
            // to ensure "testSent" is required (not null)
            if (testSent == null)
            {
                throw new InvalidDataException("testSent is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.TestSent = testSent;
            }
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
            // to ensure "replyTo" is required (not null)
            if (replyTo == null)
            {
                throw new InvalidDataException("replyTo is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.ReplyTo = replyTo;
            }
            // to ensure "toField" is required (not null)
            if (toField == null)
            {
                throw new InvalidDataException("toField is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.ToField = toField;
            }
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            // to ensure "htmlContent" is required (not null)
            if (htmlContent == null)
            {
                throw new InvalidDataException("htmlContent is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.HtmlContent = htmlContent;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "modifiedAt" is required (not null)
            if (modifiedAt == null)
            {
                throw new InvalidDataException("modifiedAt is a required property for GetSmtpTemplateOverview and cannot be null");
            }
            else
            {
                this.ModifiedAt = modifiedAt;
            }
            this.DoiTemplate = doiTemplate;
        }
        
        /// <summary>
        /// ID of the template
        /// </summary>
        /// <value>ID of the template</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name of the template
        /// </summary>
        /// <value>Name of the template</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Subject of the template
        /// </summary>
        /// <value>Subject of the template</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Status of template (true&#x3D;active, false&#x3D;inactive)
        /// </summary>
        /// <value>Status of template (true&#x3D;active, false&#x3D;inactive)</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Status of test sending for the template (true&#x3D;test email has been sent, false&#x3D;test email has not been sent)
        /// </summary>
        /// <value>Status of test sending for the template (true&#x3D;test email has been sent, false&#x3D;test email has not been sent)</value>
        [DataMember(Name="testSent", EmitDefaultValue=false)]
        public bool? TestSent { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public GetSmtpTemplateOverviewSender Sender { get; set; }

        /// <summary>
        /// Email defined as the &quot;Reply to&quot; for the template
        /// </summary>
        /// <value>Email defined as the &quot;Reply to&quot; for the template</value>
        [DataMember(Name="replyTo", EmitDefaultValue=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Customisation of the &quot;to&quot; field for the template
        /// </summary>
        /// <value>Customisation of the &quot;to&quot; field for the template</value>
        [DataMember(Name="toField", EmitDefaultValue=false)]
        public string ToField { get; set; }

        /// <summary>
        /// Tag of the template
        /// </summary>
        /// <value>Tag of the template</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// HTML content of the template
        /// </summary>
        /// <value>HTML content of the template</value>
        [DataMember(Name="htmlContent", EmitDefaultValue=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// Creation UTC date-time of the template (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Creation UTC date-time of the template (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Last modification UTC date-time of the template (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Last modification UTC date-time of the template (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// It is true if template is a valid Double opt-in (DOI) template, otherwise it is false. This field will be available only in case of single template detail call.
        /// </summary>
        /// <value>It is true if template is a valid Double opt-in (DOI) template, otherwise it is false. This field will be available only in case of single template detail call.</value>
        [DataMember(Name="doiTemplate", EmitDefaultValue=false)]
        public bool? DoiTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSmtpTemplateOverview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  TestSent: ").Append(TestSent).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  ToField: ").Append(ToField).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  HtmlContent: ").Append(HtmlContent).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  DoiTemplate: ").Append(DoiTemplate).Append("\n");
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
            return this.Equals(input as GetSmtpTemplateOverview);
        }

        /// <summary>
        /// Returns true if GetSmtpTemplateOverview instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSmtpTemplateOverview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSmtpTemplateOverview input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.TestSent == input.TestSent ||
                    (this.TestSent != null &&
                    this.TestSent.Equals(input.TestSent))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.ToField == input.ToField ||
                    (this.ToField != null &&
                    this.ToField.Equals(input.ToField))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.HtmlContent == input.HtmlContent ||
                    (this.HtmlContent != null &&
                    this.HtmlContent.Equals(input.HtmlContent))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.DoiTemplate == input.DoiTemplate ||
                    (this.DoiTemplate != null &&
                    this.DoiTemplate.Equals(input.DoiTemplate))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.TestSent != null)
                    hashCode = hashCode * 59 + this.TestSent.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.ToField != null)
                    hashCode = hashCode * 59 + this.ToField.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.HtmlContent != null)
                    hashCode = hashCode * 59 + this.HtmlContent.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.DoiTemplate != null)
                    hashCode = hashCode * 59 + this.DoiTemplate.GetHashCode();
                return hashCode;
            }
        }
    }

}
