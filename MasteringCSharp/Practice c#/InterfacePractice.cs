using System;

namespace MasteringCSharp;

public interface  IAnimal
{
     public void MakeSound();
     public void Eat(string food);
}

public class Pig : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Oink oink");
    }
    public void Eat(string food)
    {
        Console.WriteLine($"Eating {food}");
    }
}
