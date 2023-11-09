using HelloLlamaSharp.Application.Domain;
using HelloLlamaSharp.Contracts.Responses;

namespace HelloLlamaSharp.Application.Services;

public interface IDescribeImageService
{
    Task<ImageDescription> DescribeImageAsync(DescribeImage image, CancellationToken token = default);
}