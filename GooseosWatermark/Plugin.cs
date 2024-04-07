using HarmonyLib;
using System;

namespace GooseosWatermark
{
    public class Plugin : Exiled.API.Features.Plugin<Config>
    {
        public override string Name => "Gooseo's Watermark";
        public override string Author => "Gooseo";

        public override string Prefix => "gooseoswaternark";
        public override Version Version => new(1,0,0);
        public override Version RequiredExiledVersion => new(8,8,1);

        public static Plugin Instance { get; set; } = null!;

        private protected Harmony harmony;
        private protected EventHandler eventHandler;

        public override void OnEnabled()
        {
            Instance = this;
            harmony = new($"GooseosWatermark.{DateTime.UtcNow.Ticks}");
            harmony.PatchAll();
            eventHandler = new();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            eventHandler = null!;
            harmony.UnpatchAll(harmony.Id);


            Instance = null!;
            base.OnDisabled();
        }

    }
}
