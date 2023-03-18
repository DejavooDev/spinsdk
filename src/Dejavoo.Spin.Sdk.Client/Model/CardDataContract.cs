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
    ///     CardDataContract
    /// </summary>
    [DataContract]
    public sealed class CardDataContract : IEquatable<CardDataContract>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CardDataContract" /> class.
        /// </summary>
        /// <param name="cardType">Type of Bank Card..</param>
        /// <param name="entryType">Entry method used to provide card data..</param>
        /// <param name="last4">Last 4 digits of card number..</param>
        /// <param name="first4">First 4 digits of card number..</param>
        /// <param name="name">Card holder name..</param>
        public CardDataContract(string cardType = default, string entryType = default, string last4 = default, string first4 = default,
            string name = default)
        {
            CardType = cardType;
            EntryType = entryType;
            Last4 = last4;
            First4 = first4;
            Name = name;
        }

        /// <summary>
        ///     Type of Bank Card.
        /// </summary>
        /// <value>Type of Bank Card.</value>
        [DataMember(Name = "CardType", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        ///     Entry method used to provide card data.
        /// </summary>
        /// <value>Entry method used to provide card data.</value>
        [DataMember(Name = "EntryType", EmitDefaultValue = false)]
        public string EntryType { get; set; }

        /// <summary>
        ///     Last 4 digits of card number.
        /// </summary>
        /// <value>Last 4 digits of card number.</value>
        [DataMember(Name = "Last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        ///     First 4 digits of card number.
        /// </summary>
        /// <value>First 4 digits of card number.</value>
        [DataMember(Name = "First4", EmitDefaultValue = false)]
        public string First4 { get; set; }

        /// <summary>
        ///     Card holder name.
        /// </summary>
        /// <value>Card holder name.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Returns true if CardDataContract instances are equal
        /// </summary>
        /// <param name="input">Instance of CardDataContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardDataContract input)
        {
            if (input == null)
                return false;

            return
                (
                    CardType == input.CardType ||
                    (CardType != null &&
                     CardType.Equals(input.CardType))
                ) &&
                (
                    EntryType == input.EntryType ||
                    (EntryType != null &&
                     EntryType.Equals(input.EntryType))
                ) &&
                (
                    Last4 == input.Last4 ||
                    (Last4 != null &&
                     Last4.Equals(input.Last4))
                ) &&
                (
                    First4 == input.First4 ||
                    (First4 != null &&
                     First4.Equals(input.First4))
                ) &&
                (
                    Name == input.Name ||
                    (Name != null &&
                     Name.Equals(input.Name))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardDataContract {\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  First4: ").Append(First4).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals(input as CardDataContract);
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
                if (CardType != null)
                    hashCode = hashCode * 59 + CardType.GetHashCode();
                if (EntryType != null)
                    hashCode = hashCode * 59 + EntryType.GetHashCode();
                if (Last4 != null)
                    hashCode = hashCode * 59 + Last4.GetHashCode();
                if (First4 != null)
                    hashCode = hashCode * 59 + First4.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }
    }
}