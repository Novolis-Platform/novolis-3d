<!-- novolis-package-index:start -->
> **GitHub Packages shows this repository README on every package page** (upstream limitation).
> Open the **package README** for install and quick start — embedded in each .nupkg and linked below.

## Published packages

| Package | Install | Package README |
|---------|---------|----------------|
| `Novolis.ThreeD.Import.Assimp` | `dotnet add package Novolis.ThreeD.Import.Assimp` | [README](https://github.com/Novolis-Platform/novolis-3d/blob/main/src/Novolis.ThreeD.Import.Assimp/README.md) |
| `Novolis.ThreeD.Scene` | `dotnet add package Novolis.ThreeD.Scene` | [README](https://github.com/Novolis-Platform/novolis-3d/blob/main/src/Novolis.ThreeD.Scene/README.md) |

For NuGet.org and Visual Studio, the **embedded** README.md inside each package is authoritative.

<!-- novolis-package-index:end -->

<!-- novolis-marketing:start -->
<p align="center">
  <a href="https://github.com/Novolis-Platform">
    <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/logo-brand-transparent.svg" width="360" alt="Novolis"/>
  </a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/Novolis-Platform/.github/main/brand/banners/novolis-3d.svg" width="100%" alt="novolis-3d"/>
</p>

<p align="center">
  <strong>Novolis ecosystem library</strong><br/>
  Part of the Novolis platform (novolis-3d).
</p>

<p align="center">
  <a href="https://novolis-platform.github.io/.github/novolis-3d/"><img src="https://img.shields.io/badge/docs-portfolio-0a7ea3" alt="docs"/></a>
  <a href="https://github.com/Novolis-Platform/novolis-3d/actions"><img src="https://img.shields.io/github/actions/workflow/status/Novolis-Platform/novolis-3d/merge.yml?branch=main&label=merge&logo=github" alt="merge"/></a>
  <a href="https://github.com/orgs/Novolis-Platform/packages?repo_name=novolis-3d"><img src="https://img.shields.io/badge/packages-GitHub%20Packages-0a7ea3?logo=nuget" alt="packages"/></a>
  <a href="https://github.com/Novolis-Platform"><img src="https://img.shields.io/badge/org-Novolis--Platform-111827" alt="org"/></a>
</p>

<p align="center">
  <a href="https://novolis-platform.github.io/.github/novolis-3d/">Docs</a>
  ·
  <a href="https://nuget.pkg.github.com/Novolis-Platform/index.json"><code>https://nuget.pkg.github.com/Novolis-Platform/index.json</code></a>
  ·
  <a href="https://github.com/Novolis-Platform/.github/blob/main/profile/README.md">Org landing</a>
  ·
  <a href="https://github.com/Novolis-Platform/novolis-governance">Governance</a>
</p>

---
<!-- novolis-marketing:end -->
# novolis-3d

Avalonia-free ThreeD scene and asset packages for Novolis.

The repository owns the renderer-neutral scene domain. UI controls live in
`novolis-avalonia`; CAD projects into this scene through
`Novolis.Cad.SceneBridge`; renderers are composed by applications.

## Packages

| Package | Responsibility |
|---------|----------------|
| `Novolis.ThreeD.Scene` | Scene documents, nodes, evaluation, editing, and `.nov3djson` serialization |
| `Novolis.ThreeD.Import.Assimp` | Assimp-based FBX, OBJ, and glTF import |

## Boundary

`Novolis.Math.Geometry` owns mesh data structures and algorithms.
`Novolis.ThreeD.Scene` composes those values into a spatial document.
`Novolis.ThreeD.Import.Assimp` translates foreign asset files. Neither package
depends on Avalonia, rendering, simulation, CAD, or application hosts.

## Build

```powershell
dotnet restore d:\novolis\novolis-3d\Novolis.ThreeD.slnx
dotnet build d:\novolis\novolis-3d\Novolis.ThreeD.slnx
dotnet test d:\novolis\novolis-3d\tests\Novolis.ThreeD.Unit\Novolis.ThreeD.Unit.csproj
```

Package restore uses only nuget.org and GitHub Packages. For local
multi-repository iteration, use `d:\novolis\Novolis.Platform.slnx` and
ProjectReference mode; do not add a local folder feed.

## More documentation

- [Getting started](docs/getting-started.md)
- [Design](docs/design.md)
- [Release](docs/release.md)
- [Governance](https://github.com/Novolis-Platform/novolis-governance)

