public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            long result = checked(@base * multiplier);
            return $"{result}";
        }
        catch(OverflowException)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        if (float.IsInfinity(@base * multiplier))
        {
            float res = @base * multiplier;
            return $"{res}";
        }
        return "*** Too Big ***";
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            decimal res = salaryBase * multiplier;
            return res.ToString();
        }
        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }
    }
}
