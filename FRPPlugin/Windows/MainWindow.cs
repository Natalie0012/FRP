using System;
using System.Numerics;
using Dalamud.Interface.Internal;
using Dalamud.Interface.Windowing;
using ImGuiNET;


namespace FRP.Windows;

public class MainWindow : Window, IDisposable
{
   
    private Plugin plugin;

    public MainWindow(Plugin plugin, IDalamudTextureWrap goatImage) : base(
        "Home", ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.NoScrollWithMouse)
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

    //Sewing Code Start 




    public override void Draw()
    {
        //Sewing Code Start Draw
        ImGui.Text($"Hello, world");





        ImGui.Text($"The random config bool is {this.plugin.Configuration.SomePropertyToBeSavedAndWithADefault}");

        if (ImGui.Button("Show Settings"))
        {
            this.plugin.DrawConfigUI();
        }

        if (ImGui.Button("Show Char Settings"))
        {
            this.plugin.DrawCharUI();
        }


    }
}
