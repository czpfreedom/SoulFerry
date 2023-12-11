using Godot;
using System;

public partial class DisplacementRoleActionResult : RoleActionResult
{
    private Coordinate coordinate;
    private Common.DisplaymentMode displayMode;

    public Coordinate Coordinate { get => coordinate; set => coordinate = value; }
    public Common.DisplaymentMode DisplayMode { get => displayMode; set => displayMode = value; }


    public override void Excute(){
        if (displayMode == Common.DisplaymentMode.Absolute) { 
            Role.Coordinate = Coordinate;
            string log = Role.Name + "移动到了" + "";
        }
        if (displayMode == Common.DisplaymentMode.Relative) {
            Role.Coordinate += Coordinate;
        }
    }
}
