namespace Patterns_1.FabricMethod;

public class ClientCode
{
    public void Main()
    {
        Console.WriteLine("Enemy Factory Demo\n");

        // test the factory method
        Creator[] creators = { 
            new EasyLevel(true),
            new EasyLevel(false),
            new NormalLevel(true),
            new NormalLevel(false),
            new HardLevel(true),
            new HardLevel(false)
        };

        foreach (var creator in creators)
        {
            Console.ForegroundColor = GetColorForCreator(creator);
            Console.WriteLine(creator.DamageOperation());
            Console.ResetColor();
        }

        // Direct enemy creation demo
        Console.WriteLine("\nDirect enemy creation demo:");
        
        Enemy hardZombie = new HardLevel(true).FabricMethod();
        Enemy easySkele = new EasyLevel(false).FabricMethod();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Hard Zombie - Health: {hardZombie.Health}, Damage: {hardZombie.Damage}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Easy Skeleton - Health: {easySkele.Health}, Damage: {easySkele.Damage}");
        Console.ResetColor();
    }

    private static ConsoleColor GetColorForCreator(Creator creator)
    {
        return creator switch
        {
            EasyLevel => ConsoleColor.Green,
            NormalLevel => ConsoleColor.Yellow,
            HardLevel => ConsoleColor.Red,
            _ => ConsoleColor.White
        };
    }
}