using System.Text.Json.Serialization;

namespace HelloLlamaSharp.Application.Domain;

public class DescribeImage
{
    [JsonPropertyName("prompt")]
    public string Prompt => "USER:[img-12]Describe the image in detail.\nASSISTANT:";
    
    [JsonPropertyName("n_predict")]
    public int NPredict => 128;
    
    [JsonPropertyName("image_data")]
    public List<ImageData> ImageData { get; set; }

    // [JsonPropertyName("stream")]
    // public bool Stream => false;
}