int numZeroes = 0;
int start = 50;
int c = 0;

/*
input: 
        L68
        L30
        R48
        L5
        R60
        L55
        L1
        L99
        R14
        L82
 */


while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        break;
    }

    if (c == 0)
    {
        if (input[0] == 'L')
        {
            string[] parts = input.Split('L');
            int move = int.Parse(parts[1]);

            if (move > start)
            {
                start = (start - move % 100 + 100) % 100;
            }
            else
            {
                start = start - move;
            }
        }
        else if (input[0] == 'R')
        {
            string[] parts = input.Split('R');
            int move = int.Parse(parts[1]);

            if (move + start > 99)
            {
                start = (move + start) % 100;
            }
            else
            {
                start = start + move;
            }
        }
    }
    else
    {
        if (input[0] == 'L')
        {
            string[] parts = input.Split('L');
            int move = int.Parse(parts[1]);

            if (move > start)
            {
                start = (start - move % 100 + 100) % 100;
            }
            else
            {
                start = start - move;
            }
        }
        else if (input[0] == 'R')
        {
            string[] parts = input.Split('R');
            int move = int.Parse(parts[1]);

            if (move + start > 99)
            {
                start = (move + start) % 100;
            }
            else
            {
                start = start + move;
            }
        }
    }

    if (start == 0)
    {
        numZeroes++;
    }

    Console.WriteLine(start);
    Console.WriteLine(numZeroes);
    Console.WriteLine("---------------");

    c++;
}

Console.WriteLine(numZeroes);

/*
    Day 1 - Part 2
 
while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        break;
    }

    char direction = input[0];
    int move = int.Parse(input.Substring(1));
    int crossings = 0;

    if (direction == 'L')
    {
        int step = -1;
        int distance = move * step;
        for (int i = start; i > start + distance; i += step)
        {
            if (i % 100 == 0)
                crossings++;
        }
        start = (start - move % 100 + 100) % 100;
    }
    else if (direction == 'R')
    {
        int step = 1;
        int distance = move * step;
        for (int i = start; i < start + distance; i += step)
        {
            if (i % 100 == 0)
                crossings++;
        }
        start = (start + move) % 100;
    }

    numZeroes += crossings;

    Console.WriteLine(start);
    Console.WriteLine(numZeroes);
    Console.WriteLine("---------------");
}

Console.WriteLine(numZeroes);

*/


