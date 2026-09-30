using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Novolis.ThreeD;

/// <summary>World-space evaluated node for lights/cameras/materials.</summary>
public sealed class EvaluatedNode
{
    public required SceneNode Source { get; init; }
    public required Matrix4x4 WorldMatrix { get; init; }
    public required Vector3 WorldPosition { get; init; }
}
