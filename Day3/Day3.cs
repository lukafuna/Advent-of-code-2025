int maxAllBanks = 0;

/*
 input: 
 
    987654321111111
    811111111111119
    234234234234278
    818181911112111
    
 */


while (true)
{
    string line = Console.ReadLine();

    if (string.IsNullOrEmpty(line))
    {
        break;
    }

    int[] bank = new int[line.Length];

    for (int i = 0; i < line.Length; i++)
    {
        bank[i] = int.Parse(line[i].ToString());
    }

    int number = 0;

    for (int i = 0; i < bank.Length; i++)
    {
        for (int j = i + 1; j < bank.Length; j++)
        {
            int candidate = bank[i] * 10 + bank[j];
            if (candidate > number)
            {
                number = candidate;
            }
        }
    }



    Console.WriteLine(number);
    maxAllBanks += number;
    Console.WriteLine(maxAllBanks);
}

/*
    Day 3 - Part 2 
 
 
using System.Numerics;

BigInteger maxAllBanks = 0;
while (true)
{
    string line = Console.ReadLine();

    if (string.IsNullOrEmpty(line))
    {
        break;
    }

    int[] bank = new int[line.Length];
    
    for (int i = 0; i < line.Length; i++)
    {
        bank[i] = int.Parse(line[i].ToString());
    }

    int digitsToKeep = 12;
    int digitsToDrop = bank.Length - digitsToKeep;
    
    List<int> kept = new List<int>();

    for (int i = 0; i < bank.Length; i++)
    {
        while (digitsToDrop > 0 && kept.Count > 0 && kept[kept.Count - 1] < bank[i])
        {
            kept.RemoveAt(kept.Count - 1);
            digitsToDrop--;
        }
        kept.Add(bank[i]);
    }

    while (digitsToDrop > 0)
    {
        kept.RemoveAt(kept.Count - 1);
        digitsToDrop--;
    }

    BigInteger number = 0;
    foreach (int d in kept)
    {
        number = number * 10 + d;
    }

    Console.WriteLine(number);
    maxAllBanks += number;
    Console.WriteLine(maxAllBanks);
}

*/