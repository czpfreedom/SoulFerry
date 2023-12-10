using Godot;
using System;

public partial class BlockActionResult : ActionResult
{
    private TerrainBlock terrainBlock;


    public TerrainBlock TerrainBlock { get => terrainBlock; set => terrainBlock = value; }

    public BlockActionResult()
    {
        TerrainBlock = new TerrainBlock();
    }

    public void SetBlockTerrain(Terrain terrain) { 
    
    }

}
