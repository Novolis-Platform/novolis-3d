using System.Text.Json.Serialization;

namespace Novolis.ThreeD;

public sealed class NullNode : SceneNode
{
    public NullNode() => Name = "Null";
}
