using System.Text.Json.Serialization;

namespace Novolis.Modeling;

public sealed class NullNode : SceneNode
{
    public NullNode() => Name = "Null";
}
