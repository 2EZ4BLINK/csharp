using System;
using System.Diagnostics.Contracts;

namespace MasteringCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program:");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Adventure Game");
            Console.WriteLine("3. Array Row Sums");
            Console.WriteLine("4. Object Practice");
            Console.WriteLine("5. Customer");
            Console.WriteLine("6. List");
            Console.WriteLine("7. LINQ");
            Console.WriteLine("8. Inheritance");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter your first number: ");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.Write("Enter your second number: ");
                double secondNumber = double.Parse(Console.ReadLine());

                Console.Write("Choose an operation (-,+,*,/): ");
                char chosenOperator = Console.ReadLine()[0];

                if (chosenOperator == '+')
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }
                else if (chosenOperator == '-')
                {
                    Console.WriteLine(firstNumber - secondNumber);
                }
                else if (chosenOperator == '*')
                {
                    Console.WriteLine(firstNumber * secondNumber);
                }
                else if (chosenOperator == '/')
                {
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine(firstNumber / secondNumber);
                    }
                }
            }
            else if (choice == "2")
            {
                AdventureGame adventure = new AdventureGame();
                adventure.Start();
            }
            else if (choice == "3")
            {
                int[,] array =
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int sum = 0;

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }

                    Console.WriteLine(sum);
                }
            }
            else if (choice == "4")
            {
                Person personOne = new Person();
                personOne.Name = Console.ReadLine();
                personOne.Age = int.Parse(Console.ReadLine());
                personOne.Nationality =  Console.ReadLine();
                Console.WriteLine($"Modified name {personOne.Name} with age of {personOne.Age} and nationality of {personOne.Nationality}");
            
                Person personTwo = new Person();
                personTwo.Name = "Toji";
                personTwo.Age = 23;
                personTwo.Nationality = "God";
                personTwo.Walk();
            } 
            else if (choice == "5")
            {
                Customer itadori = new Customer();
                Customer toji = new Customer("toji");
                Customer megumi = new Customer("megumi", "shibuya");
                Customer maki = new Customer();
                maki.SetDetails(name: "maki", address: "shibuya", contactNumber: "12345");
                
                Console.WriteLine($"Customer Name: {toji.Name}");
                Console.WriteLine($"Customer Name: {megumi.Name}, Customer Address: {megumi.Address}, Customer Number: {megumi.ContactNumber}");
                Console.WriteLine($"Customer Name: {itadori.Name}, Customer Address: {itadori.Address}, Customer Number: {itadori.ContactNumber}");
                Console.WriteLine($"Customer Name: {maki.Name}, Customer Address: {maki.Address}, Customer Number: {maki.ContactNumber}");
            }
            else if (choice == "6")
            {
                MyList list = new MyList();
                list.SortedList();
                list.HasLargeNumber();
            } 
            else if (choice == "7")
            {
             MyLinq list = new MyLinq();
             list.GetProductList();   
            }
            else if(choice == "8")
            {
                Dog dog = new Dog();
                dog.Bark();
                dog.Eating();
            }
        }
    }
}