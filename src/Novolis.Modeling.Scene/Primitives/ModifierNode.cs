using System.Text.Json.Serialization;

namespace Novolis.Modeling;

public sealed class ModifierNode : SceneNode
{
    public ModifierNode() => Name = "Modifier";

    public ModifierKind Modifier { get; set; } = ModifierKind.Weld;
    public Guid? InputId { get; set; }
    public float Tolerance { get; set; } = 0.001f;
    public int Levels { get; set; } = 1;
    public float Distance { get; set; } = 0.2f;
}
