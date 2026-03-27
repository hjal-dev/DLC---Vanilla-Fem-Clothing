#nullable disable

using System.Collections.Generic;
using SemanticVersioning;
using SPTarkov.Server.Core.Models.Spt.Mod;

using Range  = SemanticVersioning.Range;
using Semver = SemanticVersioning.Version;

namespace DLC.FemaleClothes;

public sealed record ModMetadata : AbstractModMetadata
{
    public override string ModGuid   { get; init; } = "dlc.femaleclothes";
    public override string Name      { get; init; } = "DLC.FemaleClothes";
    public override string Author    { get; init; } = "WUVGAWORE + Hj + potat";
    public override string License   { get; init; } = "Proprietary";
    public override string Url       { get; init; } = "";
    public override bool? IsBundleMod { get; init; } = true;
    public override Semver Version    { get; init; } = new("1.0.0");
    public override Range  SptVersion { get; init; } = Range.Parse("~4.0.0");
    public override List<string> Contributors      { get; init; } = new();
    public override List<string> Incompatibilities { get; init; } = new();
    public override Dictionary<string, Range> ModDependencies { get; init; } = new()
    {
        { "com.wtt.commonlib", Range.Parse("~2.0.0") }
    };
}
