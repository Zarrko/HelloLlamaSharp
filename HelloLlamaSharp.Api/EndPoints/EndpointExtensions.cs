using HelloLlamaSharp.Api.EndPoints.Describe;

namespace HelloLlamaSharp.Api.EndPoints;

public static class EndpointExtensions
{
    public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapDescribeImage();
        return app;
    }
}