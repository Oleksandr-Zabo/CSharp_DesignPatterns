namespace Patterns_3.CoR_Action;

public class SupportViewModel//MVVM: VM- ViewModel
{
    // Chain of Responsibility
    private IHandler _handlerChain;

    public SupportViewModel()
    {
        // Create the chain of handlers
        var technicalHandler = new TechnicalSupportHandler();
        var billingHandler = new BillingSupportHandler();
        var generalHandler = new GeneralSupportHandler();

        technicalHandler.SetNext(billingHandler).SetNext(generalHandler);
        _handlerChain = technicalHandler;
    }

    // Command to process a request
    public void ProcessRequest(SupportRequest request)
    {
        Console.WriteLine($"Starting to process request: {request.Type}");
        _handlerChain.Handle(request);
    }
}