using Godot;
using System;
using System.Collections.Generic;
using System.Diagnostics;

public partial class Terrain 
{
    private int id;
    private string name;
    private string description;
    private string texturePath;

    private List<TerrainOption> terrainOptions;
    private List<Dictionary<Activity,String>> mapAttribute;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public List<TerrainOption> TerrainOptions { get => terrainOptions; set => terrainOptions = value; }
    public List<Dictionary<Activity, string>> MapAttribute { get => mapAttribute; set => mapAttribute = value; }
    public string TexturePath { get => texturePath; set => texturePath = value; }

    public Terrain() {
        terrainOptions = new List<TerrainOption>();
        mapAttribute = new List<Dictionary<Activity, string>>();
    }

}
