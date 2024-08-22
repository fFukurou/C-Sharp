// See https://aka.ms/new-console-template for more information

void Ping()
{
    Console.WriteLine("Pong");
}

void WriteSomethingSpecific(string myString)
{
    Console.WriteLine(myString);
}

int Adder(int value1, int value2)
{
    return value1 + value2;
}

Ping();
WriteSomethingSpecific("BRUH");
Console.WriteLine(Adder(20, 40));