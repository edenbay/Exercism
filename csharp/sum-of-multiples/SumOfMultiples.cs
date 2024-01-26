using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public static class SumOfMultiples
{
    

    public static IEnumerable<int> FindMultiplesUnderMax(IEnumerable<int> multiples, int max)
    {

        var g = from multiple in multiples.TakeWhile(i => i < max)
                where multiple += multiple
                select multiple;
                


        var unfilteredMultiples = from multiple in multiples
                                  where multiple + multiple < max 
                                  select multiple;
    }

    public static IEnumerable<int> RemoveDuplicates(IEnumerable<int> multiples, int max)
    {
        throw new NotImplementedException("TODO;");
    }

    private static bool IsUnderMax(this int multiple, int max)
    {
        return multiple < max;
    }
}