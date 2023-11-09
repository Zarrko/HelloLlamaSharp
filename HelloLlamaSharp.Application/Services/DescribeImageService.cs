using HelloLlamaSharp.Application.Clients;
using HelloLlamaSharp.Application.Domain;
using HelloLlamaSharp.Contracts.Responses;

namespace HelloLlamaSharp.Application.Services;

public class DescribeImageService : IDescribeImageService
{
    private ILlamaCppClient _llamaCppClient;

    public DescribeImageService(ILlamaCppClient llamaCppClient)
    {
        _llamaCppClient = llamaCppClient;
    }


    public Task<ImageDescription> DescribeImageAsync(DescribeImage image, CancellationToken token = default)
    {
        return _llamaCppClient.DescribeImageAsync(image, token);
    }
}