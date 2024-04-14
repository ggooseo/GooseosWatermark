using HarmonyLib;
using System;

namespace GooseosWatermark
{
    public class Plugin : Exiled.API.Features.Plugin<Config>
    {
        public override string Name => "Gooseo's Watermark";
        public override string Author => "Gooseo";

        public override string Prefix => "gooseoswatermark";
        public override Version Version => new(1,0,0);
        public override Version RequiredExiledVersion => new(8,8,0);

        public static Plugin Instance { get; set; } = null!;

        private protected Harmony harmony;
        private protected EventHandler eventHandler;

        public override void OnEnabled()
        {
            Instance = this;
            harmony = new($"GooseosWatermark.{DateTime.UtcNow.Ticks}");
            eventHandler = new();
            harmony.PatchAll();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            harmony.UnpatchAll(harmony.Id);
            eventHandler = null!;
            harmony = null!;
            Instance = null!;

            base.OnDisabled();
        }

    }
}
