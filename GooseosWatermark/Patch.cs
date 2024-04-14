using Exiled.Events.EventArgs.Player;
using HarmonyLib;
using PlayerEvent = Exiled.Events.Handlers.Player;

namespace GooseosWatermark
{
    [HarmonyPatch(typeof(PlayerEvent), nameof(PlayerEvent.OnSpawned))]
    internal static class Patch
    {
        private static void Postfix(SpawnedEventArgs ev)
        {                
            ev.Player.ShowHint(Plugin.Instance.Config.WaterMarkMessage, 99999);
        }
    }
}
