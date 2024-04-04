using Exiled.API.Interfaces;

namespace GooseosWatermark
{
    public class Config : IConfig
    {
        public string WaterMarkMessage { get; set; } = "<color=yellow>Your</color> <color=orange>Watermark</color> <voffset=100em></voffset>";

        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
