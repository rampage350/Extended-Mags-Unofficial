# ExtendedMags 4.1.6 (C# port)

Install layout (SPT 4.1.6, `SPT_Runtime/user/mods/ExtendedMags/`):

    ExtendedMags/
      ExtendedMags.dll            <- build output (dotnet publish -c Release)
      bundles.json
      bundles/Mods/MAGS/*.bundle  <- copy your .bundle files here (names must match bundles.json exactly)
      db/CustomItems/Mag_mods.json

Also required: the WTT-CommonLib server mod (3.x) in SPT_Runtime/user/mods/.
Build: `dotnet publish -c Release` (needs .NET 10 SDK).
