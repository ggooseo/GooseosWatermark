using Exiled.API.Features;
using HarmonyLib;

namespace GooseosWatermark
{
    [HarmonyPatch(typeof(Player), nameof(Player.ShowHint), typeof(string), typeof(float))]
    public static class Patch
    {
        private static void Postfix(Player __instance, ref string message, float duration)
        { 
            __instance.ShowHint(message, duration);
        }
    }
}
