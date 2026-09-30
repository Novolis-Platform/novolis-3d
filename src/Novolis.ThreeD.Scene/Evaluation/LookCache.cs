using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Novolis.ThreeD;

/// <summary>Staged evaluation cache.</summary>
public sealed class LookCache
{
    public IReadOnlyList<EvaluatedNode> Lights { get; init; } = [];
    public IReadOnlyList<EvaluatedNode> Cameras { get; init; } = [];
    public IReadOnlyList<EvaluatedNode> Meshes { get; init; } = [];
    public IReadOnlyList<EvaluatedMesh> EvaluatedMeshes { get; init; } = [];
    public IReadOnlyList<EvaluatedNode> Materials { get; init; } = [];
    public int MeshGeneration { get; init; }
    public int LookGeneration { get; init; }
}
