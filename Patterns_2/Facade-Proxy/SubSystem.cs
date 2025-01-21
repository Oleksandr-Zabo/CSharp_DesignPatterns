namespace Patterns_2.Facade_Proxy;

public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("The light is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("The light is off");
    }
}

public class TV
{
    public void TurnOn()
    {
        Console.WriteLine("The TV is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("The TV is off");
    }
    
    public void ChangeChannel(int channel)
    {
        Console.WriteLine($"The TV channel is set to {channel}");
    }
}

public class AirConditioner
{
    public void TurnOn()
    {
        Console.WriteLine("The air conditioner is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("The air conditioner is off");
    }
    
    public void SetTemperature(int temperature)
    {
        Console.WriteLine($"The air conditioner temperature is set to {temperature}");
    }
}

public class SecuritySystem
{
    public void Arm()
    {
        Console.WriteLine("The security system is armed");
    }

    public void Disarm()
    {
        Console.WriteLine("The security system is disarmed");
    }
}