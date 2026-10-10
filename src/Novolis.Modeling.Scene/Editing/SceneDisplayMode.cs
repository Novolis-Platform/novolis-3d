using System.Text.Json.Serialization;

namespace Novolis.Modeling;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SceneDisplayMode
{
    Wireframe,
    WirePoints,
    Isoline,
}
