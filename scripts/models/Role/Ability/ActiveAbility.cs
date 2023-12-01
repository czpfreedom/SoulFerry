using Godot;
using System;

public partial class ActiveAbility : Ability
{
    private double castRange;// 释放距离
    private double basicdamage; // 伤害系数

    // 可作用对象

    public double CastRange { get => castRange; set => castRange = value; }
    public double Basicdamage { get => basicdamage; set => basicdamage = value; }
    

}
