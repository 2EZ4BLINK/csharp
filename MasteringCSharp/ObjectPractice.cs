using System;

namespace MyApplication
{
    internal class Person
    {
        private string _name;
        private int _age;

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
    }
}