using System;

static class AssemblyLine
{

    public static double SuccessRate(int speed)
    {
        double rateOfSuccess = 0;        
        switch (speed)
        {
            case 0:
                rateOfSuccess = 0.00; break;
            case int n when (1 <= n && n <= 4):
                rateOfSuccess = 1; break;
            case int n when (5 <= n && n <= 8):
                rateOfSuccess = 0.90; break;
            case 9:
                rateOfSuccess = 0.80; break;
            case 10:
                rateOfSuccess = 0.77; break;
        }
        return rateOfSuccess;
    }

    
    public static double ProductionRatePerHour(int speed) => (221 * speed) * SuccessRate(speed);


    public static int WorkingItemsPerMinute(int speed) => (int)(3.68 * speed * SuccessRate(speed));
}
