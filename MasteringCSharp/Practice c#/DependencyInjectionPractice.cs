using System;

namespace MasteringCSharp;


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
    private Brush _brush;
    private Mapper _map;

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