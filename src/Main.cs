using System;
using System.Reflection;
using System.Threading.Tasks;

using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;

using WTTServerCommonLib;

namespace DLC.FemaleClothes;

[Injectable(TypePriority = OnLoadOrder.Preload + 2)]
public sealed class FemaleClothes(
    WTTServerCommonLib.WTTServerCommonLib wtt
) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        var assembly = Assembly.GetExecutingAssembly();

        if (wtt.CustomClothingService is null)
        {
            Console.WriteLine(
                "[DLC.FemaleClothes] CustomClothingService is not available. " +
                "Make sure WTT-ServerCommonLib is installed."
            );
            return;
        }
        await wtt.CustomClothingService.CreateCustomClothing(assembly);
    }
}
