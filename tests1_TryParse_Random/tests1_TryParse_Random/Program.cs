// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write an integer number: ");

// Trying to convert first number to int
while (true)
{
    string input1 = Console.ReadLine();

    if (int.TryParse(input1, out int num1))
    {
        Console.WriteLine($"{num1} has been converted into an integer number.");
        break;
    }
    else
    {
        Console.WriteLine("Please input an integer number.");
    }
}


Console.WriteLine("Write a float/double number: ");

// Trying to convert second number to double
while (true)
{
    string input2 = Console.ReadLine();
    if (float.TryParse(input2, out float num2))
    {
        Console.WriteLine($"{num2} has been conveted into a float number.");
        break;
    } 
    else
    {
        Console.WriteLine("Please input an float/double number. ");
    }
}

// Generating a random number
Random random = new Random();
int randomNumber = random.Next(1, 11);

Console.WriteLine($"The random number generated was {randomNumber}");