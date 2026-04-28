List<string> matrix = new List<string>();
int count = 0;

while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        break; 
    }

    matrix.Add(input);
}

int numRows = matrix.Count;
int numCols = matrix[0].Length;

for (int i = 0; i < numRows; i++)
{
    for (int j = 0; j < numCols; j++)
    {
        int adjacentCount = 0;
        
        if (matrix[i][j] == '.')
        {
            continue; // . aren't useful for this task
        }

        for (int mi = -1; mi <= 1; mi++)
        {
            for (int mj = -1; mj <= 1; mj++)
            {
                if (mi == 0 && mj == 0)
                {
                    continue; 
                }
                
                int newRowIndex = i + mi;
                int newColIndex = j + mj;

                if (newRowIndex >= 0 && newRowIndex < numRows && newColIndex >= 0 && newColIndex < numCols)
                {
                    if (matrix[newRowIndex][newColIndex] == '@')
                    {
                        adjacentCount++;
                    }
                }
            }
        }

        if (adjacentCount == 4)
        {
            count++;
        }
    }
}

Console.WriteLine(count);
