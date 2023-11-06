namespace HelloLlamaSharp.Application.Clients;

public interface ILlamaCppClient
{
    Task<string> DescribeImage(string image, CancellationToken token = default);
}