using System;
using System.Numerics;
using Dalamud.Interface.Internal;
using Dalamud.Interface.Windowing;
using ImGuiNET;
using static Lumina.Data.Parsing.Layer.LayerCommon;
using Dalamud.Interface.GameFonts;
using Dalamud.Interface;

using Dalamud.Interface.Utility;

namespace FRP.Windows;

public class CharWindow : Window, IDisposable
{

    private Plugin plugin;

    public CharWindow(Plugin plugin, IDalamudTextureWrap goatImage) : base(
        "Char setting menu", ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse)
    {
        this.SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(375, 330),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };

        this.plugin = plugin;
    }

    public void Dispose()
    {
      
    }

    public override void Draw()
    {
        ImGui.Text($"The random config bool is {this.plugin.Configuration.SomePropertyToBeSavedAndWithADefault}");



 

    }
}
