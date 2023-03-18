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

namespace Dejavoo.Spin.Sdk.Client.Model
{
    /// <summary>
    ///     SettleRequestContract
    /// </summary>
    [DataContract]
    public sealed class SettleRequestContract : IEquatable<SettleRequestContract>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SettleRequestContract" /> class.
        /// </summary>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="getReceipt">getReceipt.</param>
        /// <param name="tpn">Terminal profile number.  Can be used to identify the terminal in SPIn Proxy environment. (required).</param>
        /// <param name="authkey">Merchant&#x27;s authorization password. Required if no SPInToken..</param>
        /// <param name="sPInProxyTimeout">Timeout for processing transaction with SPIn proxy. If null, the default timeout will be used..</param>
        public SettleRequestContract(string referenceId = default, bool? getReceipt = default, string tpn = default, string authkey = default,
            int? sPInProxyTimeout = default)
        {
            // to ensure "tpn" is required (not null)
            if (tpn == null)
                throw new InvalidDataException("tpn is a required property for SettleRequestContract and cannot be null");
            Tpn = tpn;
            ReferenceId = referenceId;
            GetReceipt = getReceipt;
            Authkey = authkey;
            SpInProxyTimeout = sPInProxyTimeout;
        }

        /// <summary>
        ///     Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "ReferenceId", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        ///     Gets or Sets GetReceipt
        /// </summary>
        [DataMember(Name = "GetReceipt", EmitDefaultValue = false)]
        public bool? GetReceipt { get; set; }

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
        ///     Returns true if SettleRequestContract instances are equal
        /// </summary>
        /// <param name="input">Instance of SettleRequestContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettleRequestContract input)
        {
            if (input == null)
                return false;

            return
                (
                    ReferenceId == input.ReferenceId ||
                    (ReferenceId != null &&
                     ReferenceId.Equals(input.ReferenceId))
                ) &&
                (
                    GetReceipt == input.GetReceipt ||
                    (GetReceipt != null &&
                     GetReceipt.Equals(input.GetReceipt))
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
            sb.Append("class SettleRequestContract {\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  GetReceipt: ").Append(GetReceipt).Append("\n");
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
            return Equals(input as SettleRequestContract);
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
                if (ReferenceId != null)
                    hashCode = hashCode * 59 + ReferenceId.GetHashCode();
                if (GetReceipt != null)
                    hashCode = hashCode * 59 + GetReceipt.GetHashCode();
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