# Release

`novolis-3d` publishes its packable `Novolis.*` projects to GitHub Packages
using the Novolis CalVer scheme (`2026.1.*`). The merge workflow publishes
after a direct push to `main`.

Packages:

- `Novolis.ThreeD.Scene`
- `Novolis.ThreeD.Import.Assimp`

Consumers use nuget.org and
`https://nuget.pkg.github.com/Novolis-Platform/index.json` only. Local
multi-repository iteration uses the generated platform ProjectReference map.
