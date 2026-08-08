#nullable disable

using System.Collections.Generic;
using SemanticVersioning;
using SPTarkov.Server.Core.Models.Spt.Mod;

using Range  = SemanticVersioning.Range;
using Semver = SemanticVersioning.Version;

namespace DLC.FemaleClothes;

public sealed record ModMetadata : IModMetadata
{
    public string ModGuid   { get; init; } = "dlc.femaleclothes";
    public string Name      { get; init; } = "DLC.FemaleClothes";
    public string Author    { get; init; } = "WUVGAWORE + Hj";
    public string License   { get; init; } = "Proprietary";
    public string Url       { get; init; } = "";
    public Semver Version    { get; init; } = new("1.0.3");
    public Range  SptVersion { get; init; } = Range.Parse("~4.1.0");
    public List<string> Contributors      { get; init; } = new();
    public List<string> Incompatibilities { get; init; } = new();
    public Dictionary<string, Range> ModDependencies { get; init; } = new()
    {
        { "com.wtt.commonlib", Range.Parse("~3.0.3") }
    };
    public bool HasPrepatcher { get; init; } = false;
}
