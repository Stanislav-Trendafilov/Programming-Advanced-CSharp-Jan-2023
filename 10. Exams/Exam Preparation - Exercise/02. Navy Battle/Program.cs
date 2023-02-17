
int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

int shipRow = 0;
int shipCol = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    string rowInfo = Console.ReadLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rowInfo[j];
        if (matrix[i, j] == 'S')
        {
            shipRow = i;
            shipCol = j;
        }
    }
}

string command = string.Empty;
int explodings = 0;
int cruiserCount = 0;

while (true)
{
    command = Console.ReadLine();
    if (command == "down")
    {
        if (matrix[shipRow + 1, shipCol] == 'C')
        {
            cruiserCount++;
            matrix[shipRow + 1, shipCol] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipRow = shipRow + 1;
            if (cruiserCount == 3)
            {
                Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                break;
            }
        }
        else if (matrix[shipRow + 1, shipCol] == '*')
        {
            explodings++;
            matrix[shipRow + 1, shipCol] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipRow = shipRow + 1;
            if (explodings == 3)
            {
                Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{shipRow}, {shipCol}]!");
                break;
            }
        }
        else
        {
            matrix[shipRow + 1, shipCol] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipRow = shipRow + 1;
        }

    }
    else if (command == "up")
    {
        if (matrix[shipRow - 1, shipCol] == 'C')
        {
            cruiserCount++;
            matrix[shipRow - 1, shipCol] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipRow = shipRow - 1;
            if (cruiserCount == 3)
            {
                Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                break;
            }
        }
        else if (matrix[shipRow - 1, shipCol] == '*')
        {
            explodings++;
            matrix[shipRow - 1, shipCol] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipRow = shipRow - 1;
            if (explodings == 3)
            {
                Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{shipRow}, {shipCol}]!");
                break;
            }
        }
        else
        {
            matrix[shipRow - 1, shipCol] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipRow = shipRow - 1;
        }

    }
    else if (command == "left")
    {
        if (matrix[shipRow, shipCol - 1] == 'C')
        {
            cruiserCount++;
            matrix[shipRow, shipCol - 1] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipCol = shipCol - 1;
            if (cruiserCount == 3)
            {
                Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                break;
            }
        }
        else if (matrix[shipRow, shipCol - 1] == '*')
        {
            explodings++;
            matrix[shipRow, shipCol - 1] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipCol = shipCol - 1;
            if (explodings == 3)
            {
                Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{shipRow}, {shipCol}]!");
                break;
            }
        }
        else
        {
            matrix[shipRow, shipCol - 1] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipCol = shipCol - 1;
        }

    }
    else if (command == "right")
    {
        if (matrix[shipRow, shipCol + 1] == 'C')
        {
            cruiserCount++;
            matrix[shipRow, shipCol + 1] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipCol++;
            if (cruiserCount == 3)
            {
                Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                break;
            }
        }
        else if (matrix[shipRow, shipCol + 1] == '*')
        {
            explodings++;
            matrix[shipRow, shipCol + 1] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipCol++;
            if (explodings == 3)
            {
                Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{shipRow}, {shipCol}]!");
                break;
            }
        }
        else
        {
            matrix[shipRow, shipCol + 1] = 'S';
            matrix[shipRow, shipCol] = '-';
            shipCol++;
        }


    }



}

for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}");
    }
    Console.WriteLine();
}