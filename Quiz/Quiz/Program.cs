// See https://aka.ms/new-console-template for more information
string question1 = "In which country does Ghost of Tsushima takes place? ";
string answer1 = "JAPAN";

string question2 = "Is \"black\" a color? (Y/N)";
bool answer2 = false;

string question3 = "What is (5 * 3) / 2 + 0.25 17 * 0.25 + (3+3)²";
string answer3 = "93";

int score = 0;

// Asking and checking Answer 1
Console.WriteLine(question1);
if (answer1 == Console.ReadLine().Trim().ToUpper())
{
    score++;

} else
{
    Console.WriteLine($"WRONG! The correct answer is {answer1}\n");
}

// Asking and checking Answer 2
Console.WriteLine(question2);
bool tempAnswer = true;
if (Console.ReadLine().Trim().ToUpper() == "N")
{
    tempAnswer = false;
    if (tempAnswer == answer2)
    {
        score++;
    }

}
else
{
    Console.WriteLine($"WRONG! The correct answer is {answer2}\n");
}

// Asking and checking Answer 3
Console.WriteLine(question3);
if (Console.ReadLine().Trim() == answer3)
{
    score++;
}
else
{
    Console.WriteLine($"WRONG! The correct answer is {answer3}\n");
}


// Printing score
if (score == 0)
{
    Console.WriteLine($"Congratulations, you got them all wrong.");
} else if (score == 3)
{
    Console.WriteLine("Nice, you got them all right.");
} else
{
    Console.WriteLine($"Your final score was {score}.");
}

