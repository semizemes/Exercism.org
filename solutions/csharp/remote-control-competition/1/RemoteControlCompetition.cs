// TODO implement the IRemoteControlCar interface
public interface IRemoteControlCar
{
    public int DistanceTravelled { get;}
    public void Drive();
}

public class ProductionRemoteControlCar: IRemoteControlCar, IComparable
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public int CompareTo(object? obj)
    {
        ProductionRemoteControlCar otherCar = (ProductionRemoteControlCar)obj;
        return NumberOfVictories.CompareTo(otherCar.NumberOfVictories);
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar: IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2) 
    {
        List<ProductionRemoteControlCar> cars = [prc1, prc2];
        cars.Sort();
        return cars;
    }
}
