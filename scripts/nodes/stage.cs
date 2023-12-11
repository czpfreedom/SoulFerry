using Godot;
using System;
using System.Collections.Generic;

public partial class stage : Node2D
{
	private List<Role> roles;
	private List<TerrainBlock> terrainBlocks;

	private Role presentRole; // 当前行动角色

	private Common.FightStatus fightStatus;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (fightStatus == Common.FightStatus.BuffCalRoleStart) { 
		
		}

		if (fightStatus == Common.FightStatus.Move) { 
		
		}

		if (fightStatus == Common.FightStatus.BuffCalAfterMove) { 
		
		}

		if (fightStatus == Common.FightStatus.Action) { 
		
		}

		if (fightStatus == Common.FightStatus.BuffCalAfterAction) { 
			
		}

		if (fightStatus == Common.FightStatus.CalATB) {

			for (int i = 0; i < roles.Count; i++) {
				if (roles[i].checkATBActionReachAction() == 1) {
					presentRole = roles[i];
					roles[i].DecreaseATBAfterAction();
					return;
				}
			}

			for (int i = 0; i < roles.Count; i++)
			{
				roles[i].IncreaseATB();
			}
		}
	}

}
