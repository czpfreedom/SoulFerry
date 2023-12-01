using Godot;
using Newtonsoft.Json.Linq;
using System;

using System.IO;
using System.Collections.Generic;

public partial class test : Node3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        //string filename = "res://resources/stages/stage1.json";

        //string filename = "D:/godot/SoulFerry/resources/stages/stage1.json";

        string filename = "D:/godot/SoulFerry/resources/abilities/activeAbility.json";

        StreamReader sr = new StreamReader(filename);

        string json = sr.ReadToEnd();

        JObject obj = JObject.Parse(json);

        if (obj["ids"] != null)
        {
            int id = obj["ids"].Value<int>();
            GD.Print(id);
        }

        if (obj["name"] != null)
        {
            string name = obj["name"].Value<string>();
            GD.Print(name);
        }
        GD.Print(1);
        if (obj["activeAbility"] != null) 
        {
            List<object> a = obj["activeAbility"].Value<List<object>>();
            //GD.Print(obj["activeAbility"].Value<List<object>>());
        }
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
