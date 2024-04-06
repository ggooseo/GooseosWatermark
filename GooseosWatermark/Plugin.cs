using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using HarmonyLib;
using System;

namespace GooseosWatermark
{
    public class Plugin : Exiled.API.Features.Plugin<Config>
    {
        public override string Name => "Gooseo's Watermark";
        public override string Author => "Gooseo";

        public override string Prefix => "gwm";
        public override Version Version => new(1,0,0);
        public override Version RequiredExiledVersion => new(8,8,0);

        public static Plugin Instance { get; set; } = null!;

        private protected Harmony Harmony = new("GooseosWatermark");

        public override void OnEnabled()
        {
            Instance = this;

            Harmony.PatchAll();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Harmony.UnpatchAll();

            Instance = null!;
            base.OnDisabled();
        }

    }
}
