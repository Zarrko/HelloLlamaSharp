using HelloLlamaSharp.Application.Domain;
using HelloLlamaSharp.Contracts.Requests;

namespace HelloLlamaSharp.Application.Clients;

public interface ILlamaCppClient
{
    Task<string> DescribeImage(DescribeImage image, CancellationToken token = default);
}