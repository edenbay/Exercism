using System;

public class SpaceAge
{
    private const double _earthYearInSeconds = 31557600;

    private int _ageInSeconds;


    public SpaceAge(int seconds)
    {
        _ageInSeconds = seconds;
    }

    public double OnEarth() =>
        CalculateAgeWithFactor(1);

    public double OnMercury() =>
        CalculateAgeWithFactor(0.2408467);

    public double OnVenus() =>
         CalculateAgeWithFactor(0.61519726); 

    public double OnMars() =>
        CalculateAgeWithFactor(1.8808158);

    public double OnJupiter() =>
        CalculateAgeWithFactor(11.862615);


    public double OnSaturn() =>
        CalculateAgeWithFactor(29.447498);


    public double OnUranus() =>
        CalculateAgeWithFactor(84.016846);


    public double OnNeptune() => 
        CalculateAgeWithFactor(164.79132);


    private double CalculateAgeWithFactor(double orbitalPeriod) 
    { 
        return _ageInSeconds / (_earthYearInSeconds * orbitalPeriod);
    }
        

}