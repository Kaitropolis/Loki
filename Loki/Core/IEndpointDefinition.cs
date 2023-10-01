namespace Loki.Core
{
    public interface IEndpointDefinition
    {
        void MapEndpoints(IEndpointRouteBuilder app);
    }
}
