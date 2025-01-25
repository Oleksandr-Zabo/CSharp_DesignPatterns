namespace Patterns_3.CoR_Action;

public class ClientCode//MVVM: V-View (Console Interface)
{
    public void Main()
    {
        // Create ViewModel
        var viewModel = new SupportViewModel();

        // Example requests
        var technicalRequest = new SupportRequest { Type = RequestType.Technical, Description = "Internet is not working" };
        var billingRequest = new SupportRequest { Type = RequestType.Billing, Description = "Question about invoice" };
        var generalRequest = new SupportRequest { Type = RequestType.General, Description = "General inquiry" };
        var unknownRequest = new SupportRequest { Type = RequestType.Unknown, Description = "Unknown request type" };
        
        Console.ForegroundColor = ConsoleColor.Green;
        
        // Process requests
        viewModel.ProcessRequest(technicalRequest);
        Console.WriteLine();
        viewModel.ProcessRequest(billingRequest);
        Console.WriteLine();
        viewModel.ProcessRequest(generalRequest);
        Console.WriteLine();
        viewModel.ProcessRequest(unknownRequest);
        
        Console.ResetColor();
    }
}