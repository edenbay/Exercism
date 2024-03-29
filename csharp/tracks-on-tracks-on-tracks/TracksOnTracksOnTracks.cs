using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public static class Languages
{
    public static List<string> NewList() => new();

    public static List<string> GetExistingLanguages()
    {
        var list = NewList();
        list.AddRange(_existingLanguages);
        return list;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages) => languages.Count;
    

    public static bool HasLanguage(List<string> languages, string language) 
                                            => languages.Contains(language);    


    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        
        if (languages.Count !> 0)
        {
            return false;
        }
        if (languages.First().Equals("C#"))
        {
            return true;
        }
        if (languages.ElementAt(1).Equals("C#"))
        {
            if (languages.Count > 0 && languages.Count < 3) 
            {
                return true;
            }
        }

        return false;
    }


    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages) => languages.All(x => x.Distinct());


    private static IEnumerable<string> _existingLanguages = new string[] { "C#", "Clojure", "Elm" };
}
