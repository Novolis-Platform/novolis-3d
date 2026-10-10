using System.Numerics;
using System.Text.Json.Serialization;
using Novolis.Math.Geometry;

namespace Novolis.Modeling;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MeshPrimitiveKind
{
    Box,
    Sphere,
    Plane,
    Cylinder,
    Cone,
    Capsule,
    Torus,
    Pyramid,
    Disc,
    Tube,
    PlatonicTetra,
    PlatonicOcta,
    PlatonicIcosa,
    PlatonicDodeca,
    Landscape,
}
