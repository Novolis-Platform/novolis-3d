<!-- novolis-pkg-brand:start -->
[![Novolis](https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/logo-icon.png)](https://novolis-platform.github.io/.github/novolis-modeling/)

[Novolis](https://github.com/Novolis-Platform) · [Docs](https://novolis-platform.github.io/.github/novolis-modeling/) · [Source](https://github.com/Novolis-Platform/novolis-modeling)
<!-- novolis-pkg-brand:end -->

# Novolis.Modeling.Import.Assimp

Assimp-based mesh import (FBX, OBJ, glTF, …) into `Novolis.Math.Geometry` `TriangleMesh` / `EditableMesh`. Native Assimp runtime required.

## Install

```bash
dotnet add package Novolis.Modeling.Import.Assimp
```

## Quick start

```csharp
using Novolis.Modeling;

var mesh = AssimpMeshImporter.ImportEditable(@"model.fbx");
```

## Related

| Package | Notes |
|---------|-------|
| [`Novolis.Modeling.Scene`](../Novolis.Modeling.Scene/README.md) | Scene graph for imported meshes |
| [`Novolis.Avalonia.Modeling`](https://github.com/Novolis-Platform/novolis-avalonia/tree/main/src/Novolis.Avalonia.Modeling) | Scene editor UI |
