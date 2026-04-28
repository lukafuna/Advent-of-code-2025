using System.Numerics;

List<BigInteger> starts = new List<BigInteger>();
List<BigInteger> ends = new List<BigInteger>();

int freshCount = 0;

/*
 Day 5 - Part 1 (only)
 
 input: 
        3-5
        10-14
        16-20
        12-18

        1
        5
        8
        11
        17
        32
 */

while (true)
{
    string line1 = Console.ReadLine();
    
    if  (string.IsNullOrEmpty(line1))
    {
        break;
    }
    
    string[] ranges = line1.Split('\n');
    
    
    for (int i = 0; i < ranges.Length; i++)
    {
        starts.Add(BigInteger.Parse(ranges[i].Split("-")[0]));
        ends.Add(BigInteger.Parse(ranges[i].Split("-")[1]));
    }
}

while (true)
{
    string line2 = Console.ReadLine();

    if (string.IsNullOrEmpty(line2))
    {
        break;
    }
    
    BigInteger check = BigInteger.Parse(line2);

    for (int i = 0; i < starts.Count; i++)
    {
        if (check >= starts[i] && check <= ends[i])
        {
            freshCount++;
            break;  // overlapping ingredients
        }
    }
}

Console.WriteLine(freshCount);