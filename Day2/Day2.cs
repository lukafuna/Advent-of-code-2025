

while (true)
{
    
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    
    string[] ranges = input.Split(',');
    
    /* input:
     
     11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124
     
    */
    long[] starts = new  long[ranges.Length];
    long[] ends = new long[ranges.Length];
    
    string[] startsStr = new  string[ranges.Length];
    string[] endsStr = new string[ranges.Length];
    
    for (int i = 0; i < ranges.Length; i++)
    {
       starts[i] = long.Parse(ranges[i].Split('-')[0]);
       ends[i] = long.Parse(ranges[i].Split('-')[1]);
       
    }
    
    List<long> invalids = new List<long>();
    
    for (int i = 0; i < ends.Length; i++)
    {
        for (long j = starts[i]; j <= ends[i]; j++)
        {
            if (j.ToString().Length % 2 != 0)
            {
                continue;
            }
            
            if (j.ToString().Substring(0,j.ToString().Length/2).Equals(j.ToString().Substring(j.ToString().Length/2,j.ToString().Length/2)))
            {
                invalids.Add(j);
            }
        }
    }
    /*
     
     Day 2 - Part 2 
     
     for (int i = 0; i < ends.Length; i++)
    {
        for (long j = starts[i]; j <= ends[i]; j++)
        {
            if (Regex.IsMatch(j.ToString(), @"^(.+)\1+$"))
            {
                invalids.Add(j);
            }
        }
    }
    
    */
    
    long sum = invalids.Sum();
    
    Console.WriteLine(sum);
}

