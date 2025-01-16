namespace Patterns_1.Builder;

public class Director
{
    private static Director? _instance; //using singleton pattern
    private static object _lock = new object();
    private Director() { }
    public static Director GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Director();
                }
            }
        }
        return _instance;
    }
    
    private IBuilder<string> _builder;

    public Director(IBuilder<string> builder)
    {
        _builder = builder;
    }

    
    //EconomyCar
    public void AddEconomyMinimumCar()
    {
        _builder.AddEngine();
        _builder.AddWheels();
        _builder.AddDoors();
    }

    public void AddEconomyFullCar()
    {
        _builder.AddEngine();
        _builder.AddWheels();
        _builder.AddDoors();
        _builder.AddRoof();
        _builder.AddWindows();
        _builder.AddMirrors();
        _builder.AddLights();
    }

    //LuxuryCar
    public void AddLuxuryMinimumCar()
    {
        _builder.AddEngine();
        _builder.AddWheels();
        _builder.AddDoors();
    }
    
    public void AddLuxuryFullCar()
    {
        _builder.AddEngine();
        _builder.AddWheels();
        _builder.AddDoors();
        _builder.AddRoof();
        _builder.AddWindows();
        _builder.AddMirrors();
        _builder.AddLights();
    }

    //SportCar
    public void AddSportMinimumCar()
    {
        _builder.AddEngine();
        _builder.AddWheels();
        _builder.AddDoors();
    }
    
    public void AddSportFullCar()
    {
        _builder.AddEngine();
        _builder.AddWheels();
        _builder.AddDoors();
        _builder.AddRoof();
        _builder.AddWindows();
        _builder.AddMirrors();
        _builder.AddLights();
    }
        
    //Remove
    public void DelMinimumCar()
    {
        _builder.RemoveEngine();
        _builder.RemoveWheels();
        _builder.RemoveDoors();
    }
    public void DelCar()
    {
        _builder.RemoveEngine();
        _builder.RemoveWheels();
        _builder.RemoveDoors();
        _builder.RemoveRoof();
        _builder.RemoveWindows();
        _builder.RemoveMirrors();
        _builder.RemoveLights();
    }
}