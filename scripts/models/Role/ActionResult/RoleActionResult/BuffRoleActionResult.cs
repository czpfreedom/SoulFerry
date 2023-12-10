using Godot;
using System;

public partial class BuffRoleActionResult : RoleActionResult
{
    private Common.ChangeBuffMode changeBuffMode;

    private Buff buff;

    public Common.ChangeBuffMode ChangeBuffMode { get => changeBuffMode; set => changeBuffMode = value; }
    public Buff Buff { get => buff; set => buff = value; }

    public override void Excute()
    {
        if (this.ChangeBuffMode == Common.ChangeBuffMode.Add) {
            this.Role.BuffList.Add(buff);
        }

        if (this.ChangeBuffMode == Common.ChangeBuffMode.Reduce) { 
            this.Role.BuffList.Remove(buff);
        }
    }
}
