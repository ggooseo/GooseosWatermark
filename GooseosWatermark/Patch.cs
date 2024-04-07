using Exiled.API.Features;
using HarmonyLib;

namespace GooseosWatermark
{
    [HarmonyPatch(typeof(Player), nameof(Player.ShowHint), typeof(string), typeof(float))]
    internal static class Patch
    {
        private static Config config = Plugin.Instance.Config;

        private static bool Prefix(Player __instance, ref string message, float duration)
        { 
            __instance.ShowHint(message, duration);
            return false;
        }
    }
}
