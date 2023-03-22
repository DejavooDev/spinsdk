namespace Dejavoo.Spin.Sdk
{
    public sealed class Spin
    {
        public static readonly Spin V2 = new("https://test.spinpos.net/spin");
        
        private readonly string _baseUri;

        private Spin(string baseUri)
        {
            _baseUri = baseUri;
        }

        public IOperationExecutor CreateExecutor(string tpn, string apiKey) =>
            ApiOperationExecutor.Create(_baseUri, apiKey, tpn);
    }
}
