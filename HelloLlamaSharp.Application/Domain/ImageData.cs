using System.Text.Json.Serialization;

namespace HelloLlamaSharp.Application.Domain;

public class ImageData
{
    [JsonPropertyName("id")] 
    public int? Id { get; set; } = 12;
    
    [JsonPropertyName("data")]
    public string Image { get; set; }
}