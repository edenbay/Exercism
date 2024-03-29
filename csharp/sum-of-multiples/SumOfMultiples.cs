using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> ints = new();

        for (int i = 0; i < multiples.Count(); i++)
        {
            int baseMultiple = multiples.ElementAt(i);
            if (baseMultiple < 1)
                continue;

            int multiple = baseMultiple;
            while (multiple < max)
            {
                ints.Add(multiple);
                multiple += baseMultiple;
            }
        }

        return ints.Distinct().ToList().Sum();

    }
}