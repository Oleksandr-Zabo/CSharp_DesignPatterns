namespace Patterns_1.Builder;

public interface IBuilder <T>
{
    T AddEngine();
    T AddWheels();
    T AddDoors();
    T AddRoof();
    T AddWindows();
    T AddMirrors();
    T AddLights();
        
    T RemoveEngine();
    T RemoveWheels();
    T RemoveDoors();
    T RemoveRoof();
    T RemoveWindows();
    T RemoveMirrors();
    T RemoveLights();
}

public abstract class Builder<T> : IBuilder<T>
{
    protected virtual void GetActionInfo(string action, string part)
    {
        Console.WriteLine($"{action} {part}");
    }
    
    public Builder<T> BuilderCopy() //using prototype pattern
    {
        return (Builder<T>)MemberwiseClone();
    }
    
    protected Car<T> car { get; set;} 
    
    public abstract T AddEngine();
    public abstract T AddWheels();
    public abstract T AddDoors();
    public abstract T AddRoof();
    public abstract T AddWindows();
    public abstract T AddMirrors();
    public abstract T AddLights();
    
    public abstract T RemoveEngine();
    public abstract T RemoveWheels();
    public abstract T RemoveDoors();
    public abstract T RemoveRoof();
    public abstract T RemoveWindows();
    public abstract T RemoveMirrors();
    public abstract T RemoveLights();
}

public class EconomyCarBuilder : Builder<string>
{
    public EconomyCarBuilder()
    {
        car = new EconomyCar();
    }

    public override string AddEngine()
    {
        GetActionInfo("Adding", "Economy engine");
        car.AddPart("Engine");
        return "Economy engine added";
    }

    public override string AddWheels()
    {
        GetActionInfo("Adding", "Economy wheels");
        car.AddPart("Wheels");
        return "Economy wheels added";
    }

    public override string AddDoors()
    {
        GetActionInfo("Adding", "Economy doors");
        car.AddPart("Doors");
        return "Economy doors added";
    }

    public override string AddRoof()
    {
        GetActionInfo("Adding", "Economy roof");
        car.AddPart("Roof");
        return "Economy roof added";
    }

    public override string AddWindows()
    {
        GetActionInfo("Adding", "Economy windows");
        car.AddPart("Windows");
        return "Economy windows added";
    }

    public override string AddMirrors()
    {
        GetActionInfo("Adding", "Economy mirrors");
        car.AddPart("Mirrors");
        return "Economy mirrors added";
    }

    public override string AddLights()
    {
        GetActionInfo("Adding", "Economy lights");
        car.AddPart("Lights");
        return "Economy lights added";
    }

    public override string RemoveEngine()
    {
        GetActionInfo("Removing", "Economy engine");
        car.RemovePart("Engine");
        return "Economy engine removed";
    }

    public override string RemoveWheels()
    {
        GetActionInfo("Removing", "Economy wheels");
        car.RemovePart("Wheels");
        return "Economy wheels removed";
    }

    public override string RemoveDoors()
    {
        GetActionInfo("Removing", "Economy doors");
        car.RemovePart("Doors");
        return "Economy doors removed";
    }

    public override string RemoveRoof()
    {
        GetActionInfo("Removing", "Economy roof");
        car.RemovePart("Roof");
        return "Economy roof removed";
    }

    public override string RemoveWindows()
    {
        GetActionInfo("Removing", "Economy windows");
        car.RemovePart("Windows");
        return "Economy windows removed";
    }

    public override string RemoveMirrors()
    {
        GetActionInfo("Removing", "Economy mirrors");
        car.RemovePart("Mirrors");
        return "Economy mirrors removed";
    }

    public override string RemoveLights()
    {
        GetActionInfo("Removing", "Economy lights");
        car.RemovePart("Lights");
        return "Economy lights removed";
    }
}

public class LuxuryCarBuilder : Builder<string>
{
    public LuxuryCarBuilder()
    {
        car = new LuxuryCar();
    }

    public override string AddEngine()
    {
        GetActionInfo("Adding", "Luxury engine");
        car.AddPart("Engine");
        return "Luxury engine added";
    }

    public override string AddWheels()
    {
        GetActionInfo("Adding", "Luxury wheels");
        car.AddPart("Wheels");
        return "Luxury wheels added";
    }

    public override string AddDoors()
    {
        GetActionInfo("Adding", "Luxury doors");
        car.AddPart("Doors");
        return "Luxury doors added";
    }

