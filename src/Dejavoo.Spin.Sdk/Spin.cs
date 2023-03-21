namespace Dejavoo.Spin.Sdk
{
    public sealed class Spin
    {
        public static readonly Spin V2 = new();

        public static readonly Spin V3 = new();

        private Spin()
        {
        }

        public IOperationExecutor CreateExecutor() => ApiOperationExecutor.Create(null, null);
    }
}
