static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed <= 0)
        {
            return 0.00;
        } 
        else if(1 <= speed) {
            return 1.00;
        } else if(5 <= speed)
        {
            return 0.90;
        } else if(9 <= speed)
        {
            return 0.80;
        } else
        {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
            return SuccessRate(speed) * speed * 221;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double carsCount = ProductionRatePerHour(speed) / 60;
        return (int)carsCount;
    }
}
