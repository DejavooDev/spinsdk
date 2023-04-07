namespace Dejavoo.Spin.Sdk
{
    public interface IGenericResponse
    {
        string AuthCode { get; }
        
        string ReferenceId { get; }
    }
}