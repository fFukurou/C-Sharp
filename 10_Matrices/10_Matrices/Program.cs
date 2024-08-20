// See https://aka.ms/new-console-template for more information

// Just declaring the array
int[,] array2D = new int[3, 3];

int[,,] array3D = new int[3, 3, 3];

// Initializing the array
int[,] array2D2 = { {1,2}, {3,4} };

//Console.WriteLine(array2D2[1, 1]);

array2D2[0, 0] = 2;

string[,] ticTacToeField =
{
    {"O","X","X"},
    {"O","O","X"},
    {"X","X","O"},
};

string[,,] array3D2 =
{
    {
        {"000", "001", "002"},
        {"010", "011", "012" }
    },
    {
        {"100", "101", "102"},
        {"110", "111", "112"}
    }
};

//Console.WriteLine(array3D2[0,0,2]);

int[,] new2DArray =
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
};

// Loop through each row in the array
for (int i = 0; i < 3; i++)
{
    int sum = 0; // Initialize the sum variable for the current row

    // Loop through each column in the current row
    for (int j = 0; j < 3; j++)
    {
        sum += new2DArray[i, j]; // Add the element to the sum
    }

    // Print the sum of the current row
    Console.WriteLine(sum);
}