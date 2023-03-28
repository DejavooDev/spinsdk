using Newtonsoft.Json;

namespace Dejavoo.Spin.Sdk
{
    internal sealed class Partial<T>
    {
        [JsonIgnore] public T Body { get; set; }

        [JsonProperty(nameof(GeneralResponse))]
        public GeneralResponse GeneralResponse { get; set; }
    }
}
