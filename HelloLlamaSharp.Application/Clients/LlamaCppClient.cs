using System.Net.Http.Json;
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

    public async Task<ImageDescription> DescribeImageAsync(DescribeImage image, CancellationToken token = default)
    {
        var client = _httpClientFactory.CreateClient(ClientsConstants.LlamaApi);
        var jsonRequest = JsonSerializer.Serialize(image);

        using var httpRequestMessage = new HttpRequestMessage();
        httpRequestMessage.Method = HttpMethod.Post;
        httpRequestMessage.Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        try
        {
            var defaultDescription = new ImageDescription { Description = "" };
            using var response = await client.SendAsync(httpRequestMessage, token);
            
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ImageDescription>(cancellationToken: token) ?? defaultDescription;
            }
            return defaultDescription;
        }
        catch (HttpRequestException ex)
        {
            // ToDo: Handle better -- return a 500 back to request.
            throw;
        }
    }
}