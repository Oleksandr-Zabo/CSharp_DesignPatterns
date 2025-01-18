namespace Patterns_2.Adapter_Bridge;

public class ClientCode
{
    public void Main()
    {
        Console.WriteLine();
        
        Console.WriteLine("App: Launched with the SpeakersBasicFactor:");
        var speakersBasicFactory = new SpeakersBasicFactory();
        speakersBasicFactory.PlayMusic();
        
        Console.WriteLine();
        
        Console.WriteLine("App: Launched with the HeadphonesProFactory:");
        var headphonesProFactory = new HeadphonesProFactory();
        headphonesProFactory.PlayMusic();
        
        Console.WriteLine();
        
        Console.WriteLine("App: Launched with the BluetoothBasicFactory:");
        var bluetoothBasicFactory = new BluetoothBasicFactory();
        bluetoothBasicFactory.PlayMusic();
        
        Console.WriteLine();
    }
}