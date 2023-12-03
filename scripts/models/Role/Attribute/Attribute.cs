using Godot;
using System;

public partial class Attribute 
{

    private double strength; // 力量
    private double armor; // 护甲，物防

    private double magicPower; //法强
    private double magicResist; // 法抗

    private double endurance; // 耐久，影响生命值上限
    private double fortunate; // 幸运，影响暴击率和被暴击率
    private double agility; // 零钱，影响命中率和被命中率
    private double speed; // 速度，影响角色的ATB值增加速度
    private double move; // 移动，影响角色的行动能力

    private double maxHP; // 生命值上限

    private int maxTP; // 精力值

    private int strengthInt; // 力量
    private int armorInt; // 护甲，物防

    private int magicPowerInt; //法强
    private int magicResistInt; // 法抗

    private int enduranceInt; // 耐久，影响生命值上限
    private int fortunateInt; // 幸运，影响暴击率和被暴击率
    private int agilityInt; // 零钱，影响命中率和被命中率
    private int speedInt; // 速度，影响角色的ATB值增加速度
    private int moveInt; // 移动，影响角色的行动能力

    private int maxHPInt; // 生命值上限

    public double Strength { get => strength; set => strength = value; }
    public double Armor { get => armor; set => armor = value; }
    public double MagicPower { get => magicPower; set => magicPower = value; }
    public double MagicResist { get => magicResist; set => magicResist = value; }
    public double Endurance { get => endurance; set => endurance = value; }
    public double Fortunate { get => fortunate; set => fortunate = value; }
    public double Agility { get => agility; set => agility = value; }
    public double Speed { get => speed; set => speed = value; }
    public double Move { get => move; set => move = value; }
    public double MaxHP { get => maxHP; set => maxHP = value; }
    public int StrengthInt { get => strengthInt; set => strengthInt = value; }
    public int ArmorInt { get => armorInt; set => armorInt = value; }
    public int MagicPowerInt { get => magicPowerInt; set => magicPowerInt = value; }
    public int MagicResistInt { get => magicResistInt; set => magicResistInt = value; }
    public int EnduranceInt { get => enduranceInt; set => enduranceInt = value; }
    public int FortunateInt { get => fortunateInt; set => fortunateInt = value; }
    public int AgilityInt { get => agilityInt; set => agilityInt = value; }
    public int SpeedInt { get => speedInt; set => speedInt = value; }
    public int MoveInt { get => moveInt; set => moveInt = value; }
    public int MaxHPInt { get => maxHPInt; set => maxHPInt = value; }
    public int MaxTP { get => maxTP; set => maxTP = value; }
}
