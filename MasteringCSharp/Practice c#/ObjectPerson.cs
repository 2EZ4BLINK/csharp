using System;

namespace MasteringCSharp
{
    internal class Person
    {
        // Field
        private string _name;
        private int _age;

        // Property
        public string Nationality {get; set;} 

        public string Name
        {
            get => _name;
            set {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Must enter a something!");
                    _name = "Default Name";
                } else
                {
                    _name = value;
                }
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if(value >= 18)
                {
                    _age = value;
                } else
                {
                    Console.WriteLine("Too young!");
                    _age = 0;
                }
            }
        }

        // Method
        public void Walk()
        {
            Console.WriteLine($"I'm {Name} {Age} y/o {Nationality} just walking");
        }
    }
}