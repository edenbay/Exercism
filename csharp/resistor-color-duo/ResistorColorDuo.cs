using System;

public static class ResistorColorDuo
{
        private static readonly string[] _arrayOfColors = { "black", "brown", "red", "orange", "yellow", 
                                                            "green", "blue", "violet", "grey", "white" };
        public static int ColorCode(string color) => Array.IndexOf(_arrayOfColors, color);
    
        public static int Value(string[] colors) =>
            int.Parse($"{ColorCode(colors[0])}{ColorCode(colors[1])}");
}
