<!-- novolis-pkg-brand:start -->
<p align="center">
  <a href="https://github.com/Novolis-Platform/novolis-3d">
    <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/logo-icon.svg" width="72" alt="Novolis"/>
  </a>
</p>
<!-- novolis-pkg-brand:end -->

# Novolis.ThreeD.Import.Assimp

Assimp-based mesh import (FBX, OBJ, glTF, …) into `Novolis.Math.Geometry` `TriangleMesh` / `EditableMesh`. Native Assimp runtime required.

## Install

```bash
dotnet add package Novolis.ThreeD.Import.Assimp
```

## Quick start

```csharp
using Novolis.ThreeD;

var mesh = AssimpMeshImporter.ImportEditable(@"model.fbx");
```

## Related

| Package | Notes |
|---------|-------|
| [`Novolis.ThreeD.Scene`](../Novolis.ThreeD.Scene/README.md) | Scene graph for imported meshes |
| [`Novolis.Avalonia.ThreeD`](https://github.com/Novolis-Platform/novolis-avalonia/tree/main/src/Novolis.Avalonia.ThreeD) | Scene editor UI |
