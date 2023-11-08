using HelloLlamaSharp.Application.Clients;
using HelloLlamaSharp.Application.Domain;

namespace HelloLlamaSharp.Application.Services;

public class DescribeImageService : IDescribeImageService
{
    private ILlamaCppClient _llamaCppClient;

    public DescribeImageService(ILlamaCppClient llamaCppClient)
    {
        _llamaCppClient = llamaCppClient;
    }


    public Task<string> DescribeImageAsync(DescribeImage image, CancellationToken token = default)
    {
        var response = _llamaCppClient.DescribeImageAsync(image, token);
        return response;
    }
}