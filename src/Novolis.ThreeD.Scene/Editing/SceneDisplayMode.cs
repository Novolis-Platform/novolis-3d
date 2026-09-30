using System.Text.Json.Serialization;

namespace Novolis.ThreeD;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SceneDisplayMode
{
    Wireframe,
    WirePoints,
    Isoline,
}
