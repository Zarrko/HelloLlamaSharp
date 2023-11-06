using System.Text.Json.Serialization;

namespace HelloLlamaSharp.Application.Domain;

public class DescribeImage
{
    [JsonPropertyName("prompt")]
    public string Prompt => "USER:Describe the image briefly and accurately.\n ASSISTANT:";
    
    [JsonPropertyName("n_predict")]
    public int NPredict => 128;
    
    [JsonPropertyName("image_data")]
    public List<ImageData> ImageData { get; set; }

    [JsonPropertyName("stream")]
    public bool Stream => false;
}