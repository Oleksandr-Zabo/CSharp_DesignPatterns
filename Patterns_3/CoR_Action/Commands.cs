namespace Patterns_3.CoR_Action;

//Commands - Command Pattern

public interface ICommand
{
    void Execute();
}

public class TechnicalSupportCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Executing technical support...");
    }
}

public class BillingSupportCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Processing payment...");
    }
}

public class GeneralSupportCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Providing general support...");
    }
}