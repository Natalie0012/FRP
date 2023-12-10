using Dalamud.Configuration;
using Dalamud.Plugin;
using System;

namespace FRP
{
    [Serializable]
    public class Configuration : IPluginConfiguration
    {
        //sewing code
        public virtual int Version { get; set; } = 0;

        public bool Enabled { get; set; } = true;

        public bool IsVisible { get; set; } = true;

        public bool OverlayVisible { get; set; } = true;

        public bool OverlayGrowUp { get; set; } = false;

        public bool OverlayShownInCombat { get; set; } = false;




        //public int Version { get; set; } = 0;

        public bool SomePropertyToBeSavedAndWithADefault { get; set; } = true;

        // the below exist just to make saving less cumbersome
        [NonSerialized]
        private DalamudPluginInterface? pluginInterface;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;
        }

        public void Save()
        {
            this.pluginInterface!.SavePluginConfig(this);
        }
    }
}
