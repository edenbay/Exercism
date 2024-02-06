using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public static class SumOfMultiples
{
    

    public static IEnumerable<int> FindMultiplesUnderMax(IEnumerable<int> multiples, int max)
    {
        IEnumerable<int> allUnderMax = from multiple in multiples
                          where multiple += multiple < max
                          select multiple;

        return multiples.TakeWhile(multiple => multiples.Aggregate((multiple, multiplier) => multiple + multiplier) < max)
                        




    }
}

//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//public static class SumOfMultiples
//{
//    public static int Sum(IEnumerable<int> multiples, int max)
//    {
//        var result = RemoveDuplicates(multiples, max).ToList();
//        return result.Sum();
//    }

//    public static IEnumerable<int> FindMultiplesUnderMax(IEnumerable<int> multiples, int max)
//    {
//        List<int> mul = new List<int>();

//        foreach (int multiple in multiples)
//        {
//            int num = multiple;
//            while (num < max)
//            {
//                mul.Add(num);
//                num += multiple;
//            }
//        }
//        return mul;
//    }

//    public static IEnumerable<int> RemoveDuplicates(IEnumerable<int> multiples, int max)
//    {
//        return FindMultiplesUnderMax(multiples, max).ToList().Distinct().ToList();
//    }

//}