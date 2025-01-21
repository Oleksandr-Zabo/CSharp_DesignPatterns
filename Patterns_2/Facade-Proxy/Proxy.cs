namespace Patterns_2.Facade_Proxy;

public interface ISmartHomeSystem
{
    void LeaveHome();
    void ReturnHome();
}

public class SmartHomeSystem : ISmartHomeSystem
{
    private SmartHomeFacade _facade;//for facade pattern
    public SmartHomeSystem()
    {
        _facade = new SmartHomeFacade();
    }
    
    public void LeaveHome()
    {
        _facade.LeaveHome();
    }
    
    public void ReturnHome()
    {
        _facade.ReturnHome();
    }
}

public class SmartHomeSecurityProxy : ISmartHomeSystem
{
    private SmartHomeSystem _realSystem;
    private string _password;
    
    public SmartHomeSecurityProxy(string password)
    {
        this._password = password;
        this._realSystem = new SmartHomeSystem();
    }
    
    private bool CheckAccess()
    {
        Console.Write("Enter password: ");
        var inputPassword = Console.ReadLine();
        if (inputPassword != _password)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Access denied!");
            Console.ResetColor();
            return false;
        }
        return true;
    }

    private void LogAction(string action)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"\nLog: {action} at {DateTime.Now}");
        Console.ResetColor();
    }
    
    public void LeaveHome()
    {
        if (CheckAccess())
        {
            _realSystem.LeaveHome();
            LogAction("Leave home sequence executed");
        }
    }

    public void ReturnHome()
    {
        if (CheckAccess())
        {
            _realSystem.ReturnHome();
            LogAction("Return home sequence executed");
        }
    }
}