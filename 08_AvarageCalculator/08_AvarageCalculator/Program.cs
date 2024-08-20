// See https://aka.ms/new-console-template for more information


float currentScore;
float sum = 0;
int counter = 0;

do
{
    Console.WriteLine("Enter your students' score. Enter -1 to finish");
    currentScore = float.Parse(Console.ReadLine());
    if (currentScore != -1)
    {
    sum += currentScore;
    counter++;
    }



} while (currentScore != -1);

float avarage = sum / counter;
Console.WriteLine($"The avarage of the scores was {Math.Round(avarage), 2}.");