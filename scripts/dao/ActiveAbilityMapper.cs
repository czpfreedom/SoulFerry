using Godot;
using System;

using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public partial class ActiveAbilityMapper
{
    public ActiveAbility GetActiveAbility(string filename) {
        ActiveAbility activeAbility = new ();

        StreamReader sr = new StreamReader(filename);
        string json = sr.ReadToEnd();

        JObject obj = JObject.Parse(json);

        if (obj["id"] != null) {
            int id = obj["id"].Value<int>();
            GD.Print(id);
        }

        return activeAbility;
    }
}
