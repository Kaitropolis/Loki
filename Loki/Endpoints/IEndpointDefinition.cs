namespace Loki.Endpoints
{
    public interface IEndpointDefinition
    {
        void DefineEndpoints(IEndpointRouteBuilder app);
    }
}
