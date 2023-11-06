namespace HelloLlamaSharp.Api;

public static class ApiEndpoints
{
    public const string ApiBase = "api";

    public static class ImageDescriber
    {
        public const string Base = $"{ApiBase}/describe";

        public const string Describe = Base;
    }
}