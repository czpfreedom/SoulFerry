using Godot;
using Godot.Collections;
using System;

public partial class Buff 
{
    private int attackerId;  //攻击者ID，-1视为无攻击者
    private double ATB;  // 回合数‘


    // TAG标签

    // 自定义记录参数

    private Dictionary<String,String> customPparameters ;

    public int AttackerId { get => attackerId; set => attackerId = value; }
    public double ATB1 { get => ATB; set => ATB = value; }
    public Dictionary<string, string> CustomPparameters { get => customPparameters; set => customPparameters = value; }

    // Buff运行
    // 触发点

    public Buff() {
        customPparameters = new Dictionary<string, string>();
    }

}
