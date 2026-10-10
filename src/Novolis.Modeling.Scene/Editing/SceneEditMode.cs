using System.Text.Json.Serialization;

namespace Novolis.Modeling;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SceneEditMode
{
    Object,
    Point,
    Edge,
    Polygon,
}
