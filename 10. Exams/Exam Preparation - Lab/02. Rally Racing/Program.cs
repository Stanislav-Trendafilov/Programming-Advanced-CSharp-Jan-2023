
int n = int.Parse(Console.ReadLine());

string racingName = Console.ReadLine();

char[,] matrix = new char[n, n];

int rowCar = 0, colCar = 0;
int rowTunnel1 = 0, colTunnel1 = 0;
bool passTunnel = false;
int rowTunnel2 = 0, colTunnel2 = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    char[] rowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rowInfo[j];
        if (rowInfo[j] == 'T' && passTunnel == false)
        {
            rowTunnel1 = i;
            colTunnel1 = j;
            passTunnel = true;
        }
        else if (rowInfo[j] == 'T')
        {
            rowTunnel2 = i;
            colTunnel2 = j;
        }
    }
}

matrix[rowCar, colCar] = 'C';
string command = string.Empty;
int distance = 0;
bool finished = false;

while ((command = Console.ReadLine()) != "End")
{
    matrix[rowCar, colCar] = '.';
    if (command == "left")
    {
        colCar--;
    }
    else if (command == "right")
    {
        colCar++;
    }
    else if (command == "up")
    {
        rowCar--;
    }
    else if (command == "down")
    {
        rowCar++;
    }
    if (matrix[rowCar, colCar] == 'F')
    {
        Console.WriteLine($"Racing car {racingName} finished the stage!");
        matrix[rowCar, colCar] = 'C';
        finished = true;
        distance += 10;
        break;
    }
    else if (matrix[rowCar, colCar] == 'T')
    {
        if (rowCar == rowTunnel1)
        {
            rowCar = rowTunnel2;
            colCar = colTunnel2;
        }
        else
        {
            rowCar = rowTunnel1;
            colCar = colTunnel1;
        }
        distance += 30;
        matrix[rowTunnel2, colTunnel2] = '.';
        matrix[rowTunnel1, colTunnel1] = '.';
    }
    else
    {
        distance += 10;
    }
    matrix[rowCar, colCar] = 'C';
}
if (!finished)
{
    Console.WriteLine($"Racing car {racingName} DNF.");
}
Console.WriteLine($"Distance covered {distance} km.");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}");
    }
    Console.WriteLine();

}
//Console.WriteLine("tunnel coordinates");
//Console.WriteLine($"{rowTunnel1} {colTunnel1}");
//Console.WriteLine($"{rowTunnel2} {colTunnel2}");