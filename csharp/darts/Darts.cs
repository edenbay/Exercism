using System;

public static class Darts
{
        public static int Score(double x, double y) =>
            (Math.Sqrt(x * x + y * y)) switch
            {
                <= 1.00 => 10,
                <= 5.00 => 5,
                <= 10.00 => 1,
                _ => 0,
            }; 
}
