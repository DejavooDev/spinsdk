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
    ///     PrinterRequestContract
    /// </summary>
    [DataContract]
    public sealed class PrinterRequestContract : IEquatable<PrinterRequestContract>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PrinterRequestContract" /> class.
        /// </summary>
        /// <param name="printer">printer (required).</param>
        /// <param name="tpn">Terminal profile number.  Can be used to identify the terminal in SPIn Proxy environment. (required).</param>
        /// <param name="authkey">Merchant&#x27;s authorization password. Required if no SPInToken..</param>
        /// <param name="sPInProxyTimeout">Timeout for processing transaction with SPIn proxy. If null, the default timeout will be used..</param>
        public PrinterRequestContract(string printer = default, string tpn = default, string authkey = default, int? sPInProxyTimeout = default)
        {
            // to ensure "printer" is required (not null)
            if (printer == null)
                throw new InvalidDataException("printer is a required property for PrinterRequestContract and cannot be null");
            Printer = printer;
            // to ensure "tpn" is required (not null)
            if (tpn == null)
                throw new InvalidDataException("tpn is a required property for PrinterRequestContract and cannot be null");
            Tpn = tpn;
            Authkey = authkey;
            SpInProxyTimeout = sPInProxyTimeout;
        }

        /// <summary>
        ///     Gets or Sets Printer
        /// </summary>
        [DataMember(Name = "Printer", EmitDefaultValue = false)]
        public string Printer { get; set; }

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
        ///     Returns true if PrinterRequestContract instances are equal
        /// </summary>
        /// <param name="input">Instance of PrinterRequestContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinterRequestContract input)
        {
            if (input == null)
                return false;

            return
                (
                    Printer == input.Printer ||
                    (Printer != null &&
                     Printer.Equals(input.Printer))
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
            sb.Append("class PrinterRequestContract {\n");
            sb.Append("  Printer: ").Append(Printer).Append("\n");
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
            return Equals(input as PrinterRequestContract);
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
                if (Printer != null)
                    hashCode = hashCode * 59 + Printer.GetHashCode();
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