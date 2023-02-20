
int[] dimensions = Console.ReadLine()
	.Split(" ", StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse)
	.ToArray();
int rows = dimensions[0];
int cols=dimensions[1];

char[,]matrix= new char[rows, cols];

int rowPlayer = 0;
int colPlayer= 0; 

for(int i=0;i<rows; i++)
{
	char[]rowInfo=Console.ReadLine()
		.Split(" ",StringSplitOptions.RemoveEmptyEntries)
		.Select(char.Parse)
		.ToArray();
	for (int j = 0; j < cols; j++)
	{
		matrix[i,j] = rowInfo[j];
		if (matrix[i,j]=='B')
		{
			rowPlayer=i;
			colPlayer=j;
		}
	}
}

string command=string.Empty;
int playersCount = 0;
int movesMade = 0;
while((command=Console.ReadLine())!="Finish")
{
	matrix[rowPlayer, colPlayer] = '-';
	if (command == "up")
	{
		if (rowPlayer - 1 < 0)
		{ 
			continue;
		}
		else if (matrix[rowPlayer - 1, colPlayer] == 'O')
		{
			continue;
		}
		else
		{
			rowPlayer--;
		}
	}
	else if(command=="down")
	{
        if (rowPlayer + 1 >matrix.GetLength(0)-1)
        { 
			continue; 
		}
		else if(matrix[rowPlayer + 1, colPlayer] == 'O')
		{
			continue;
		}
        else
        {
            rowPlayer++;
        }
    }
    else if (command == "left")
    {
        if (colPlayer -1 <0)
        { 
			continue;
		}
		else if (matrix[rowPlayer,colPlayer-1]=='O')
		{
			continue;
		}
        else
        {
            colPlayer--;
        }
    }
    else if (command == "right")
    {
        if (colPlayer + 1 >matrix.GetLength(1)-1)
        {
            continue;
        }
        else if (matrix[rowPlayer, colPlayer + 1] == 'O')
        {
            continue;
        }
        else
        {
            colPlayer++;
        }
    }

	if (matrix[rowPlayer, colPlayer] == 'P')
	{
		playersCount++;
		matrix[rowPlayer, colPlayer] = 'B';
		movesMade++;
		if(playersCount==3)
		{
			break;
		}
	}
	else
	{
        matrix[rowPlayer, colPlayer] = 'B';
        movesMade++;
    }
    //for (int i = 0; i < rows; i++)
    //{
    //    for (int j = 0; j < cols; j++)
    //    {
    //        Console.Write(matrix[i, j]);
    //    }
    //    Console.WriteLine();
    //}
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {playersCount} Moves made: {movesMade}");



