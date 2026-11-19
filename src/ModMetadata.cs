using SPTarkov.Server.Core.Models.Spt.Mod;
using Range = SemanticVersioning.Range;

namespace ExtendedMags;

// SPT 4.1: AbstractModMetadata (class) was replaced by the IModMetadata interface.
// No 'override' keywords, and IsBundleMod is gone - bundles load automatically
// when bundles.json exists in the mod root.
public record ModMetadata : IModMetadata
{
    public string ModGuid { get; init; } = "com.gmak3r.extendedmags";
    public string Name { get; init; } = "ExtendedMags";
    public string Author { get; init; } = "GMAK3R";
    public List<string>? Contributors { get; init; } = new() { "Evo" };
    public SemanticVersioning.Version Version { get; init; } = new("4.1.6");
    public Range SptVersion { get; init; } = new("~4.1.0");
    public string License { get; init; } = "MIT";
    public bool HasPrepatcher { get; init; } = false;
    public string? Url { get; init; }
    public List<string>? Incompatibilities { get; init; }
    public Dictionary<string, Range>? ModDependencies { get; init; } = new()
    {
        { "com.wtt.commonlib", new Range("~3.0.0") }
    };
}
