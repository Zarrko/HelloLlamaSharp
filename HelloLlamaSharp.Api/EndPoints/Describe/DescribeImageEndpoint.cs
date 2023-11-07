using HelloLlamaSharp.Application.Clients;
using HelloLlamaSharp.Application.Mapping;
using HelloLlamaSharp.Application.Services;
using HelloLlamaSharp.Contracts.Requests;
using HelloLlamaSharp.Contracts.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HelloLlamaSharp.Api.EndPoints.Describe;

public static class DescribeImageEndpoint
{
    public const string Name = "DescribeMovie";

    public static IEndpointRouteBuilder MapDescribeImage(this IEndpointRouteBuilder app)
    {
        app.MapPost(ApiEndpoints.ImageDescriber.Describe, async (
                DescribeImageRequest request, IDescribeImageService describeImageService,
                CancellationToken cancellationToken
            ) =>
            {
                var describeImage = request.MapDescribeImageRequestToDomain();
                var response = await describeImageService.DescribeImage(describeImage, cancellationToken);
        
                var describeImageResponse = new DescribeImageResponse { Description = response };
                return TypedResults.CreatedAtRoute(value: describeImageResponse, DescribeImageEndpoint.Name, new { id = 12 });
            })
            .WithName(Name)
            .Produces<DescribeImageResponse>(StatusCodes.Status200OK);
        
        return app;
    } 
} 