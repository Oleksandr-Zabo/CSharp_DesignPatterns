namespace Patterns_2.Adapter_Bridge;

public abstract class Player
{
    public abstract void Play();
}

public class BasicPlayer : Player
{
    public override void Play()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Playing music with Basic Player: ");
        Console.ResetColor();
    }
}

public class PlayerWithEqualiser : Player
{
    public override void Play()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Playing music with Player with Equaliser: ");
        Console.ResetColor();
    }
}
