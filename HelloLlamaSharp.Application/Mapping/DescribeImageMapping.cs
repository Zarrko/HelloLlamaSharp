using HelloLlamaSharp.Application.Domain;
using HelloLlamaSharp.Contracts.Requests;

namespace HelloLlamaSharp.Application.Mapping;

public static class DescribeImageMapping
{
    public static DescribeImage MapDescribeImageRequestToDomain(this DescribeImageRequest describeImageRequest)
    {
        return new DescribeImage
        {
            ImageData = new List<ImageData>(1)
            {
                new ImageData
                {
                    Image = describeImageRequest.Image
                }
            }
        };
    }
}