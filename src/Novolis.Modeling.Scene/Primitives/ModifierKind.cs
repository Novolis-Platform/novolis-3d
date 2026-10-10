using System.Numerics;
using System.Text.Json.Serialization;
using Novolis.Math.Geometry;

namespace Novolis.Modeling;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ModifierKind
{
    Weld,
    Subdivision,
    Optimize,
    Bridge,
    Extrude,
    Bevel,
    Inset,
    Dissolve,
    Knife,
}
