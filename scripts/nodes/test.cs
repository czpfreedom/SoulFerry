using Godot;
using System;

using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using FileAcc = Godot.FileAccess;

public partial class test : Node3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		string filename = "res://resources/stages/stage1.json";
        var  fl = FileAcc.Open(filename, FileAcc.ModeFlags.Read);
		string s = fl.GetAsText();


        JObject jo = (JObject)JsonConvert.DeserializeObject(s);
        string zone = jo["map"]["terrainblocks"].ToString();

        GD.Print(zone);


        JArray jArray = (JArray)JsonConvert.DeserializeObject(zone);//jsonArrayText必须是带[]数组格式字符串
        string str = jArray[0]["coordinate"].ToString();

        GD.Print(str);



    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
