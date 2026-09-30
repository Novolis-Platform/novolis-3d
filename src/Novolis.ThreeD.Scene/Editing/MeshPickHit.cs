using System.Numerics;

namespace Novolis.ThreeD;

public readonly record struct MeshPickHit(Guid SourceId, SceneEditMode Mode, int Index, int IndexB, float Distance);
