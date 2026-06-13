static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed <= 0)
        {
            return 0.00;
        } 
        else if(1 <= speed && speed <= 4) {
            return 1.00;
        } 
        else if(5 <= speed && speed <= 8)
        {
            return 0.9;
        } 
        else if(9 == speed)
        {
            return 0.8;
        } 
        else if(10 == speed)
        {
            return 0.77;
        }
        else
        {
            return -10010100010;
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
