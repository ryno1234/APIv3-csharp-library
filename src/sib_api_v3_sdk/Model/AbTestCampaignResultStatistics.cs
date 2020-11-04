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
    /// AbTestCampaignResultStatistics
    /// </summary>
    [DataContract]
    public partial class AbTestCampaignResultStatistics :  IEquatable<AbTestCampaignResultStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbTestCampaignResultStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbTestCampaignResultStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbTestCampaignResultStatistics" /> class.
        /// </summary>
        /// <param name="openers">openers (required).</param>
        /// <param name="clicks">clicks (required).</param>
        /// <param name="unsubscribed">unsubscribed (required).</param>
        /// <param name="hardBounces">hardBounces (required).</param>
        /// <param name="softBounces">softBounces (required).</param>
        /// <param name="complaints">complaints (required).</param>
        public AbTestCampaignResultStatistics(AbTestVersionStats openers = default(AbTestVersionStats), AbTestVersionStats clicks = default(AbTestVersionStats), AbTestVersionStats unsubscribed = default(AbTestVersionStats), AbTestVersionStats hardBounces = default(AbTestVersionStats), AbTestVersionStats softBounces = default(AbTestVersionStats), AbTestVersionStats complaints = default(AbTestVersionStats))
        {
            // to ensure "openers" is required (not null)
            if (openers == null)
            {
                throw new InvalidDataException("openers is a required property for AbTestCampaignResultStatistics and cannot be null");
            }
            else
            {
                this.Openers = openers;
            }
            // to ensure "clicks" is required (not null)
            if (clicks == null)
            {
                throw new InvalidDataException("clicks is a required property for AbTestCampaignResultStatistics and cannot be null");
            }
            else
            {
                this.Clicks = clicks;
            }
            // to ensure "unsubscribed" is required (not null)
            if (unsubscribed == null)
            {
                throw new InvalidDataException("unsubscribed is a required property for AbTestCampaignResultStatistics and cannot be null");
            }
            else
            {
                this.Unsubscribed = unsubscribed;
            }
            // to ensure "hardBounces" is required (not null)
            if (hardBounces == null)
            {
                throw new InvalidDataException("hardBounces is a required property for AbTestCampaignResultStatistics and cannot be null");
            }
            else
            {
                this.HardBounces = hardBounces;
            }
            // to ensure "softBounces" is required (not null)
            if (softBounces == null)
            {
                throw new InvalidDataException("softBounces is a required property for AbTestCampaignResultStatistics and cannot be null");
            }
            else
            {
                this.SoftBounces = softBounces;
            }
            // to ensure "complaints" is required (not null)
            if (complaints == null)
            {
                throw new InvalidDataException("complaints is a required property for AbTestCampaignResultStatistics and cannot be null");
            }
            else
            {
                this.Complaints = complaints;
            }
        }
        
        /// <summary>
        /// Gets or Sets Openers
        /// </summary>
        [DataMember(Name="openers", EmitDefaultValue=false)]
        public AbTestVersionStats Openers { get; set; }

        /// <summary>
        /// Gets or Sets Clicks
        /// </summary>
        [DataMember(Name="clicks", EmitDefaultValue=false)]
        public AbTestVersionStats Clicks { get; set; }

        /// <summary>
        /// Gets or Sets Unsubscribed
        /// </summary>
        [DataMember(Name="unsubscribed", EmitDefaultValue=false)]
        public AbTestVersionStats Unsubscribed { get; set; }

        /// <summary>
        /// Gets or Sets HardBounces
        /// </summary>
        [DataMember(Name="hardBounces", EmitDefaultValue=false)]
        public AbTestVersionStats HardBounces { get; set; }

        /// <summary>
        /// Gets or Sets SoftBounces
        /// </summary>
        [DataMember(Name="softBounces", EmitDefaultValue=false)]
        public AbTestVersionStats SoftBounces { get; set; }

        /// <summary>
        /// Gets or Sets Complaints
        /// </summary>
        [DataMember(Name="complaints", EmitDefaultValue=false)]
        public AbTestVersionStats Complaints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbTestCampaignResultStatistics {\n");
            sb.Append("  Openers: ").Append(Openers).Append("\n");
            sb.Append("  Clicks: ").Append(Clicks).Append("\n");
            sb.Append("  Unsubscribed: ").Append(Unsubscribed).Append("\n");
            sb.Append("  HardBounces: ").Append(HardBounces).Append("\n");
            sb.Append("  SoftBounces: ").Append(SoftBounces).Append("\n");
            sb.Append("  Complaints: ").Append(Complaints).Append("\n");
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
            return this.Equals(input as AbTestCampaignResultStatistics);
        }

        /// <summary>
        /// Returns true if AbTestCampaignResultStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of AbTestCampaignResultStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbTestCampaignResultStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Openers == input.Openers ||
                    (this.Openers != null &&
                    this.Openers.Equals(input.Openers))
                ) && 
                (
                    this.Clicks == input.Clicks ||
                    (this.Clicks != null &&
                    this.Clicks.Equals(input.Clicks))
                ) && 
                (
                    this.Unsubscribed == input.Unsubscribed ||
                    (this.Unsubscribed != null &&
                    this.Unsubscribed.Equals(input.Unsubscribed))
                ) && 
                (
                    this.HardBounces == input.HardBounces ||
                    (this.HardBounces != null &&
                    this.HardBounces.Equals(input.HardBounces))
                ) && 
                (
                    this.SoftBounces == input.SoftBounces ||
                    (this.SoftBounces != null &&
                    this.SoftBounces.Equals(input.SoftBounces))
                ) && 
                (
                    this.Complaints == input.Complaints ||
                    (this.Complaints != null &&
                    this.Complaints.Equals(input.Complaints))
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
                if (this.Openers != null)
                    hashCode = hashCode * 59 + this.Openers.GetHashCode();
                if (this.Clicks != null)
                    hashCode = hashCode * 59 + this.Clicks.GetHashCode();
                if (this.Unsubscribed != null)
                    hashCode = hashCode * 59 + this.Unsubscribed.GetHashCode();
                if (this.HardBounces != null)
                    hashCode = hashCode * 59 + this.HardBounces.GetHashCode();
                if (this.SoftBounces != null)
                    hashCode = hashCode * 59 + this.SoftBounces.GetHashCode();
                if (this.Complaints != null)
                    hashCode = hashCode * 59 + this.Complaints.GetHashCode();
                return hashCode;
            }
        }
    }

}
