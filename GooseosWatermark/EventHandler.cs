using Player = Exiled.Events.Handlers.Player;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Map;
using System.Linq;

namespace GooseosWatermark
{
    public class EventHandler
    {

        public EventHandler()
        {
            Player.Verified += OnVerified;
        }

        ~EventHandler() {
            Player.Verified -= OnVerified;
        }

        public void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.ShowHint(Plugin.Instance.Config.WaterMarkMessage, 999999);
        }
    }
}
