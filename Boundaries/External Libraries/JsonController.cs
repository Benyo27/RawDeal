using System.Text.Json;

namespace RawDeal;

public static class JsonController
{
    public static T Deserialize<T>(string json)
    {
        T deserializedObject = JsonSerializer.Deserialize<T>(json) ??
            throw new JsonException("Could not deserialize object");
            
        return deserializedObject;
    }
}