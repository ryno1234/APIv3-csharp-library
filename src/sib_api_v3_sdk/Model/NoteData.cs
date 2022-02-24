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
    /// Note data to be saved
    /// </summary>
    [DataContract]
    public partial class NoteData :  IEquatable<NoteData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NoteData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteData" /> class.
        /// </summary>
        /// <param name="text">Text content of a note (required).</param>
        /// <param name="contactIds">Contact Ids linked to a note.</param>
        /// <param name="dealIds">Deal Ids linked to a note.</param>
        public NoteData(string text = default(string), List<int?> contactIds = default(List<int?>), List<string> dealIds = default(List<string>))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for NoteData and cannot be null");
            }
            else
            {
                this.Text = text;
            }
            this.ContactIds = contactIds;
            this.DealIds = dealIds;
        }
        
        /// <summary>
        /// Text content of a note
        /// </summary>
        /// <value>Text content of a note</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Contact Ids linked to a note
        /// </summary>
        /// <value>Contact Ids linked to a note</value>
        [DataMember(Name="contactIds", EmitDefaultValue=false)]
        public List<int?> ContactIds { get; set; }

        /// <summary>
        /// Deal Ids linked to a note
        /// </summary>
        /// <value>Deal Ids linked to a note</value>
        [DataMember(Name="dealIds", EmitDefaultValue=false)]
        public List<string> DealIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoteData {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ContactIds: ").Append(ContactIds).Append("\n");
            sb.Append("  DealIds: ").Append(DealIds).Append("\n");
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
            return this.Equals(input as NoteData);
        }

        /// <summary>
        /// Returns true if NoteData instances are equal
        /// </summary>
        /// <param name="input">Instance of NoteData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoteData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.ContactIds == input.ContactIds ||
                    this.ContactIds != null &&
                    this.ContactIds.SequenceEqual(input.ContactIds)
                ) && 
                (
                    this.DealIds == input.DealIds ||
                    this.DealIds != null &&
                    this.DealIds.SequenceEqual(input.DealIds)
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.ContactIds != null)
                    hashCode = hashCode * 59 + this.ContactIds.GetHashCode();
                if (this.DealIds != null)
                    hashCode = hashCode * 59 + this.DealIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
