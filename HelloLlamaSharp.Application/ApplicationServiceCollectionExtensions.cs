using HelloLlamaSharp.Application.Clients;
using HelloLlamaSharp.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HelloLlamaSharp.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient(ClientsConstants.LlamaApi,client =>
        {
            client.BaseAddress = new Uri("http://localhost:8080/completion");
        });
        serviceCollection.AddSingleton<ILlamaCppClient, LlamaCppClient>();
        serviceCollection.AddSingleton<IDescribeImageService, DescribeImageService>();

        return serviceCollection;
    }
}