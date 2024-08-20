// See https://aka.ms/new-console-template for more information

string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

for (int i = 10; i >= 0; i--)
{
    Console.Clear();
    Console.WriteLine($"{i}\n{rocket}");
    rocket = "\n" + rocket;

    Thread.Sleep(500);
}

Console.WriteLine("------------------------------------------\nThe rocket has landed!");