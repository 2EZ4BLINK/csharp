using System;
using System.ComponentModel;

namespace MasteringCSharp;

// Constructor
public class Brush
{
 public void Use()
    {
        Console.WriteLine("Brushing floor...");
    }}

public class Mapper
{
    public void Use()
    {
        Console.WriteLine("Mapping floor...");
    }
}

public class Clean
{
    private readonly Brush _brush;
    private readonly Mapper _map;

    public Clean(Brush brush, Mapper map)
    {
        _brush  = brush;
        _map = map;
    }

    public void DoCleaning()
    {
        _brush.Use();
        _map.Use();
    }
} 



// Setter
public class Screw
{
     public void ScrewScrews()
    {
        Console.WriteLine("Screws...");
    }
}

public class ScrewDriver
{
    public void ScrewScrews()
    {
        Console.WriteLine("Screwing screws...");
    }
}

public class AssembleComputer
{
    public Screw ScrewTool {get;set;}
    public ScrewDriver ScrewDriverTool {get;set;} 


}