namespace Patterns_2.Facade_Proxy;
//Facade pattern
public class SmartHomeFacade
{
    private Light _light;
    private TV _tv;
    private AirConditioner _airConditioner;
    private SecuritySystem _securitySystem;

    public SmartHomeFacade()
    {
        _light = new Light();
        _tv = new TV();
        _airConditioner = new AirConditioner();
        _securitySystem = new SecuritySystem();
    }
    
    public void LeaveHome()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nLeaving home sequence initiated:");//for proxy pattern
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        _light.TurnOff();
        _tv.TurnOff();
        _airConditioner.TurnOff();
        _securitySystem.Arm();
        Console.ResetColor();
    }
    
    public void ReturnHome()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nReturning home sequence initiated:");//for proxy pattern
        
        Console.ForegroundColor = ConsoleColor.Green;
        _light.TurnOn();
        _tv.TurnOn();
        _airConditioner.TurnOn();
        _securitySystem.Disarm();
        Console.ResetColor();
    }
}