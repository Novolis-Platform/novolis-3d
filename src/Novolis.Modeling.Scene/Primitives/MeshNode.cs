using System.Text.Json.Serialization;

namespace Novolis.Modeling;

public sealed class MeshNode : SceneNode
{
    public MeshNode() => Name = "Mesh";

    public MeshPrimitiveKind Primitive { get; set; } = MeshPrimitiveKind.Box;
    public float[] Size { get; set; } = [1, 1, 1];
    public int Segments { get; set; } = 16;
    public Guid? MaterialId { get; set; }

    /// <summary>Optional raw triangle soup (xyz per vertex) for baked meshes.</summary>
    public float[]? Vertices { get; set; }
    public int[]? Indices { get; set; }
}
