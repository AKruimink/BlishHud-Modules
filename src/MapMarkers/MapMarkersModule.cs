using Blish_HUD.Modules;
using System.ComponentModel.Composition;

namespace BHM_MapMarkers;

[Export(typeof(Module))]
public class MapMarkersModule : Module
{
    public MapMarkersModule([Import("ModuleParameters")] ModuleParameters moduleParameters) : base(moduleParameters)
    {
    }
}