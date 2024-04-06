using Exiled.Events.EventArgs.Player;
using HarmonyLib;
using PlayerEvent = Exiled.Events.Handlers.Player;
using Player = Exiled.API.Features.Player;

namespace GooseosWatermark
{
    [HarmonyPatch(typeof(PlayerEvent), nameof(PlayerEvent.Joined))]

    public class Patch
    {
        private static Config config = Plugin.Instance.Config;

        public static void Postfix(Player player, JoinedEventArgs ev)
        { 
            player.ShowHint(config.WaterMarkMessage, 555);
        }
    }
}
