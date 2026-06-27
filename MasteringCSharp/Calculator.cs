double firstNumber;
double secondNumber;

Console.WriteLine("Type first number: ");
string firstInput = Console.ReadLine();
firstNumber = double.Parse(firstInput);


Console.WriteLine("Type second number: ");
string secondInput = Console.ReadLine();
secondNumber = double.Parse(secondInput);

Console.WriteLine($"Your sum: {firstNumber + secondNumber}");