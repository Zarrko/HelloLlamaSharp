namespace HelloLlamaSharp.Application.Clients;

public class LlamaCppClient : ILlamaCppClient
{
    public Task<string> DescribeImage(string image, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}