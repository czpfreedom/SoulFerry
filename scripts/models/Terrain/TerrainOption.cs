using Godot;
using System;

public partial class TerrainOption 
{
    private int id;
    private string name;
    private bool boolvalue;
    private Terrain fatherTerrain;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public bool Boolvalue { get => boolvalue; set => boolvalue = value; }
    public Terrain FatherTerrain { get => fatherTerrain; set => fatherTerrain = value; }

    public TerrainOption() {
        fatherTerrain = null;
    }
}
