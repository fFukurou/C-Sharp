// See https://aka.ms/new-console-template for more information


// Generating the random number
Random randomInt = new Random();
int randomNumber = randomInt.Next(1, 16);

int counter = 1;

// Asking for user input

while (true)
{
    Console.WriteLine("Enter a number between 1 and 15:");

    string guess = Console.ReadLine();
    if (int.TryParse(guess, out int num))
    {
        if (num == randomNumber)
        {
            Console.WriteLine("Congratulations, you guessed the random number...");
            Console.WriteLine($"Tries: {counter}");
            break;

        }
        else if (randomNumber > num)
        {
            Console.WriteLine($"Wrong\nThe random number is greater than {num}");
            counter++;

        }
        else if (randomNumber < num)
        {
            Console.WriteLine($"Wrong\nThe random number is lesser than {num}");
            counter++;
        }
    }
}


