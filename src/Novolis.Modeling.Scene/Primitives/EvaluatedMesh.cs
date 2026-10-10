using System.Numerics;
using System.Text.Json.Serialization;
using Novolis.Math.Geometry;

namespace Novolis.Modeling;

/// <summary>Evaluated triangle mesh ready for viewport / further ops.</summary>
public sealed class EvaluatedMesh
{
    public required Guid SourceId { get; init; }
    public required Vector3[] Vertices { get; init; }
    public required int[] Indices { get; init; }
    public required Matrix4x4 World { get; init; }

    public EditableMesh ToEditableMesh() => new(Vertices, Indices);

    public static EvaluatedMesh FromEditable(Guid sourceId, EditableMesh mesh, Matrix4x4 world) => new()
    {
        SourceId = sourceId,
        Vertices = mesh.Vertices.ToArray(),
        Indices = mesh.Indices.ToArray(),
        World = world,
    };
}
