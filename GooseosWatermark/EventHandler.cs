using Player = Exiled.Events.Handlers.Player;
using Exiled.Events.EventArgs.Player;

namespace GooseosWatermark
{
    public class EventHandler
    {

        public EventHandler()
        {
            Player.Spawned += OnSpawned;
        }

        ~EventHandler() {
            Player.Spawned -= OnSpawned;
        }

        public void OnSpawned(SpawnedEventArgs ev)
        {
            ev.Player.ShowHint("fart", 60);
        }

    }
}
