namespace Patterns_2.Adapter_Bridge;

public interface IAbstractFactory//Abstract Factory + Bridge
{
    IDevice CreateDevice();
    Player CreatePlayer();
    
    void PlayMusic();
}

public abstract class AbstractFactory : IAbstractFactory
{
    public abstract IDevice CreateDevice();
    public abstract Player CreatePlayer();
    
    public void PlayMusic()
    {
        IDevice device = CreateDevice();
        Player player = CreatePlayer();
        
        player.Play();
        device.PlayAudio(new WAVFile("song"));
        device.PlayAudio(new MP3File("song1"));
        device.PlayAudio(new OGGFile("song2"));
        device.Stop();
    }
}

//Concrete Factories

//Speakers
public class SpeakersBasicFactory : AbstractFactory
{
    public override IDevice CreateDevice()
    {
        return new Speakers();
    }
    
    public override Player CreatePlayer()
    {
        return new BasicPlayer();
    }
}
public class SpeakersProFactory : AbstractFactory
{
    public override IDevice CreateDevice()
    {
        return new Speakers();
    }
    
    public override Player CreatePlayer()
    {
        return new PlayerWithEqualiser();
    }
}

//Headphones
public class HeadphonesBasicFactory : AbstractFactory
{
    public override IDevice CreateDevice()
    {
        return new Headphones();
    }
    
    public override Player CreatePlayer()
    {
        return new BasicPlayer();
    }
}
public class HeadphonesProFactory : AbstractFactory
{
    public override IDevice CreateDevice()
    {
        return new Headphones();
    }
    
    public override Player CreatePlayer()
    {
        return new PlayerWithEqualiser();
    }
}

//Bluetooth
public class BluetoothBasicFactory : AbstractFactory
{
    public override IDevice CreateDevice()
    {
        return new BluetoothDevice();
    }
    
    public override Player CreatePlayer()
    {
        return new BasicPlayer();
    }
}
public class BluetoothProFactory : AbstractFactory
{
    public override IDevice CreateDevice()
    {
        return new BluetoothDevice();
    }
    
    public override Player CreatePlayer()
    {
        return new PlayerWithEqualiser();
    }
}

