namespace Dejavoo.Spin.Sdk.Options
{
    public interface IOptionsAccessor
    {
        bool TryGetOption<T>(out T option)
            where T : IOption;
    }
}
