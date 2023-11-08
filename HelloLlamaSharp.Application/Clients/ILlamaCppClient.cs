using HelloLlamaSharp.Application.Domain;
using HelloLlamaSharp.Contracts.Requests;

namespace HelloLlamaSharp.Application.Clients;

public interface ILlamaCppClient
{
    Task<string> DescribeImageAsync(DescribeImage image, CancellationToken token = default);
}