using Godot;
using System;

public partial class Coordinate 
{
    private int x;
    private int y;
    private int z;
    private Common.Toward toward;  //朝向

    public Coordinate(int x, int y, int z, Common.Toward toward) {
        this.x = x;
        this.y = y;
        this.z = z;
        this.toward = toward;
    }

    public static Coordinate operator +(Coordinate a, Coordinate b    )
        => new Coordinate(a.x+b.x,a.y+b.y,0,Common.Toward.Xplus);
}
