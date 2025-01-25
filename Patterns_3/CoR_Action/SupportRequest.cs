namespace Patterns_3.CoR_Action;

public enum RequestType
{
    Technical, // Technical request
    Billing,   // Billing request
    General,   // General request
    Unknown    // Unknown request type

}

public class SupportRequest//MVVM: M- Model(Entity)
{
    public RequestType Type { get; set; } // Request type
    public string Description { get; set; } // Problem description
    
}