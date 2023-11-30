using Godot;
using System;
using System.Collections.Generic;
using System.Diagnostics;

public partial class Terrain 
{
    private int id;
    private string name;
    private string description;

    private List<TerrainOption> terrainOptions;
    private List<Dictionary<Activity,String>> mapAttribute;
}
