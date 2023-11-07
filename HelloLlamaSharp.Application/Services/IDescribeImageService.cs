using HelloLlamaSharp.Application.Domain;

namespace HelloLlamaSharp.Application.Services;

public interface IDescribeImageService
{
    Task<string> DescribeImage(DescribeImage image, CancellationToken token = default);
}