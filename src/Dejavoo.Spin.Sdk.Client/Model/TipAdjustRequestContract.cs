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
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Dejavoo.Spin.Sdk.Client.Model
{
    /// <summary>
    ///     TipAdjustRequestContract
    /// </summary>
    [DataContract]
    public sealed class TipAdjustRequestContract : IEquatable<TipAdjustRequestContract>
    {
        /// <summary>
        ///     Indicates electronic data capture (EDC) type.
        /// </summary>
        /// <value>Indicates electronic data capture (EDC) type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            /// <summary>
            ///     Enum Credit for value: Credit
            /// </summary>
            [EnumMember(Value = "Credit")] Credit = 1,

            /// <summary>
            ///     Enum Debit for value: Debit
            /// </summary>
            [EnumMember(Value = "Debit")] Debit = 2,

            /// <summary>
            ///     Enum EBT for value: EBT
            /// </summary>
            [EnumMember(Value = "EBT")] Ebt = 3,

            /// <summary>
            ///     Enum Card for value: Card
            /// </summary>
            [EnumMember(Value = "Card")] Card = 4,

            /// <summary>
            ///     Enum Cash for value: Cash
            /// </summary>
            [EnumMember(Value = "Cash")] Cash = 5,

            /// <summary>
            ///     Enum Check for value: Check
            /// </summary>
            [EnumMember(Value = "Check")] Check = 6,

            /// <summary>
            ///     Enum Gift for value: Gift
            /// </summary>
            [EnumMember(Value = "Gift")] Gift = 7,
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TipAdjustRequestContract" /> class.
        /// </summary>
        /// <param name="amount">Total amount of the transaction. (required).</param>
        /// <param name="tipAmount">tipAmount.</param>
        /// <param name="cardLast4">cardLast4 (required).</param>
        /// <param name="paymentType">Indicates electronic data capture (EDC) type. (required).</param>
        /// <param name="referenceId">Alphanumeric SPIn transaction identifier. Has to be unique within one batch. (required).</param>
        /// <param name="merchantNumber">
        ///     Merchant number for multi-merchant environment.   If not present in multi-merchant environment, transaction will be
        ///     cancelled..
        /// </param>
        /// <param name="tpn">Terminal profile number.  Can be used to identify the terminal in SPIn Proxy environment. (required).</param>
        /// <param name="authkey">Merchant&#x27;s authorization password. Required if no SPInToken..</param>
        /// <param name="sPInProxyTimeout">Timeout for processing transaction with SPIn proxy. If null, the default timeout will be used..</param>
        public TipAdjustRequestContract(double? amount = default, double? tipAmount = default, string cardLast4 = default,
            PaymentTypeEnum paymentType = default, string referenceId = default, int? merchantNumber = default, string tpn = default,
            string authkey = default, int? sPInProxyTimeout = default)
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
                throw new InvalidDataException("amount is a required property for TipAdjustRequestContract and cannot be null");
            Amount = amount;
            // to ensure "cardLast4" is required (not null)
            if (cardLast4 == null)
                throw new InvalidDataException("cardLast4 is a required property for TipAdjustRequestContract and cannot be null");
            CardLast4 = cardLast4;
            // to ensure "paymentType" is required (not null)
            if (paymentType == null)
                throw new InvalidDataException("paymentType is a required property for TipAdjustRequestContract and cannot be null");
            PaymentType = paymentType;
            // to ensure "referenceId" is required (not null)
            if (referenceId == null)
                throw new InvalidDataException("referenceId is a required property for TipAdjustRequestContract and cannot be null");
            ReferenceId = referenceId;
            // to ensure "tpn" is required (not null)
            if (tpn == null)
                throw new InvalidDataException("tpn is a required property for TipAdjustRequestContract and cannot be null");
            Tpn = tpn;
            TipAmount = tipAmount;
            MerchantNumber = merchantNumber;
            Authkey = authkey;
            SpInProxyTimeout = sPInProxyTimeout;
        }

        /// <summary>
        ///     Indicates electronic data capture (EDC) type.
        /// </summary>
        /// <value>Indicates electronic data capture (EDC) type.</value>
        [DataMember(Name = "PaymentType", EmitDefaultValue = false)]
        public PaymentTypeEnum PaymentType { get; set; }

        /// <summary>
        ///     Total amount of the transaction.
        /// </summary>
        /// <value>Total amount of the transaction.</value>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public double? Amount { get; set; }

        /// <summary>
        ///     Gets or Sets TipAmount
        /// </summary>
        [DataMember(Name = "TipAmount", EmitDefaultValue = false)]
        public double? TipAmount { get; set; }

        /// <summary>
        ///     Gets or Sets CardLast4
        /// </summary>
        [DataMember(Name = "CardLast4", EmitDefaultValue = false)]
        public string CardLast4 { get; set; }


        /// <summary>
        ///     Alphanumeric SPIn transaction identifier. Has to be unique within one batch.
        /// </summary>
        /// <value>Alphanumeric SPIn transaction identifier. Has to be unique within one batch.</value>
        [DataMember(Name = "ReferenceId", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        ///     Merchant number for multi-merchant environment.   If not present in multi-merchant environment, transaction will be cancelled.
        /// </summary>
        /// <value>Merchant number for multi-merchant environment.   If not present in multi-merchant environment, transaction will be cancelled.</value>
        [DataMember(Name = "MerchantNumber", EmitDefaultValue = false)]
        public int? MerchantNumber { get; set; }

        /// <summary>
        ///     Terminal profile number.  Can be used to identify the terminal in SPIn Proxy environment.
        /// </summary>
        /// <value>Terminal profile number.  Can be used to identify the terminal in SPIn Proxy environment.</value>
        [DataMember(Name = "Tpn", EmitDefaultValue = false)]
        public string Tpn { get; set; }

        /// <summary>
        ///     Merchant&#x27;s authorization password. Required if no SPInToken.
        /// </summary>
        /// <value>Merchant&#x27;s authorization password. Required if no SPInToken.</value>
        [DataMember(Name = "Authkey", EmitDefaultValue = false)]
        public string Authkey { get; set; }

        /// <summary>
        ///     Timeout for processing transaction with SPIn proxy. If null, the default timeout will be used.
        /// </summary>
        /// <value>Timeout for processing transaction with SPIn proxy. If null, the default timeout will be used.</value>
        [DataMember(Name = "SPInProxyTimeout", EmitDefaultValue = false)]
        public int? SpInProxyTimeout { get; set; }

        /// <summary>
        ///     Returns true if TipAdjustRequestContract instances are equal
        /// </summary>
        /// <param name="input">Instance of TipAdjustRequestContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipAdjustRequestContract input)
        {
            if (input == null)
                return false;

            return
                (
                    Amount == input.Amount ||
                    (Amount != null &&
                     Amount.Equals(input.Amount))
                ) &&
                (
                    TipAmount == input.TipAmount ||
                    (TipAmount != null &&
                     TipAmount.Equals(input.TipAmount))
                ) &&
                (
                    CardLast4 == input.CardLast4 ||
                    (CardLast4 != null &&
                     CardLast4.Equals(input.CardLast4))
                ) &&
                (
                    PaymentType == input.PaymentType ||
                    (PaymentType != null &&
                     PaymentType.Equals(input.PaymentType))
                ) &&
                (
                    ReferenceId == input.ReferenceId ||
                    (ReferenceId != null &&
                     ReferenceId.Equals(input.ReferenceId))
                ) &&
                (
                    MerchantNumber == input.MerchantNumber ||
                    (MerchantNumber != null &&
                     MerchantNumber.Equals(input.MerchantNumber))
                ) &&
                (
                    Tpn == input.Tpn ||
                    (Tpn != null &&
                     Tpn.Equals(input.Tpn))
                ) &&
                (
                    Authkey == input.Authkey ||
                    (Authkey != null &&
                     Authkey.Equals(input.Authkey))
                ) &&
                (
                    SpInProxyTimeout == input.SpInProxyTimeout ||
                    (SpInProxyTimeout != null &&
                     SpInProxyTimeout.Equals(input.SpInProxyTimeout))
                );
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipAdjustRequestContract {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TipAmount: ").Append(TipAmount).Append("\n");
            sb.Append("  CardLast4: ").Append(CardLast4).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  MerchantNumber: ").Append(MerchantNumber).Append("\n");
            sb.Append("  Tpn: ").Append(Tpn).Append("\n");
            sb.Append("  Authkey: ").Append(Authkey).Append("\n");
            sb.Append("  SPInProxyTimeout: ").Append(SpInProxyTimeout).Append("\n");
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
            return Equals(input as TipAdjustRequestContract);
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
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (TipAmount != null)
                    hashCode = hashCode * 59 + TipAmount.GetHashCode();
                if (CardLast4 != null)
                    hashCode = hashCode * 59 + CardLast4.GetHashCode();
                if (PaymentType != null)
                    hashCode = hashCode * 59 + PaymentType.GetHashCode();
                if (ReferenceId != null)
                    hashCode = hashCode * 59 + ReferenceId.GetHashCode();
                if (MerchantNumber != null)
                    hashCode = hashCode * 59 + MerchantNumber.GetHashCode();
                if (Tpn != null)
                    hashCode = hashCode * 59 + Tpn.GetHashCode();
                if (Authkey != null)
                    hashCode = hashCode * 59 + Authkey.GetHashCode();
                if (SpInProxyTimeout != null)
                    hashCode = hashCode * 59 + SpInProxyTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}