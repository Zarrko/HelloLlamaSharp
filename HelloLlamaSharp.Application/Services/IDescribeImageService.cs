using HelloLlamaSharp.Application.Domain;

namespace HelloLlamaSharp.Application.Services;

public interface IDescribeImageService
{
    Task<string> DescribeImageAsync(DescribeImage image, CancellationToken token = default);
}