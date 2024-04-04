using Exiled.API.Features;
using HarmonyLib;
using System;

namespace GooseosWatermark
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Gooseo's Watermark";
        public override string Author => "Gooseo";

        public override string Prefix => "gwm";
        public override Version Version => new(1,0,0);

        public EventHandler eventHandler { get; set; } = null!;
        public static Plugin Instance { get; set; } = null!;

        private protected Harmony Harmony = new("GooseosWatermark");

        public override void OnEnabled()
        {
            Instance = this;
            eventHandler = new();

            Harmony.PatchAll();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Harmony.UnpatchAll();

            eventHandler = null!;
            Instance = null!;
            base.OnDisabled();
        }
    }
}
