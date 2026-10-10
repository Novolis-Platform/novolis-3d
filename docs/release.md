# Release

`novolis-modeling` publishes its packable `Novolis.*` projects to GitHub Packages
using the Novolis CalVer scheme (`2026.1.*`). The merge workflow publishes
after a direct push to `main`.

Packages:

- `Novolis.Modeling.Scene`
- `Novolis.Modeling.Import.Assimp`

Consumers use nuget.org and
`https://nuget.pkg.github.com/Novolis-Platform/index.json` only. Local
multi-repository iteration uses the generated platform ProjectReference map.
