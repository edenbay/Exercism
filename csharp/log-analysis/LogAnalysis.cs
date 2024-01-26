using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string input) => str.Substring(str.IndexOf(input[input.Length-1])+1);
    

    public static string SubstringBetween(this string str, string start, string end) => str.Substring((str.IndexOf(start) + start.Length), str.IndexOf(end) - (str.IndexOf(start) + start.Length));
    

    public static string Message(this string str) => str.Substring(str.IndexOf(": ") +1).Trim();

    public static string LogLevel(this string str) => str.Substring((str.IndexOf('[') + 1), (str.IndexOf(']')) - 1).Trim();

}