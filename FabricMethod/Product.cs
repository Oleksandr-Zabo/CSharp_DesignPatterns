namespace Patterns_1.FabricMethod;

public interface IEnemy
{
    string Attack();
}

public abstract class Enemy: IEnemy
{
    public int Health { get; set; }
    public int Damage { get; set; }

    public abstract string Attack();
}

public class Zombie: Enemy
{
    public Zombie()
    {
        Health = 100;
        Damage = 10;
    }
    
    public Zombie(int health, int damage)
    {
        Health = health;
        Damage = damage;
    }

    public override string  Attack()
    {
        return "Zombie attacks with " + Damage + " damage";
    }
}

public class Skeleton: Enemy
{
    public Skeleton()
    {
        Health = 50;
        Damage = 5;
    }
    
    public Skeleton(int health, int damage)
    {
        Health = health;
        Damage = damage;
    }

    public override string Attack()
    {
        return "Skeleton attacks with " + Damage + " damage";
    }
}