using System.Text.Json.Serialization;

namespace HelloLlamaSharp.Application.Domain;

public class ImageDescription
{
    [JsonPropertyName("content")]
    public required string Description { get; init; }
}