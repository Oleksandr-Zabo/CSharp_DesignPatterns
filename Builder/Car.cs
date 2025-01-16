namespace Patterns_1.Builder;

  
public interface IProduct<T>
{
    void AddPart(T part);
    void RemovePart(T part);
    void Show();
}

public class Car<T> : IProduct<T>
{
    protected List<T> _parts = new List<T>();

    public virtual void AddPart(T part)
    {
        _parts.Add(part);
    }

    public virtual void RemovePart(T part)
    {
        _parts.Remove(part);
    }

    public virtual void Show()
    {
        Console.WriteLine("\nCar parts -------");
        foreach (T part in _parts)
            Console.WriteLine(part);
        Console.WriteLine();
    }
}

public class EconomyCar: Car<string>
{
    public override void Show()
    {
        Console.WriteLine("\nEconomy Car -------");
        foreach (string part in _parts)
            Console.WriteLine(part);
        Console.WriteLine();
    }
}

public class LuxuryCar: Car<string>
{
    public override void Show()
    {
        Console.WriteLine("\nLuxury Car -------");
        foreach (string part in _parts)
            Console.WriteLine(part);
        Console.WriteLine();
    }
}

public class SportCar: Car<string>
{
    public override void Show()
    {
        Console.WriteLine("\nSport Car -------");
        foreach (string part in _parts)
            Console.WriteLine(part);
        Console.WriteLine();
    }
}