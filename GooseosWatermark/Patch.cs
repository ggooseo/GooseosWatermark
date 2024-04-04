using HarmonyLib;
using PlayerFeature = Exiled.API.Features.Player;


namespace GooseosWatermark
{
    [HarmonyPatch(typeof(PlayerFeature), nameof(PlayerFeature.ShowHint), MethodType.Normal)]

    public class Patch
    {
        public void PostFix(PlayerFeature player, Config config)
        {
            player.ShowHint(config.WaterMarkMessage, 0);
        }
    }
}
