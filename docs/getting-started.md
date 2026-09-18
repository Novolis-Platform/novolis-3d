# Getting started

Restore and build the repository solution:

```powershell
dotnet restore d:\novolis\novolis-3d\Novolis.ThreeD.slnx
dotnet build d:\novolis\novolis-3d\Novolis.ThreeD.slnx
dotnet test d:\novolis\novolis-3d\tests\Novolis.ThreeD.Unit\Novolis.ThreeD.Unit.csproj
```

Consumers restore `Novolis.ThreeD.Scene` and
`Novolis.ThreeD.Import.Assimp` from GitHub Packages. The repository uses only
nuget.org and GitHub Packages; no local folder feed is supported.

For local multi-repository development, open
`d:\novolis\Novolis.Platform.slnx`, which enables the workspace
ProjectReference map without changing committed project files.
