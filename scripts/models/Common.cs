using Godot;
using System;
using System.Text;
using System.IO;
public partial class Common
{

    public static string ROOTDIRECTORY = "D:/GodotProject/SoulFerry/";
    public enum Faction { OurFaction, FriendlyFaction, EnemyFaction }; // 我军 友军 敌军

    public enum FactionRight { AttackRight, HealRight, AcrossRight   }; // 攻击权 治疗权 跨越权

    public enum Toward { Xplus, Xminus, Yplus, Yminus }; // x轴正向，x轴负向, y轴正向， y轴负向

    public enum ChangeRoleMode { Create, Delete, Damage, Heal, ChangeFaction }; // 对角色的操作，Create为创建，Delete为删除

    public enum DisplaymentMode { Absolute, Relative }; // 位移的模式，Absolute表示绝对位移，Relative表示相对位移

    public enum ChangeBuffMode { Add, Reduce}; // 改变buff的方式，Add为添加buff，Reduce为去掉buff

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

    public enum FightStatus { BuffCalRoleStart, Move, BuffCalAfterMove,  Action , BuffCalAfterAction, MoveAfterAction, CalATB}; // 战斗状态, 分别代表角色回合开始的Buff计算，角色的移动， 角色的移动之后的Buff计算，角色的行动，角色的行动之后的Buff计算,计算ATB值

    public static double ATBIncreaseBase = 0.01; // ATB的增加基数

    public static double ATBActionNeed = 10; // 角色行动所需的ATB值
}
