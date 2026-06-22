public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ordinalNumAddition = "th";
        int theNum = number % 10;
        if (number % 100 == 11 || number % 100 == 12 || number % 100 == 13)
        {
            ordinalNumAddition = "th";
        }
        else if (number % 10 == 1)
        {
            ordinalNumAddition = "st";
        }
        else if (number % 10 == 2)
        {
            ordinalNumAddition = "nd";
        }
        else if (number % 10 == 3)
        {
            ordinalNumAddition = "rd";
        }
        
        return $"{name}, you are the {number}{ordinalNumAddition} customer we serve today. Thank you!";
    }
}
