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
    /// MasterDetailsResponsePlanInfoFeatures
    /// </summary>
    [DataContract]
    public partial class MasterDetailsResponsePlanInfoFeatures :  IEquatable<MasterDetailsResponsePlanInfoFeatures>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MasterDetailsResponsePlanInfoFeatures" /> class.
        /// </summary>
        /// <param name="name">Name of the feature.</param>
        /// <param name="unitValue">Unit value of the feature.</param>
        /// <param name="quantity">Quantity provided in the plan.</param>
        /// <param name="used">Quantity consumed by master.</param>
        /// <param name="remaining">Quantity remaining in the plan.</param>
        public MasterDetailsResponsePlanInfoFeatures(string name = default(string), string unitValue = default(string), long? quantity = default(long?), long? used = default(long?), long? remaining = default(long?))
        {
            this.Name = name;
            this.UnitValue = unitValue;
            this.Quantity = quantity;
            this.Used = used;
            this.Remaining = remaining;
        }
        
        /// <summary>
        /// Name of the feature
        /// </summary>
        /// <value>Name of the feature</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Unit value of the feature
        /// </summary>
        /// <value>Unit value of the feature</value>
        [DataMember(Name="unitValue", EmitDefaultValue=false)]
        public string UnitValue { get; set; }

        /// <summary>
        /// Quantity provided in the plan
        /// </summary>
        /// <value>Quantity provided in the plan</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// Quantity consumed by master
        /// </summary>
        /// <value>Quantity consumed by master</value>
        [DataMember(Name="used", EmitDefaultValue=false)]
        public long? Used { get; set; }

        /// <summary>
        /// Quantity remaining in the plan
        /// </summary>
        /// <value>Quantity remaining in the plan</value>
        [DataMember(Name="remaining", EmitDefaultValue=false)]
        public long? Remaining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MasterDetailsResponsePlanInfoFeatures {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UnitValue: ").Append(UnitValue).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
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
            return this.Equals(input as MasterDetailsResponsePlanInfoFeatures);
        }

        /// <summary>
        /// Returns true if MasterDetailsResponsePlanInfoFeatures instances are equal
        /// </summary>
        /// <param name="input">Instance of MasterDetailsResponsePlanInfoFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MasterDetailsResponsePlanInfoFeatures input)
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
                    this.UnitValue == input.UnitValue ||
                    (this.UnitValue != null &&
                    this.UnitValue.Equals(input.UnitValue))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
                ) && 
                (
                    this.Remaining == input.Remaining ||
                    (this.Remaining != null &&
                    this.Remaining.Equals(input.Remaining))
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
                if (this.UnitValue != null)
                    hashCode = hashCode * 59 + this.UnitValue.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Remaining != null)
                    hashCode = hashCode * 59 + this.Remaining.GetHashCode();
                return hashCode;
            }
        }
    }

}
