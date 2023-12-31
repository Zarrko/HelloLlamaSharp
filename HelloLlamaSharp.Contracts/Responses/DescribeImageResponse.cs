using System.Text.Json.Serialization;

namespace HelloLlamaSharp.Contracts.Responses;

public class DescribeImageResponse
{
    [JsonPropertyName("content")]
    public required string Description { get; init; }
}