using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Assimp;
using Novolis.Math.Geometry;
using NumericsMatrix = System.Numerics.Matrix4x4;

namespace Novolis.ThreeD;

/// <summary>Geometry plus optional Assimp skin weights (no Humanoid retarget yet).</summary>
public sealed class AssimpNamedSkinImport
{
    public required TriangleMesh Mesh { get; init; }

    /// <summary>Length equals <see cref="TriangleMesh.VertexCount"/>; empty arrays when a vertex has no weights.</summary>
    public required IReadOnlyList<AssimpNamedBoneWeight[]> VertexWeights { get; init; }

    public bool HasSkinning => VertexWeights.Any(w => w.Length > 0);
}
