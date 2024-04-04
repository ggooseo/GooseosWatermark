using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using HarmonyLib;
using Player = Exiled.Events.Handlers.Player;
using PlayerFeature = Exiled.API.Features.Player;


namespace GooseosWatermark
{
    [HarmonyPatch(typeof(Player), nameof(Player.Joined), MethodType.Normal)]

    public class Patch
    {
        private Config config = Plugin.Instance.Config;

        public void PostFix(JoinedEventArgs ev)
        {
            Log.Debug("fart");
            ev.Player.ShowHint(config.WaterMarkMessage, 0);
        }
    }
}
