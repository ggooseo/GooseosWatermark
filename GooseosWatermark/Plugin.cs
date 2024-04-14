using Exiled.API.Features;
using System;

namespace GooseosWatermark
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Gooseo's Watermark";
        public override string Author => "Gooseo";

        public override string Prefix => "gooseoswatermark";
        public override Version Version => new(1,0,0);
        public override Version RequiredExiledVersion => new(8,8,0);

        public static Plugin Instance { get; set; } = null!;

        private protected EventHandler eventHandler;

        public override void OnEnabled()
        {
            Instance = this;
            eventHandler = new();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            eventHandler = null!;
            Instance = null!;

            base.OnDisabled();
        }

    }
}
