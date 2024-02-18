using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public static class SumOfMultiples
{
    

    public static int Sum(IEnumerable<int> multiples, int max)
    {

        var sums = new List<int>();

        foreach (int multiple in multiples)
        {
            int multiplier;
            if (multiple.Equals(0))
            {
                continue;
            }
            else
            {
                 multiplier = multiple;
            }
            
            while (multiplier < max)
            {
                sums.Add(multiplier);
                multiplier += multiple;
            }            
        }
        return sums.Distinct().Sum();
    }
    // x => x % x == 0
    //public static int SumOf(IEnumerable<int> multiples, int max)
    //{
        

        
    //}
    

}
namespace penis
{
    public class Exercise
{
    public List<int> GetCountsOfAnimalsLegs()
    {
        var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

        var result = new List<int>();
        foreach (var animal in animals)
        {
            result.Add(animal.NumberOfLegs);
        }
        return result;
    }
}

    p base class StringsProcessor
    {
        protected virtual bool IsUpperCase { get; set; } = false;

        public List<string> Process(List<string> words)
        {
            var result = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                var halfOfWord = words[i].Length / 2;
                result[i] = words[i].Substring(0, halfOfWord);
            }

            if (IsUpperCase)
            {
               result.ForEach(word => word.ToUpper());
            }

            return result;
        }
    }

    public class StringsProcessorcock : StringsProcessor 
    {
        protected override bool IsUpperCase { get; set; } = true;
    }
    


        public abstract class Animal
    {
        public virtual int NumberOfLegs { get; set; } = 4;

        public Animal()
        {
            
        }
    }

    public class Lion : Animal
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