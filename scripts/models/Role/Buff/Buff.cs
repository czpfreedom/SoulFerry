using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

using Dictionary =Godot.Collections.Dictionary;

public partial class Buff 
{
    private int attackerId;  //攻击者ID，-1视为无攻击者

    private string name;  // Buff的名字

    private List<string> tag; // TAG标签

    private Godot.Collections.Dictionary<String, String> customPparameters;    // 自定义记录参数


    private List<Trigger> trigger; // 触发条件

    private List<ActionResult> actionResults;  // 触发结果

    private double aTB;  // 持续回合数

    public int AttackerId { get => attackerId; set => attackerId = value; }
    public double ATB { get => aTB; set => aTB = value; }
    public Godot.Collections.Dictionary<string, string> CustomPparameters { get => customPparameters; set => customPparameters = value; }
    public List<string> Tag { get => tag; set => tag = value; }

    public List<ActionResult> ActionResults { get => actionResults; set => actionResults = value; }
    public string Name { get => name; set => name = value; }
    public List<Trigger> Trigger { get => trigger; set => trigger = value; }

    public Buff() {
        Tag = new List<string>();
        customPparameters = new Godot.Collections.Dictionary<string, string>();
        Trigger = new List<Trigger>();
        actionResults = new List<ActionResult>(); 
    }

}
