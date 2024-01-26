using System;

public static class ScrabbleScore
{

    static char[] _onePointers = { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
    static char[] _twoPointers = { 'd', 'g' };
    static char[] _threePointers = { 'b', 'c', 'm', 'p' };
    static char[] _fourPointers = { 'f', 'h', 'v', 'w', 'y' };
    static char[] _fivePointers = { 'k' };
    static char[] _eightPointers = { 'j', 'x' };
    static char[] _tenPointers = { 'q', 'z' };

    public static int Score(string input)
    {
        int sum = 0;
        string alreadyUsedLetters = string.Empty;
        foreach (char c in input.ToLower())
        {
                if (Array.Exists(_onePointers, x => x == c)) { sum++;}
                else if (Array.Exists(_twoPointers, x => x == c)) { sum+=2;}
                else if (Array.Exists(_threePointers, x => x == c)) { sum+=3;}
                else if (Array.Exists(_fourPointers, x => x == c)) { sum+=4;}
                else if (Array.Exists(_fivePointers, x => x == c)) { sum+=5;}
                else if (Array.Exists(_eightPointers, x => x == c)) { sum+=8;}
                else if (Array.Exists(_tenPointers, x => x == c)) { sum+=10;}
        }
        return sum;
    }
}