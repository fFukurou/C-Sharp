// See https://aka.ms/new-console-template for more information


int[] myArray = new int[10];

for (int i = 0; i < 10; i++)
{
    myArray[i] = i * 2;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(myArray[i]);
}

Console.WriteLine(myArray);


string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

Console.WriteLine($"\nThere are a total of {weekDays.Length} days in a week.");

foreach (var day in weekDays)
{
    Console.WriteLine(day);
}


