namespace Patterns_1.AbstractFactory;

//Chairs
public interface IChair
{
    string SitOn();
    string Move();
    string Description();
}

public abstract class Chair : IChair
{
    public abstract string SitOn();
    public abstract string Move();
    public abstract string Description();
}

public class ModernChair : Chair
{
    public override string SitOn()
    {
        return "You sit on a modern chair";
    }

    public override string Move()
    {
        return "You move a modern chair";
    }

    public override string Description()
    {
        return "Modern chair";
    }
}

public class VictorianChair : Chair
{
    public override string SitOn()
    {
        return "You sit on a victorian chair";
    }

    public override string Move()
    {
        return "You move a victorian chair";
    }

    public override string Description()
    {
        return "Victorian chair";
    }
}


//Sofas
public interface ISofa
{
    string SitOn();
    string Lying();
    string Description();
}

public abstract class Sofa : ISofa
{
    public abstract string SitOn();
    public abstract string Lying();
    public abstract string Description();
}

public class ModernSofa : Sofa
{
    public override string SitOn()
    {
        return "You sit on a modern sofa";
    }

    public override string Lying()
    {
        return "You lie on a modern sofa";
    }

    public override string Description()
    {
        return "Modern sofa";
    }
}

public class VictorianSofa : Sofa
{
    public override string SitOn()
    {
        return "You sit on a victorian sofa";
    }

    public override string Lying()
    {
        return "You lie on a victorian sofa";
    }

    public override string Description()
    {
        return "Victorian sofa";
    }
}


//CoffeeTables
public interface ICoffeeTable
{
    string PutOn();
    string TakeOff();
    string Eat();
    string Description();
}

public abstract class CoffeeTable : ICoffeeTable
{
    public abstract string PutOn();
    public abstract string TakeOff();
    public abstract string Eat();
    public abstract string Description();
}

public class ModernCoffeeTable : CoffeeTable
{
    public override string PutOn()
    {
        return "You put on a modern coffee table";
    }

    public override string TakeOff()
    {
        return "You take off a modern coffee table";
    }

    public override string Eat()
    {
        return "You eat on a modern coffee table";
    }

    public override string Description()
    {
        return "Modern coffee table";
    }
}

public class VictorianCoffeeTable : CoffeeTable
{
    public override string PutOn()
    {
        return "You put on a victorian coffee table";
    }

    public override string TakeOff()
    {
        return "You take off a victorian coffee table";
    }

    public override string Eat()
    {
        return "You eat on a victorian coffee table";
    }

    public override string Description()
    {
        return "Victorian coffee table";
    }
}