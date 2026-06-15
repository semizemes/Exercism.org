class BirdCount
{
    private int[] birdsPerDay;
    int todayBirdsCount = 1;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length - 1]++;

    public bool HasDayWithoutBirds() => birdsPerDay.Any(day => day == 0);

    public int CountForFirstDays(int numberOfDays)
    {
        int sumOfBirds = 0;
        for(int i = 0; i < numberOfDays; i++)
        {
            sumOfBirds += birdsPerDay[i];
        }
        return sumOfBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
