using HelloLlamaSharp.Application.Clients;
using HelloLlamaSharp.Application.Mapping;
using HelloLlamaSharp.Application.Services;
using HelloLlamaSharp.Contracts.Requests;
using HelloLlamaSharp.Contracts.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HelloLlamaSharp.Api.EndPoints.Describe;

public static class DescribeImageEndpoint
{
    public const string Name = "DescribeImage";

    public static IEndpointRouteBuilder MapDescribeImage(this IEndpointRouteBuilder app)
    {
        app.MapPost(ApiEndpoints.ImageDescriber.Describe, async (
                DescribeImageRequest request, IDescribeImageService describeImageService,
                CancellationToken cancellationToken
            ) =>
            {
                var describeImage = request.MapDescribeImageRequestToDomain();
                var imageDescription = await describeImageService.DescribeImageAsync(describeImage, cancellationToken);
        
                return TypedResults.Ok(value: new DescribeImageResponse { Description = imageDescription.Description});
            })
            .WithName(Name)
            .Produces<DescribeImageResponse>(StatusCodes.Status200OK);
        
        return app;
    } 
} 