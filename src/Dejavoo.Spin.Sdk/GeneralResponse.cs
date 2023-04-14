using Newtonsoft.Json;

namespace Dejavoo.Spin.Sdk
{
    internal sealed class GeneralResponse
    {
        [JsonProperty(nameof(ResultCode))] public string ResultCode { get; set; }

        [JsonProperty(nameof(StatusCode))] public int StatusCode { get; set; }

        [JsonProperty(nameof(Message))] public string Message { get; set; }

        [JsonProperty(nameof(DetailedMessage))]
        public string DetailedMessage { get; set; }
    }
}
