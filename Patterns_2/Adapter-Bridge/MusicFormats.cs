namespace Patterns_2.Adapter_Bridge;

interface IAudioFile
{
    string GetFileFormat();
    string GetFileName();
    string GetFullFile();
    void ConvertToMp3();//Adapter
}

public abstract class AudioFile : IAudioFile
{
    protected string _fileFormat;
    protected string _fileName;

    public string GetFileFormat()
    {
        return _fileFormat;
    }

    public string GetFileName()
    {
        return _fileName;
    }
    
    public string GetFullFile()
    {
        return $"{_fileName}.{_fileFormat}";
    }

    public abstract void ConvertToMp3();

}

public class MP3File : AudioFile
{
    public MP3File(string fileName)
    {
        _fileFormat = "mp3";
        _fileName = fileName;
    }

    public override void ConvertToMp3()
    {
        Console.Write("");
    }
}
public class WAVFile: AudioFile
{
    public WAVFile(string fileName)
    {
        _fileFormat = "wav";
        _fileName = fileName;
    }
    
    public override void ConvertToMp3()//Adapter
    {
        _fileFormat = "mp3";
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Converting wav to mp3");
        Console.ResetColor();
    }
}
public class OGGFile: AudioFile
{
    public OGGFile(string fileName)
    {
        _fileFormat = "ogg";
        _fileName = fileName;
    }
    
    public override void ConvertToMp3()//Adapter
    {
        _fileFormat = "mp3";
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Converting ogg to mp3");
        Console.ResetColor();
    }
}