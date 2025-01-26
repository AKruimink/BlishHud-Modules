using System.ComponentModel.Composition;
using Blish_HUD.Modules;

namespace BHM_MouseBinds;

[Export(typeof(Module))]
public class MouseBindsModule : Module
{
    public MouseBindsModule([Import("ModuleParameters")] ModuleParameters moduleParameters) : base(moduleParameters)
    {
    }
}
