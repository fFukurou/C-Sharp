// See https://aka.ms/new-console-template for more information

int counter = 15;
int number = 0;

// Will execute at least once regardless
do
{
    Console.WriteLine(counter);
    counter++;

} while (counter < 10);


// Can be used for validation stonks
do
{
    Console.WriteLine("Enter a positive whole number");
    number = int.Parse(Console.ReadLine());
} while (number <= 0);
Console.WriteLine("Finally!");
 
