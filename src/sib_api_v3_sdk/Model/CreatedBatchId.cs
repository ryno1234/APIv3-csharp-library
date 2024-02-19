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
    /// CreatedBatchId
    /// </summary>
    [DataContract]
    public partial class CreatedBatchId :  IEquatable<CreatedBatchId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedBatchId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatedBatchId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedBatchId" /> class.
        /// </summary>
        /// <param name="batchId">Batch ID of the request (required).</param>
        public CreatedBatchId(decimal? batchId = default(decimal?))
        {
            // to ensure "batchId" is required (not null)
            if (batchId == null)
            {
                throw new InvalidDataException("batchId is a required property for CreatedBatchId and cannot be null");
            }
            else
            {
                this.BatchId = batchId;
            }
        }
        
        /// <summary>
        /// Batch ID of the request
        /// </summary>
        /// <value>Batch ID of the request</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public decimal? BatchId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatedBatchId {\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
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
            return this.Equals(input as CreatedBatchId);
        }

        /// <summary>
        /// Returns true if CreatedBatchId instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatedBatchId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatedBatchId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
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
                if (this.BatchId != null)
                    hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                return hashCode;
            }
        }
    }

}