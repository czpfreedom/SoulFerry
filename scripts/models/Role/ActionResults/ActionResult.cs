using Godot;
using System;

public partial class ActionResult
{
    private AttributeActionResult attributeActionResult;
    private TerrainActionResult terrainActionResult;
    private DamageActionResult damageActionResult;
    private CreateRoleActionResult createRoleActionResult;
    private DeleteRoleActionResult deleteRoleActionResult;

    public AttributeActionResult AttributeActionResult { get => attributeActionResult; set => attributeActionResult = value; }
    public TerrainActionResult TerrainActionResult { get => terrainActionResult; set => terrainActionResult = value; }
    public DamageActionResult DamageActionResult { get => damageActionResult; set => damageActionResult = value; }
    public CreateRoleActionResult CreateRoleActionResult { get => createRoleActionResult; set => createRoleActionResult = value; }
    public DeleteRoleActionResult DeleteRoleActionResult { get => deleteRoleActionResult; set => deleteRoleActionResult = value; }

    public ActionResult() {
        attributeActionResult = new AttributeActionResult();
        terrainActionResult = new TerrainActionResult();
        damageActionResult = new DamageActionResult();
        createRoleActionResult = new CreateRoleActionResult();
        deleteRoleActionResult = new DeleteRoleActionResult();
    }
}
