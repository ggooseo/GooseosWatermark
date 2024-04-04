using Exiled.Events.EventArgs.Player;
using HarmonyLib;
using PlayerEvent = Exiled.Events.Handlers.Player;
using PlayerFeature = Exiled.API.Features.Player;

namespace GooseosWatermark
{
    [HarmonyPatch(typeof(PlayerFeature), nameof(PlayerFeature.ShowHint))]
    public sealed class PlayerHandler
    {
        private readonly Config config = Plugin.Instance.Config;

        public PlayerHandler() {
            PlayerEvent.Joined += OnJoined;
        }

        ~PlayerHandler()
        {
            PlayerEvent.Joined -= OnJoined;
        }

        public void OnJoined(JoinedEventArgs ev)
        {
            ShowWatermark(ev.Player);
        }

        public void ShowWatermark(PlayerFeature player)
        {
            player.ShowHint(config.WaterMarkMessage, 0);
        }
    }
}
