using System.Text.Json.Serialization;

namespace Novolis.Modeling;

public sealed class LightNode : SceneNode
{
    public LightNode() => Name = "Light";

    public LightKind LightKind { get; set; } = LightKind.Omni;
    public float[] Color { get; set; } = [1, 1, 1];
    public float Intensity { get; set; } = 1f;
    public float? TemperatureKelvin { get; set; }
    public float ConeAngleDeg { get; set; } = 45f;
    public float PenumbraDeg { get; set; } = 5f;
    public float[] AreaSize { get; set; } = [1, 1];
    public bool CastShadows { get; set; } = true;
    public bool Enabled { get; set; } = true;
}
