Console.WriteLine("Choose a program:");
Console.WriteLine("1. Calculator");
Console.WriteLine("2. Adventure Game");

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