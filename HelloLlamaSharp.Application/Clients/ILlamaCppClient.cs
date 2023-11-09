using HelloLlamaSharp.Application.Domain;
using HelloLlamaSharp.Contracts.Requests;
using HelloLlamaSharp.Contracts.Responses;

namespace HelloLlamaSharp.Application.Clients;

public interface ILlamaCppClient
{
    Task<ImageDescription> DescribeImageAsync(DescribeImage image, CancellationToken token = default);
}