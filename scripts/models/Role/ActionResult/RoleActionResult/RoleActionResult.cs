using Godot;
using System;

public partial class RoleActionResult : ActionResult
{
    private Role role;

    public Role Role { get => role; set => role = value; }
}
