namespace Patterns_1.FabricMethod;

public abstract class Creator
{
    public abstract Enemy FabricMethod();

    public string DamageOperation()
    {
        var product = FabricMethod();
        string result = "Creator: The same creator's code has just worked with " + product.Attack();
        return result;
    }
}

public class EasyLevel : Creator
{
    private readonly bool isZombie;

    public EasyLevel(bool createZombie = true)
    {
        isZombie = createZombie;
    }

    public override Enemy FabricMethod()
    {
        return isZombie ? new Zombie(50, 5) : new Skeleton(20, 3);
    }
}

public class NormalLevel : Creator
{
    private readonly bool isZombie;

    public NormalLevel(bool createZombie = true)
    {
        isZombie = createZombie;
    }

    public override Enemy FabricMethod()
    {
        return isZombie ? new Zombie(100, 10) : new Skeleton(50, 5);
    }
}

public class HardLevel : Creator
{
    private readonly bool isZombie;

    public HardLevel(bool createZombie = true)
    {
        isZombie = createZombie;
    }

    public override Enemy FabricMethod()
    {
        return isZombie ? new Zombie(200, 20) : new Skeleton(100, 10);
    }
}