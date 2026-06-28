using System;

namespace MyApplication
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
                Person human = new Person();
                human.Name = Console.ReadLine();
                human.Age = int.Parse(Console.ReadLine());
                human.Nationality =  Console.ReadLine();
                Console.WriteLine($"Modified name {human.Name} with age of {human.Age} and nationality of {human.Nationality}");
            } 
            else if (choice == "5")
            {
                Customer itadori = new Customer();
                Customer toji = new Customer("toji");
                Customer megumi = new Customer("megumi", "shibuya", "12345");
                
                Console.WriteLine($"Customer Name: {toji.Name}");
                Console.WriteLine($"Customer Name: {megumi.Name}, Customer Address: {megumi.Address}, Customer Number: {megumi.ContactNumber}");
                Console.WriteLine($"Customer Name: {itadori.Name}, Customer Address: {itadori.Address}, Customer Number: {itadori.ContactNumber}");
            }
        }
    }
}