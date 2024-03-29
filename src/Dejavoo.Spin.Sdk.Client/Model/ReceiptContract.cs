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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Dejavoo.Spin.Sdk.Client.Model
{
    /// <summary>
    ///     ReceiptContract
    /// </summary>
    [DataContract]
    public sealed class ReceiptContract : IEquatable<ReceiptContract>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ReceiptContract" /> class.
        /// </summary>
        /// <param name="customer">Merchant receipt copy..</param>
        /// <param name="merchant">Customer receipt copy..</param>
        public ReceiptContract(string customer = default, string merchant = default)
        {
            Customer = customer;
            Merchant = merchant;
        }

        /// <summary>
        ///     Merchant receipt copy.
        /// </summary>
        /// <value>Merchant receipt copy.</value>
        [DataMember(Name = "Customer", EmitDefaultValue = false)]
        public string Customer { get; set; }

        /// <summary>
        ///     Customer receipt copy.
        /// </summary>
        /// <value>Customer receipt copy.</value>
        [DataMember(Name = "Merchant", EmitDefaultValue = false)]
        public string Merchant { get; set; }

        /// <summary>
        ///     Returns true if ReceiptContract instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiptContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiptContract input)
        {
            if (input == null)
                return false;

            return
                (
                    Customer == input.Customer ||
                    (Customer != null &&
                     Customer.Equals(input.Customer))
                ) &&
                (
                    Merchant == input.Merchant ||
                    (Merchant != null &&
                     Merchant.Equals(input.Merchant))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReceiptContract {\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Merchant: ").Append(Merchant).Append("\n");
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
            return Equals(input as ReceiptContract);
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
                if (Customer != null)
                    hashCode = hashCode * 59 + Customer.GetHashCode();
                if (Merchant != null)
                    hashCode = hashCode * 59 + Merchant.GetHashCode();
                return hashCode;
            }
        }
    }
}