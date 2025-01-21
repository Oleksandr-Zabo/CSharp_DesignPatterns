namespace Patterns_2.Facade_Proxy;

public class ClientCode
{
    public void Main()
    {
        // Using proxy for access control
        ISmartHomeSystem homeSystem = new SmartHomeSecurityProxy("1234");

        // Try to leave home
        Console.WriteLine("Attempting to leave home...");
        homeSystem.LeaveHome();

        // Try to return home
        Console.WriteLine("\nAttempting to return home...");
        homeSystem.ReturnHome();
    }
}