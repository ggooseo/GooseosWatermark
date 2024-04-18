using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace GooseosWatermark
{
    public class Config : IConfig
    {
        public string WaterMarkMessage { get; set; } = "<size=25><color=#FB0DE9>G</color><color=#FB1DDE>o</color><color=#FB2DD3>o</color><color=#FB3DC8>s</color><color=#FB4DBD>e</color><color=#FB5DB2>o</color><color=#FB6DA7>'</color><color=#FB7D9C>s</color> <color=#FB9D86>L</color><color=#FBAD7B>a</color><color=#FBBD70>k</color><color=#FBCD65>e</color></size>";
        public int YPosition { get; set; } = 20;

        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
