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
        return battery > 0 ? $"Battery at {battery}%" : "Battery empty";
    }

    public void Drive()
    {
        if(battery > 0)
        {
            battery -= 1;
            meterDriven += 20;
        }
    }
}

