using HelloLlamaSharp.Application.Clients;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ILlamaCppClient, LlamaCppClient>();

// ToDo: Use constants class for the client names
builder.Services.AddHttpClient("LlamaCppApi",client =>
{
    client.BaseAddress = new Uri("http://localhost:8080/completion");
});

var app = builder.Build();

app.Run();