    public override string AddRoof()
    {
        GetActionInfo("Adding", "Luxury roof");
        car.AddPart("Roof");
        return "Luxury roof added";
    }

    public override string AddWindows()
    {
        GetActionInfo("Adding", "Luxury windows");
        car.AddPart("Windows");
        return "Luxury windows added";
    }

    public override string AddMirrors()
    {
        GetActionInfo("Adding", "Luxury mirrors");
        car.AddPart("Mirrors");
        return "Luxury mirrors added";
    }

    public override string AddLights()
    {
        GetActionInfo("Adding", "Luxury lights");
        car.AddPart("Lights");
        return "Luxury lights added";
    }

    public override string RemoveEngine()
    {
        GetActionInfo("Removing", "Luxury engine");
        car.RemovePart("Engine");
        return "Luxury engine removed";
    }

    public override string RemoveWheels()
    {
        GetActionInfo("Removing", "Luxury wheels");
        car.RemovePart("Wheels");
        return "Luxury wheels removed";
    }

    public override string RemoveDoors()
    {
        GetActionInfo("Removing", "Luxury doors");
        car.RemovePart("Doors");
        return "Luxury doors removed";
    }

    public override string RemoveRoof()
    {
        GetActionInfo("Removing", "Luxury roof");
        car.RemovePart("Roof");
        return "Luxury roof removed";
    }

    public override string RemoveWindows()
    {
        GetActionInfo("Removing", "Luxury windows");
        car.RemovePart("Windows");
        return "Luxury windows removed";
    }

    public override string RemoveMirrors()
    {
        GetActionInfo("Removing", "Luxury mirrors");
        car.RemovePart("Mirrors");
        return "Luxury mirrors removed";
    }

    public override string RemoveLights()
    {
        GetActionInfo("Removing", "Luxury lights");
        car.RemovePart("Lights");
        return "Luxury lights removed";
    }
}

public class SportCarBuilder : Builder<string>
{
    public SportCarBuilder()
    {
        car = new SportCar();
    }

    public override string AddEngine()
    {
        GetActionInfo("Adding", "Sport engine");
        car.AddPart("Engine");
        return "Sport engine added";
    }

    public override string AddWheels()
    {
        GetActionInfo("Adding", "Sport wheels");
        car.AddPart("Wheels");
        return "Sport wheels added";
    }

    public override string AddDoors()
    {
        GetActionInfo("Adding", "Sport doors");
        car.AddPart("Doors");
        return "Sport doors added";
    }

    public override string AddRoof()
    {
        GetActionInfo("Adding", "Sport roof");
        car.AddPart("Roof");
        return "Sport roof added";
    }

    public override string AddWindows()
    {
        GetActionInfo("Adding", "Sport windows");
        car.AddPart("Windows");
        return "Sport windows added";
    }

    public override string AddMirrors()
    {
        GetActionInfo("Adding", "Sport mirrors");
        car.AddPart("Mirrors");
        return "Sport mirrors added";
    }

    public override string AddLights()
    {
        GetActionInfo("Adding", "Sport lights");
        car.AddPart("Lights");
        return "Sport lights added";
    }

    public override string RemoveEngine()
    {
        GetActionInfo("Removing", "Sport engine");
        car.RemovePart("Engine");
        return "Sport engine removed";
    }

    public override string RemoveWheels()
    {
        GetActionInfo("Removing", "Sport wheels");
        car.RemovePart("Wheels");
        return "Sport wheels removed";
    }

    public override string RemoveDoors()
    {
        GetActionInfo("Removing", "Sport doors");
        car.RemovePart("Doors");
        return "Sport doors removed";
    }

    public override string RemoveRoof()
    {
        GetActionInfo("Removing", "Sport roof");
        car.RemovePart("Roof");
        return "Sport roof removed";
    }

    public override string RemoveWindows()
    {
        GetActionInfo("Removing", "Sport windows");
        car.RemovePart("Windows");
        return "Sport windows removed";
    }

    public override string RemoveMirrors()
    {
        GetActionInfo("Removing", "Sport mirrors");
        car.RemovePart("Mirrors");
        return "Sport mirrors removed";
    }
    
    public override string RemoveLights()
    {
        GetActionInfo("Removing", "Sport lights");
        car.RemovePart("Lights");
        return "Sport lights removed";
    }
}