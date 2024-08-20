// See https://aka.ms/new-console-template for more information

// Picking your name, and your class
Console.WriteLine("Welcome to the adventure game!");
Console.WriteLine("Choose your character's name: ");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your class (Warrior, Wizard, Archer)");
string playerClass = Console.ReadLine();


// Event 1
Console.WriteLine($"You, {playerName} the {playerClass} find yourself at the end of a Dark Forest...");
Console.WriteLine("Do you enter the forest or camp outside? (Camp/Enter)");
string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely enter the forest.");
}
else
{
    Console.WriteLine("You decide to camp out and wait for daylight.");
}

bool gameContinues = true;

// Event 2
while (gameContinues)
{
    Console.WriteLine("You come to a fork on the road. Go left or right?");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }   
    else
    {
        Console.WriteLine("You encounter a wild beast! Fight or flee?");
        string fightChoice =Console.ReadLine();
        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beast!");
                if (luck > 5)
                {
                    Console.WriteLine("The wild beast dropped a treasure!");
                }
            }
            else
            {
                Console.WriteLine("The beast, grabs you, sucking out the saps of your life energy.\n \"YOU DIED\" Dark_Souls_screen.png");
                gameContinues = false; 
            }
        }
    }
}

Console.WriteLine("\nThank you for playing the game!");

