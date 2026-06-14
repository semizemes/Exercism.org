class RemoteControlCar
{
        int meterDriven = 0;
        int battery = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {meterDriven} meters";
    }

    public string BatteryDisplay()
    {
        return battery > 1 || meterDriven <= 2000 ? $"Battery at {battery}%" : "Battery empty";
    }

    public void Drive()
    {
        battery -= 1;
        meterDriven += 20;
    }
}

