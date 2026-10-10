using System.Text.Json.Serialization;

namespace Novolis.Modeling;

public sealed class CameraNode : SceneNode
{
    public CameraNode() => Name = "Camera";

    public float FovDeg { get; set; } = 45f;
    public float Near { get; set; } = 0.1f;
    public float Far { get; set; } = 1000f;
    public float[] Target { get; set; } = [0, 0, 0];
}
