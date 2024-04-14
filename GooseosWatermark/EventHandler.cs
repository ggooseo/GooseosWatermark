using Exiled.Events.EventArgs.Player;
using PlayerEvent = Exiled.Events.Handlers.Player;

namespace GooseosWatermark
{
    public class EventHandler
    {

        public EventHandler()
        {
            PlayerEvent.Spawning += OnSpawning;
        }

        ~EventHandler()
        {
            PlayerEvent.Spawning -= OnSpawning;
        }

        public void OnSpawning(SpawningEventArgs ev)
        {
            ev.Player.ShowHint(Plugin.Instance.Config.WaterMarkMessage, 99999);
        }
    }
}
