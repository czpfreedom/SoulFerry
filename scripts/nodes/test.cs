using Godot;
using System;

using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using FileAcc = Godot.FileAccess;

using System.Text;



public partial class test : Node3D
{

    public static void Writelog(string logContent)
    {
        StreamWriter stream; //写入日志内容
        //string path = AppDomain.CurrentDomain.BaseDirectory + "/logs";
        string path = "D:\\GodotProject\\SoulFerry\\logs";
        //检查物理路径是否存在，不存在则创建路径
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        stream = new StreamWriter(path + $"\\log{DateTime.Now.ToString("yyyyMMdd")}.txt", true, Encoding.Default);
        stream.Write(DateTime.Now.ToString() + ":" + logContent); stream.Write("\r\n");//追加写入stream.Flush();
        stream.Close();//一定要关闭流
    }
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        string dosomesting = "动态计算";
        //成功
        Common.Writelog($"{dosomesting}执行成功");
        //错误
        Common.Writelog($"{dosomesting}执行失败");

        /*
		string filename = "res://resources/stages/stage1.json";
        var  fl = FileAcc.Open(filename, FileAcc.ModeFlags.Read);
		string s = fl.GetAsText();


        JObject jo = (JObject)JsonConvert.DeserializeObject(s);
        string zone = jo["map"]["terrainblocks"].ToString();

        GD.Print(zone);


        JArray jArray = (JArray)JsonConvert.DeserializeObject(zone);//jsonArrayText必须是带[]数组格式字符串
        string str = jArray[0]["coordinate"].ToString();

        GD.Print(str);

        */

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
