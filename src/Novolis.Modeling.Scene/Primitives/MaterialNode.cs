using System.Text.Json.Serialization;

namespace Novolis.Modeling;

public sealed class MaterialNode : SceneNode
{
    public MaterialNode() => Name = "Material";

    public float[] Color { get; set; } = [0.75f, 0.75f, 0.78f];
    public float Roughness { get; set; } = 0.45f;
    public float Metallic { get; set; }
}
