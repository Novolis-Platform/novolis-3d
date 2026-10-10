using System.Numerics;

namespace Novolis.Modeling;

public readonly record struct MeshPickHit(Guid SourceId, SceneEditMode Mode, int Index, int IndexB, float Distance);
