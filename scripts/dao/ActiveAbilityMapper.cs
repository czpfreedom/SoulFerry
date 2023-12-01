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
            activeAbility.Id = obj["id"].Value<int>();
        }

        if (obj["name"] != null)
        {
            activeAbility.Name = obj["name"].Value<string>();
        }

        if (obj["castrange"] != null)
        {
            activeAbility.CastRange = obj["castrange"].Value <double>();
        }

        if (obj["basicdamage"] != null)
        {
            activeAbility.Basicdamage = obj["basicdamage"].Value<double>();
        }

        return activeAbility;
    }
}
