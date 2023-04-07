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
    ///     StatusRequestContract
    /// </summary>
    [DataContract]
    public sealed class StatusRequestContract : IEquatable<StatusRequestContract>
    {
        /// <summary>
        ///     Indicates if any of receipt copies should be returned in response.
        /// </summary>
        /// <value>Indicates if any of receipt copies should be returned in response.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GetReceiptEnum
        {
            /// <summary>
            ///     Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")] No = 1,

            /// <summary>
            ///     Enum Both for value: Both
            /// </summary>
            [EnumMember(Value = "Both")] Both = 2,

            /// <summary>
            ///     Enum Merchant for value: Merchant
            /// </summary>
            [EnumMember(Value = "Merchant")] Merchant = 3,

            /// <summary>
            ///     Enum Customer for value: Customer
            /// </summary>
            [EnumMember(Value = "Customer")] Customer = 4,
        }

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
        ///     Indicates if any of receipt copies should be printed after the transaction.
        /// </summary>
        /// <value>Indicates if any of receipt copies should be printed after the transaction.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrintReceiptEnum
        {
            /// <summary>
            ///     Enum No for value: No
            /// </summary>
            [EnumMember(Value = "No")] No = 1,

            /// <summary>
            ///     Enum Both for value: Both
            /// </summary>
            [EnumMember(Value = "Both")] Both = 2,

            /// <summary>
            ///     Enum Merchant for value: Merchant
            /// </summary>
            [EnumMember(Value = "Merchant")] Merchant = 3,

            /// <summary>
            ///     Enum Customer for value: Customer
            /// </summary>
            [EnumMember(Value = "Customer")] Customer = 4,
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="StatusRequestContract" /> class.
        /// </summary>
        /// <param name="paymentType">Indicates electronic data capture (EDC) type. (required).</param>
        /// <param name="referenceId">Alphanumeric SPIn transaction identifier. Has to be unique within one batch. (required).</param>
        /// <param name="printReceipt">Indicates if any of receipt copies should be printed after the transaction..</param>
        /// <param name="getReceipt">Indicates if any of receipt copies should be returned in response..</param>
        /// <param name="merchantNumber">
        ///     Merchant number for multi-merchant environment.   If not present in multi-merchant environment, transaction will be
        ///     cancelled..
        /// </param>
        /// <param name="captureSignature">Indicates whether customer signature should be captured or not in course of transaction..</param>
        /// <param name="tpn">Terminal profile number.  Can be used to identify the terminal in SPIn Proxy environment. (required).</param>
        /// <param name="authkey">Merchant&#x27;s authorization password. Required if no SPInToken..</param>
        /// <param name="sPInProxyTimeout">Timeout for processing transaction with SPIn proxy. If null, the default timeout will be used..</param>
        public StatusRequestContract(PaymentTypeEnum paymentType = default, string referenceId = default, PrintReceiptEnum? printReceipt = default,
            GetReceiptEnum? getReceipt = default, int? merchantNumber = default, bool? captureSignature = default, string tpn = default,
            string authkey = default, int? sPInProxyTimeout = default)
        {
            // to ensure "paymentType" is required (not null)
            if (paymentType == null)
                throw new InvalidDataException("paymentType is a required property for StatusRequestContract and cannot be null");
            PaymentType = paymentType;
            // to ensure "referenceId" is required (not null)
            if (referenceId == null)
                throw new InvalidDataException("referenceId is a required property for StatusRequestContract and cannot be null");
            ReferenceId = referenceId;
            // to ensure "tpn" is required (not null)
            if (tpn == null)
                throw new InvalidDataException("tpn is a required property for StatusRequestContract and cannot be null");
            Tpn = tpn;
            PrintReceipt = printReceipt;
            GetReceipt = getReceipt;
            MerchantNumber = merchantNumber;
            CaptureSignature = captureSignature;
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
        ///     Indicates if any of receipt copies should be printed after the transaction.
        /// </summary>
        /// <value>Indicates if any of receipt copies should be printed after the transaction.</value>
        [DataMember(Name = "PrintReceipt", EmitDefaultValue = false)]
        public PrintReceiptEnum? PrintReceipt { get; set; }

        /// <summary>
        ///     Indicates if any of receipt copies should be returned in response.
        /// </summary>
        /// <value>Indicates if any of receipt copies should be returned in response.</value>
        [DataMember(Name = "GetReceipt", EmitDefaultValue = false)]
        public GetReceiptEnum? GetReceipt { get; set; }


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
        ///     Indicates whether customer signature should be captured or not in course of transaction.
        /// </summary>
        /// <value>Indicates whether customer signature should be captured or not in course of transaction.</value>
        [DataMember(Name = "CaptureSignature", EmitDefaultValue = false)]
        public bool? CaptureSignature { get; set; }

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
        ///     Returns true if StatusRequestContract instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusRequestContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusRequestContract input)
        {
            if (input == null)
                return false;

            return
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
                    PrintReceipt == input.PrintReceipt ||
                    (PrintReceipt != null &&
                     PrintReceipt.Equals(input.PrintReceipt))
                ) &&
                (
                    GetReceipt == input.GetReceipt ||
                    (GetReceipt != null &&
                     GetReceipt.Equals(input.GetReceipt))
                ) &&
                (
                    MerchantNumber == input.MerchantNumber ||
                    (MerchantNumber != null &&
                     MerchantNumber.Equals(input.MerchantNumber))
                ) &&
                (
                    CaptureSignature == input.CaptureSignature ||
                    (CaptureSignature != null &&
                     CaptureSignature.Equals(input.CaptureSignature))
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
            sb.Append("class StatusRequestContract {\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  PrintReceipt: ").Append(PrintReceipt).Append("\n");
            sb.Append("  GetReceipt: ").Append(GetReceipt).Append("\n");
            sb.Append("  MerchantNumber: ").Append(MerchantNumber).Append("\n");
            sb.Append("  CaptureSignature: ").Append(CaptureSignature).Append("\n");
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
            return Equals(input as StatusRequestContract);
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
                if (PaymentType != null)
                    hashCode = hashCode * 59 + PaymentType.GetHashCode();
                if (ReferenceId != null)
                    hashCode = hashCode * 59 + ReferenceId.GetHashCode();
                if (PrintReceipt != null)
                    hashCode = hashCode * 59 + PrintReceipt.GetHashCode();
                if (GetReceipt != null)
                    hashCode = hashCode * 59 + GetReceipt.GetHashCode();
                if (MerchantNumber != null)
                    hashCode = hashCode * 59 + MerchantNumber.GetHashCode();
                if (CaptureSignature != null)
                    hashCode = hashCode * 59 + CaptureSignature.GetHashCode();
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