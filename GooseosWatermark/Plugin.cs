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

        public PlayerHandler playerHandler { get; set; } = null!;
        public static Plugin Instance { get; set; } = null!;

        private protected Harmony harmony = new("Gooseo's Watermark");

        public override void OnEnabled()
        {
            Instance = this;
            playerHandler = new();

            harmony.PatchAll();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            harmony.UnpatchAll();

            playerHandler = null!;
            Instance = null!;
            base.OnDisabled();
        }
    }
}
