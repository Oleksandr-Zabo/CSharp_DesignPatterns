namespace Patterns_2.FlyWeight;

public class TextEditor
{
    private readonly KeywordFactory _keywordFactory;

    public TextEditor(KeywordFactory keywordFactory)
    {
        _keywordFactory = keywordFactory;
    }

    public void HighlightText(string text)
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            if (IsKeyword(word))
            {
                Keyword keyword = _keywordFactory.GetKeyword(word, ConsoleColor.Yellow);
                keyword.Highlight();
            }
            else
            {
                Console.Write(word);
            }

            Console.Write(" "); // Додаємо пробіл між словами
        }
    }

    private bool IsKeyword(string word)// Перевіряємо, чи слово є ключовим
    {
        string[] keywords = { "if", "else", "for", "while", "return" };
        return keywords.Contains(word);
    }
}