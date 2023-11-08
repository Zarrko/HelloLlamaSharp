using System.Text;
using System.Text.Json;
using HelloLlamaSharp.Application.Domain;

namespace HelloLlamaSharp.Application.Clients;

public class LlamaCppClient : ILlamaCppClient
{
    private readonly IHttpClientFactory _httpClientFactory;

    public LlamaCppClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<string> DescribeImageAsync(DescribeImage image, CancellationToken token = default)
    {
        var client = _httpClientFactory.CreateClient(ClientsConstants.LlamaApi);
        var jsonRequest = JsonSerializer.Serialize(image);

        using var httpRequestMessage = new HttpRequestMessage();
        httpRequestMessage.Method = HttpMethod.Post;
        httpRequestMessage.Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        try
        {
            using var response = await client.SendAsync(httpRequestMessage, token);
            var responseBody = await response.Content.ReadAsStringAsync(token);
            return responseBody;
        }
        catch (HttpRequestException ex)
        {
            // ToDo: Handle better -- return a 400 back to request 
            throw;
        }
    }
}