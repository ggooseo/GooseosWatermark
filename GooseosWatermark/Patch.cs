using Exiled.API.Features;
using HarmonyLib;

namespace GooseosWatermark
{
    [HarmonyPatch(typeof(Player), nameof(Player.ShowHint), typeof(string), typeof(float))]
    internal static class Patch
    {
        private static void Postfix(Player __instance, ref string message, float duration)
        {
            if (duration != 99999)
                __instance.ShowHint(message, duration);
            else
                __instance.ShowHint(Plugin.Instance.Config.WaterMarkMessage, 99999);
        }
    }
}
