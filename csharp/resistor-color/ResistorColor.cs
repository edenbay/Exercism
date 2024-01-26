using System;

public static class ResistorColor
{
        private static readonly string[] _arrayOfColors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        public static int ColorCode(string color) => Array.IndexOf(_arrayOfColors, color);
 
        public static string[] Colors() => _arrayOfColors;
}