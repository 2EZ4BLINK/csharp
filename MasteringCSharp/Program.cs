int firstNumber;
int secondNumber;

Console.WriteLine("Type first number: ");
string firstInput = Console.ReadLine();
firstNumber = int.Parse(firstInput);


Console.WriteLine("Type second number: ");
string secondInput = Console.ReadLine();
secondNumber = int.Parse(secondInput);

Console.WriteLine($"Your sum: {firstNumber + secondNumber}");