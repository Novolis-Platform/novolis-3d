using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Assimp;
using Novolis.Math.Geometry;
using NumericsMatrix = System.Numerics.Matrix4x4;

namespace Novolis.ThreeD;

/// <summary>Per-vertex bone influences keyed by authoring bone name (Mixamo / FBX).</summary>
public readonly record struct AssimpNamedBoneWeight(string BoneName, float Weight);
