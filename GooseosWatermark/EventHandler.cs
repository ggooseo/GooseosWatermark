using Exiled.Events.EventArgs.Player;
using MEC;
using RueI.Displays;
using RueI.Elements;
using PlayerEvent = Exiled.Events.Handlers.Player;

namespace GooseosWatermark
{
    public class EventHandler
    {

        public EventHandler()
        {
            PlayerEvent.Verified += Verified;
        }

        ~EventHandler()
        {
            PlayerEvent.Verified -= Verified;
        }

        public void Verified(VerifiedEventArgs ev)
        {
            Config config = Plugin.Instance.Config;
            
            DisplayCore core = DisplayCore.Get(ev.Player.ReferenceHub);
            Display display = new(core);

            SetElement element = new(config.YPosition, config.WaterMarkMessage)
            {
                ZIndex = 10
            };
            
            display.Elements.Add(element);
            display.Update();
            core.Update();
        }
    }
}
