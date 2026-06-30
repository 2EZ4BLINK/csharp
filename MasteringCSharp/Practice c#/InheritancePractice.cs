using System;

namespace MasteringCSharp;


public class InheritancePractice
{
    
}

// Base Class / Parent Class / Super Class
public class Animal
{
    public void Eating()
    {
        Console.WriteLine("Eating...");
    }
}

// Derived Class / Sub Class / Child class who inherits the Base Class
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Woof Woof");
    }
}