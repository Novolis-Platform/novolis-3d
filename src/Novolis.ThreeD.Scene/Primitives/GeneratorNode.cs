using System.Text.Json.Serialization;

namespace Novolis.ThreeD;

public sealed class GeneratorNode : SceneNode
{
    public GeneratorNode() => Name = "Generator";

    public GeneratorKind Generator { get; set; } = GeneratorKind.Cloner;
    public Guid? SourceId { get; set; }
    public Guid? TargetId { get; set; }
    public Guid? CutterId { get; set; }
    public BooleanKind BooleanKind { get; set; } = BooleanKind.Difference;
    public int Count { get; set; } = 3;
    public float[] Offset { get; set; } = [1.5f, 0, 0];
    public string Axis { get; set; } = "x";
}
