class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int ActualMinutes) => ExpectedMinutesInOven() - ActualMinutes;
    public int PreparationTimeInMinutes(int numberoflayers) => numberoflayers * 2;
    public int ElapsedTimeInMinutes(int numberoflayers, int ActualMinutes) => PreparationTimeInMinutes(numberoflayers) + ActualMinutes;  
}