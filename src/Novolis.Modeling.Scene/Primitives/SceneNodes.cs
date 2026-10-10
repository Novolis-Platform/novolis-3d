using System.Text.Json.Serialization;

namespace Novolis.Modeling;

/// <summary>Base scene graph node.</summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
[JsonDerivedType(typeof(GroupNode), "group")]
[JsonDerivedType(typeof(MeshNode), "mesh")]
[JsonDerivedType(typeof(GeneratorNode), "generator")]
[JsonDerivedType(typeof(ModifierNode), "modifier")]
[JsonDerivedType(typeof(MaterialNode), "material")]
[JsonDerivedType(typeof(LightNode), "light")]
[JsonDerivedType(typeof(CameraNode), "camera")]
[JsonDerivedType(typeof(NullNode), "null")]
public abstract class SceneNode
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "Node";
    public Guid? ParentId { get; set; }
    public SceneTransform Transform { get; set; } = new();
    public bool Visible { get; set; } = true;
}
