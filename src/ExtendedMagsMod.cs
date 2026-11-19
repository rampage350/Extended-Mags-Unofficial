using System.Reflection;
using SPTarkov.Common.Models.Logging;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

namespace ExtendedMags;

// 4.1 removed OnLoadOrder.PostDBModLoader. GameCallbacks + 1 runs before WTT's own
// PostLoad pass, which is what applies the deferred mod-slot injection (addtoModSlots).
[Injectable(TypePriority = OnLoadOrder.GameCallbacks + 1)]
public class ExtendedMagsMod(
    WTTServerCommonLib.WTTServerCommonLib wttCommon,
    ISptLogger<ExtendedMagsMod> logger) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        var assembly = Assembly.GetExecutingAssembly();

        logger.Info("[ExtendedMags] Extended Mags 4.1.6 - Updated by _niceguy, patch by GMAK3R, developer Evo - \"All gas no brakes\"");

        // Reads db/CustomItems/*.json: clones items, adds them to mod_magazine
        // filters, creates locales and trader offers.
        await wttCommon.CustomItemServiceExtended.CreateCustomItems(assembly);

        logger.Info("[ExtendedMags] Database: Loading complete.");
    }
}
