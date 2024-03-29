/* 
 * SPInAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Dejavoo.Spin.Sdk.Client.Model
{
    /// <summary>
    ///     SettleResponseContract
    /// </summary>
    [DataContract]
    public sealed class SettleResponseContract : IEquatable<SettleResponseContract>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SettleResponseContract" /> class.
        /// </summary>
        /// <param name="settleDetails">settleDetails.</param>
        /// <param name="generalResponse">generalResponse.</param>
        public SettleResponseContract(List<SettleDetailsContract> settleDetails = default, GeneralResponseContract generalResponse = default)
        {
            SettleDetails = settleDetails;
            GeneralResponse = generalResponse;
        }

        /// <summary>
        ///     Gets or Sets SettleDetails
        /// </summary>
        [DataMember(Name = "SettleDetails", EmitDefaultValue = false)]
        public List<SettleDetailsContract> SettleDetails { get; set; }

        /// <summary>
        ///     Gets or Sets GeneralResponse
        /// </summary>
        [DataMember(Name = "GeneralResponse", EmitDefaultValue = false)]
        public GeneralResponseContract GeneralResponse { get; set; }

        /// <summary>
        ///     Returns true if SettleResponseContract instances are equal
        /// </summary>
        /// <param name="input">Instance of SettleResponseContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettleResponseContract input)
        {
            if (input == null)
                return false;

            return
                (
                    SettleDetails == input.SettleDetails ||
                    (SettleDetails != null &&
                     input.SettleDetails != null &&
                     SettleDetails.SequenceEqual(input.SettleDetails))
                ) &&
                (
                    GeneralResponse == input.GeneralResponse ||
                    (GeneralResponse != null &&
                     GeneralResponse.Equals(input.GeneralResponse))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettleResponseContract {\n");
            sb.Append("  SettleDetails: ").Append(SettleDetails).Append("\n");
            sb.Append("  GeneralResponse: ").Append(GeneralResponse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as SettleResponseContract);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (SettleDetails != null)
                    hashCode = hashCode * 59 + SettleDetails.GetHashCode();
                if (GeneralResponse != null)
                    hashCode = hashCode * 59 + GeneralResponse.GetHashCode();
                return hashCode;
            }
        }
    }
}