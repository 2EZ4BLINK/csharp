Console.Write("Enter your first number: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Enter your Second number: ");
double secondNumber = double.Parse(Console.ReadLine());

Console.Write("Choos an operation (-,+,*,/): ");
char chosenOperator = Console.ReadLine()[0];

if(chosenOperator == '+') {
    Console.Write($"Your result: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
} else if (chosenOperator == '-') {
    Console.Write($"Your result: {firstNumber} + {secondNumber} = {firstNumber - secondNumber}");
} else if (chosenOperator == '*') {
    Console.Write($"Your result: {firstNumber} + {secondNumber} = {firstNumber * secondNumber}");
} else if (chosenOperator == '/') {
    if(firstNumber == 0 || secondNumber == 0) {
        Console.Write("Dont divide zero value in division");
    } else {
        Console.Write($"Your result: {firstNumber} + {secondNumber} = {firstNumber / secondNumber}");
    }
}