using System.Numerics;
using System.Text.Json.Serialization;
using Novolis.Math.Geometry;

namespace Novolis.ThreeD;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BooleanKind
{
    Union,
    Difference,
    Intersection,
}
