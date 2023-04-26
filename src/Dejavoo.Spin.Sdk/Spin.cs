using System;
using Dejavoo.Spin.Sdk.Options;
using Dejavoo.Spin.Sdk.Options.Definitions;

namespace Dejavoo.Spin.Sdk
{
    public sealed class Spin
    {
        public static readonly Spin V2 = new("https://spinpos.net/spin");

        public static readonly Spin V2Test = new("https://test.spinpos.net/spin");

        private readonly string _baseUri;

        private Spin(string baseUri)
        {
            _baseUri = baseUri;
        }

        public IOperationExecutor CreateExecutor(string tpn, string apiKey, Action<OptionsSet> configure = null)
        {
            OptionsSet optionsSet = ConfigurationFactory.Configure(configure);
            {
                optionsSet.Option<ApiAccessOptions>(_ => _.BaseUrl = _baseUri);
                optionsSet.Option<AuthenticationOptions>(_ =>
                {
                    _.Tpn = tpn;
                    _.AuthKey = apiKey;
                });
            }

            return ApiOperationExecutor.Create(optionsSet);
        }
    }
}
