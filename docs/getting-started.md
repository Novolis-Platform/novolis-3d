# Getting started

Restore and build the repository solution:

```powershell
dotnet restore d:\novolis\novolis-modeling\Novolis.Modeling.slnx
dotnet build d:\novolis\novolis-modeling\Novolis.Modeling.slnx
dotnet test d:\novolis\novolis-modeling\tests\Novolis.Modeling.Unit\Novolis.Modeling.Unit.csproj
```

Consumers restore `Novolis.Modeling.Scene` and
`Novolis.Modeling.Import.Assimp` from GitHub Packages. The repository uses only
nuget.org and GitHub Packages; no local folder feed is supported.

For local multi-repository development, open
`d:\novolis\Novolis.Platform.slnx`, which enables the workspace
ProjectReference map without changing committed project files.
