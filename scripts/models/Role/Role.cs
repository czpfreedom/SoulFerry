using Godot;
using System;
using System.Collections.Generic;

public partial class Role
{
    private int id;
    private string name;
    private string description; //显示名称

    // 贴图

    private Common.Faction faction; //所属阵营
    private Coordinate coordinate; // 坐标和朝向
    private double aTBvalue; // ATB值
    private int hp; // 生命值
    private int tp; // 精力值

    // 属性

    // Buff
    private List<Buff> buffList; //角色身上的Buff列表

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public Common.Faction Faction { get => faction; set => faction = value; }
    public Coordinate Coordinate { get => coordinate; set => coordinate = value; }
    public double ATBvalue { get => aTBvalue; set => aTBvalue = value; }
    public int Hp { get => hp; set => hp = value; }
    public List<Buff> BuffList { get => buffList; set => buffList = value; }
    public int Tp { get => tp; set => tp = value; }

    public void IncreaseATB() { 
        //
    }

    public int checkATBActionReachAction() {
        if (aTBvalue >= Common.ATBActionNeed) {
            return 1;
        }
        else  return 0;
    }

    public void DecreaseATBAfterAction() { 
        aTBvalue -= Common.ATBActionNeed;
    }
}
