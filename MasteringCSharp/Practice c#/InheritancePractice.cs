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

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal Sound");
    }
}

// Derived Class / Sub Class / Child class who inherits the Base Class
public class Dog : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Woof Woof");
    }
}

// Hierarchical Inheritance where multiple classes inherits the same base class
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow Meow");
    }
}

// Multi Level Inheritance where it inherits a class that also inherits a class
public class ShihTzu : Dog
{
    public void Hyper()
    {
        Console.WriteLine("Super Hyper");
    }
}

// 4th type of Inheritance is Multiple Inheritance where a class inherits multiple class
// Example: public class A : B, C {} - but not allowed in c# but possible using Interface