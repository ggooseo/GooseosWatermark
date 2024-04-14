using Exiled.Events.EventArgs.Player;
using PlayerEvent = Exiled.Events.Handlers.Player;

namespace GooseosWatermark
{
    public class EventHandler
    {

        public EventHandler()
        {
            PlayerEvent.Spawned += Spawned;
        }

        ~EventHandler()
        {
            PlayerEvent.Spawned -= Spawned;
        }

        public void Spawned(SpawnedEventArgs ev)
        {
            ev.Player.ShowHint("test", 3);
        }
    }
}
