using Godot;
using System;

public partial class Common 
{
    public enum Faction { OurFaction, FriendlyFaction, EnemyFaction }; // 我军 友军 敌军

    public enum FactionRight { AttackRight, HealRight, AcrossRight   }; // 攻击权 治疗权 跨越权

    public enum Toward { Xplus, Xminus, Yplus, Yminus }; // x轴正向，x轴负向, y轴正向， y轴负向
}
