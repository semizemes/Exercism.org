public class Player
{
        Random random = new Random();
    public int RollDie()
    {
        int number = random.Next(1, 19);
        return number;

    }

    public double GenerateSpellStrength()
    {
        double n = random.NextDouble() * 100;
        return n;
    }
}
