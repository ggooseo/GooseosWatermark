using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using System.Collections.Generic;
using PlayerEvent = Exiled.Events.Handlers.Player;

namespace GooseosWatermark
{
    public class EventHandler
    {

        public EventHandler()
        {
            PlayerEvent.Joined += Joined;
        }

        ~EventHandler()
        {
            PlayerEvent.Joined -= Joined;
        }

        public void Joined(JoinedEventArgs ev)
        {
            Timing.RunCoroutine(SendHint(ev.Player));
        }

        private protected IEnumerator<float> SendHint(Player player)
        {
            for (; ; )
            {
                if (player.CurrentHint == null)
                    player.ShowHint(Plugin.Instance.Config.WaterMarkMessage, 99999);

                yield return Timing.WaitForSeconds(1);
            }
        }
    }
}
