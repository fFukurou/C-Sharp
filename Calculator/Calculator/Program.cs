// See https://aka.ms/new-console-template for more information

// Defining the functions
static double Add(double x, double y) => x + y;
static double Subtract(double x, double y) => x - y;
static double Divide(double x, double y) => x / y;
static double Multiply(double x, double y) => x * y;


//Validating and checking the operation to be executed
string operation = "";
while (true)
{
    Console.WriteLine("Which operation would you like to execute? ( + - / *)");
    operation = Console.ReadLine();
    if (operation == "+" || operation == "-" || operation == "/" || operation == "*")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid operation. Please enter one of +, -, /, *.");
    }
}

double firstNumber = 0;
double secondNumber = 0;

// Validating and checking if the first and second inputs are a number, and if the 2nd number is not 0 in case the operator is 0
while (true)
{
    Console.WriteLine("Type the 1st number: ");
    if (double.TryParse(Console.ReadLine(), out firstNumber))
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


while (true)
{
    Console.WriteLine("Type the 2nd number: ");
    if (double.TryParse(Console.ReadLine(), out secondNumber))
    {
        // Check for division by zero
        if (operation == "/" && secondNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero. Please enter a different number.");
        }
        else
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

//Executing the operation utilizing switch cases
double total = 0;
switch (operation)
{
    case "+":
        total = Add(firstNumber, secondNumber);
        total = Math.Round(total, 2);
        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {total}");
        break;

    case "-":
        total = Subtract(firstNumber, secondNumber);
        total = Math.Round(total, 2);
        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {total}");
        break;

    case "/":
        total = Divide(firstNumber, secondNumber);
        total = Math.Round(total, 2);
        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {total}");
        break;

    case "*":
        total = Multiply(firstNumber, secondNumber);
        total = Math.Round(total, 2);
        Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {total}");
        break;

}