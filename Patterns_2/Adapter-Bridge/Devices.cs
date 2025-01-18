namespace Patterns_2.Adapter_Bridge;

public interface IDevice
{
    void PlayAudio(AudioFile music);
    void Stop();
}

public abstract class Device : IDevice
{
    public abstract void PlayAudio(AudioFile music);
    public abstract void Stop();
}

class Speakers : Device
{
    public override void PlayAudio(AudioFile music)
    {
        music.ConvertToMp3();//Adapter
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Playing mp3 through the speakers: {music.GetFullFile()}");
        Console.ResetColor();
    }
    
    public override void Stop()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Stopping the speakers.");
        Console.ResetColor();
    }
}

class Headphones : Device
{
    public override void PlayAudio(AudioFile music)
    {
        music.ConvertToMp3();//Adapter
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Playing mp3 through the headphones: {music.GetFullFile()}");
        Console.ResetColor();
    }
    
    public override void Stop()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Stopping the headphones.");
        Console.ResetColor();
    }
}

class BluetoothDevice : Device
{
    public override void PlayAudio(AudioFile music)
    {
        music.ConvertToMp3();//Adapter
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Playing mp3 through the bluetooth device: {music.GetFullFile()}");
        Console.ResetColor();
    }
    
    public override void Stop()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Stopping the bluetooth device.");
        Console.ResetColor();
    }
}