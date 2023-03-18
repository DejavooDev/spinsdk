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
    ///     StatusListResponseContract
    /// </summary>
    [DataContract]
    public sealed class StatusListResponseContract : IEquatable<StatusListResponseContract>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StatusListResponseContract" /> class.
        /// </summary>
        /// <param name="transactions">transactions.</param>
        /// <param name="generalResponse">generalResponse.</param>
        public StatusListResponseContract(List<BasePaymentResponseContract> transactions = default, GeneralResponseContract generalResponse = default)
        {
            Transactions = transactions;
            GeneralResponse = generalResponse;
        }

        /// <summary>
        ///     Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "Transactions", EmitDefaultValue = false)]
        public List<BasePaymentResponseContract> Transactions { get; set; }

        /// <summary>
        ///     Gets or Sets GeneralResponse
        /// </summary>
        [DataMember(Name = "GeneralResponse", EmitDefaultValue = false)]
        public GeneralResponseContract GeneralResponse { get; set; }

        /// <summary>
        ///     Returns true if StatusListResponseContract instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusListResponseContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusListResponseContract input)
        {
            if (input == null)
                return false;

            return
                (
                    Transactions == input.Transactions ||
                    (Transactions != null &&
                     input.Transactions != null &&
                     Transactions.SequenceEqual(input.Transactions))
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
            sb.Append("class StatusListResponseContract {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return Equals(input as StatusListResponseContract);
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
                if (Transactions != null)
                    hashCode = hashCode * 59 + Transactions.GetHashCode();
                if (GeneralResponse != null)
                    hashCode = hashCode * 59 + GeneralResponse.GetHashCode();
                return hashCode;
            }
        }
    }
}