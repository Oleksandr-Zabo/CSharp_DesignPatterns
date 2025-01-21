namespace Patterns_2.FlyWeight;

public class Keyword
{
    private readonly string _word;
    private readonly ConsoleColor _color;

    public Keyword(string word, ConsoleColor color)
    {
        _word = word;
        _color = color;
    }

    public void Highlight()
    {
        Console.ForegroundColor = _color;
        Console.Write(_word);
        Console.ResetColor();
    }

    public string Word => _word; // Властивість для отримання слова
}

public class KeywordFactory
{
    private static readonly List<Keyword> _keywords = new();

    public Keyword GetKeyword(string word, ConsoleColor color)
    {
        // Перевіряємо, чи слово вже є в списку
        Keyword existingKeyword = _keywords.FirstOrDefault(k => k.Word == word);
        if (existingKeyword != null)
        {
            return existingKeyword;
        }

        // Якщо слова немає в списку, створюємо новий об'єкт і додаємо його до списку
        Keyword newKeyword = new Keyword(word, color);
        _keywords.Add(newKeyword);
        return newKeyword;
    }
}