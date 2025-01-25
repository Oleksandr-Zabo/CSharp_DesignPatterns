namespace Patterns_3.CoR_Action;

//Handlers- Chain of Responsibility
public interface IHandler
{
    IHandler SetNext(IHandler handler);
    void Handle(SupportRequest request);
}

public abstract class AbstractHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void Handle(SupportRequest request)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
        else
        {
            Console.WriteLine("No handler available for this request type.");
        }
    }
}

// Concrete handlers
public class TechnicalSupportHandler : AbstractHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.Type == RequestType.Technical)
        {
            Console.WriteLine("Processing technical request: " + request.Description);
            new TechnicalSupportCommand().Execute();
        }
        else
        {
            base.Handle(request);
        }
    }
}

public class BillingSupportHandler : AbstractHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.Type == RequestType.Billing)
        {
            Console.WriteLine("Processing billing request: " + request.Description);
            new BillingSupportCommand().Execute();
        }
        else
        {
            base.Handle(request);
        }
    }
}

public class GeneralSupportHandler : AbstractHandler
{
    public override void Handle(SupportRequest request)
    {
        if (request.Type == RequestType.General)
        {
            Console.WriteLine("Processing general request: " + request.Description);
            new GeneralSupportCommand().Execute();
        }
        else
        {
            base.Handle(request);
        }
    }
}