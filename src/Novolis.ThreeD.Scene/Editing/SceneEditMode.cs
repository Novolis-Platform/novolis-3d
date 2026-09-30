using System.Text.Json.Serialization;

namespace Novolis.ThreeD;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SceneEditMode
{
    Object,
    Point,
    Edge,
    Polygon,
}
