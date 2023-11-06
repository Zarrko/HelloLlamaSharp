namespace HelloLlamaSharp.Contracts.Requests;

public class DescribeImageRequest
{
    public required string Image { get; init; }

    public int Id { get; init; } = new Random().Next(0, 100);
}