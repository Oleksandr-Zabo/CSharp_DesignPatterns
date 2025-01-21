namespace Patterns_2.FlyWeight;

public class ClientCode
{ 
    public void Main()
    {
        KeywordFactory keywordFactory = new KeywordFactory();
        TextEditor textEditor = new TextEditor(keywordFactory);

        string code = "if (x > 0) { return x; } else { return 0; }";

        Console.Clear();
        textEditor.HighlightText(code);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();// Wait for user input
    }
}