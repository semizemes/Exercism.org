class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    int speed;
    int batteryDrain;
    private int _battery = 100;
    private int _distanceDrive = 0;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if(_battery > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public int DistanceDriven()
    {
        return _distanceDrive;
    }

    public void Drive()
    {
        if (_battery - batteryDrain > 0)
        {
            _distanceDrive = _distanceDrive + speed;
            _battery = _battery - batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}
