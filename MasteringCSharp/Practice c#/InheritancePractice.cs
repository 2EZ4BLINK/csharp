using System;

namespace MasteringCSharp;


public class InheritancePractice
{
    
}

// Base Class / Parent Class / Super Class
public class Animal
{
    public string Name {get; set;}
    public string Breed {get; set;}

    public void Eating()
    {
        Console.WriteLine($"{Name} is eating his food");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"Animal Sound of {Name}");
    }

    public Animal(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }
}

// Derived Class / Sub Class / Child class who inherits the Base Class
public class Dog : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine($"My {base.Breed} {base.Name} did Woof Woof");
    }

    public Dog(string name, string breed) : base(name, breed)
    {
        
    }
}

// Hierarchical Inheritance where multiple classes inherits the same base class
public class Cat : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine($"My {base.Breed} {base.Name} did Meow Meow");
    }

    public Cat(string name, string breed) : base(name, breed)
    {
        
    }
}

// Multi Level Inheritance where it inherits a class that also inherits a class
public class ShihTzu : Dog
{
    public void Hyper()
    {
        Console.WriteLine("Super Hyper");
    }

    public ShihTzu(string name, string breed) : base(name, breed)
    {
        
    }
}

// 4th type of Inheritance is Multiple Inheritance where a class inherits multiple class
// Example: public class A : B, C {} - but not allowed in c# but possible using Interface