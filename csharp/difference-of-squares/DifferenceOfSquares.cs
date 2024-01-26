using System;

public static class DifferenceOfSquares
{
    public static int Square(int number) => number * number;

    public static int CalculateSquareOfSum(int max) => Square(Enumerable.Range(1, max).Sum());

    public static int CalculateSumOfSquares(int max) => Enumerable.Range(1, max).Sum();

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}