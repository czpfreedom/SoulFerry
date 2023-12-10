using Godot;
using System;

public partial class ChangeRoleActionResult : RoleActionResult
{
    private Common.ChangeRoleMode changeRoleMode;
    private Role roleBeCreated;
    private int hp;
    private int tp;
    private Common.Faction faction;

    public Common.ChangeRoleMode ChangeRoleMode { get => changeRoleMode; set => changeRoleMode = value; }
    public Role RoleBeCreated { get => roleBeCreated; set => roleBeCreated = value; }
    public int Hp { get => hp; set => hp = value; }
    public int Tp { get => tp; set => tp = value; }
    public Common.Faction Faction { get => faction; set => faction = value; }

    public override void Excute() {
        if (ChangeRoleMode == Common.ChangeRoleMode.Create) {
            Role = RoleBeCreated;
        }

        if (ChangeRoleMode == Common.ChangeRoleMode.Delete) {
            Role = null;
        }

        if (ChangeRoleMode == Common.ChangeRoleMode.Heal)
        {
            Role.Hp += Hp;
            Role.Tp += Tp;
        }

        if (ChangeRoleMode == Common.ChangeRoleMode.Damage)
        {
            Role.Hp -= Hp;
            Role.Tp -= Tp;
        }

        if (ChangeRoleMode == Common.ChangeRoleMode.ChangeFaction) {
            Role.Faction = Faction;
        }
    }
}
