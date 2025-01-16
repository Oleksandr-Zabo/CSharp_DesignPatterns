namespace Patterns_1.Builder;

public class ClientCode
{
    public void Main()
    {
        var economyCarBuilder = new EconomyCarBuilder();
        var director = new Director(economyCarBuilder);
        Console.WriteLine("");
        Console.WriteLine("App: Launched with the EconomyCarBuilder");
        director.AddEconomyFullCar();
        Console.WriteLine("");
        Console.WriteLine("App: Destroying the EconomyCar.");
        director.DelCar();
        Console.WriteLine("");
        
        var luxuryCarBuilder = new LuxuryCarBuilder();
        director = new Director(luxuryCarBuilder);
        Console.WriteLine("App: Launched with the LuxuryCarBuilder");
        director.AddLuxuryFullCar();
        Console.WriteLine("");
        Console.WriteLine("App: Destroying the LuxuryCar.");
        director.DelCar();
        Console.WriteLine("");
        
        var sportCarBuilder = new SportCarBuilder();
        director = new Director(sportCarBuilder);
        Console.WriteLine("App: Launched with the SportCarBuilder");
        director.AddSportFullCar();
        Console.WriteLine("");
        Console.WriteLine("App: Destroying the SportCar.");
        director.DelCar();
        Console.WriteLine("");
        
        var minEconomyCarBuilder = economyCarBuilder.BuilderCopy();
        director = new Director(minEconomyCarBuilder);
        Console.WriteLine("App: Launched with the MinEconomyCarBuilder");
        director.AddEconomyMinimumCar();
        Console.WriteLine("");
        Console.WriteLine("App: Destroying the MinEconomyCar.");
        director.DelMinimumCar();
        Console.WriteLine("");
    }
    
}