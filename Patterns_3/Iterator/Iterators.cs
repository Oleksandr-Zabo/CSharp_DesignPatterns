namespace Patterns_3.Iterator;
using System.Collections.Generic;

public interface IIterator<T>
{
    bool HasNext(); // Is there a next element?
    T Next();       // Get the next element
}

// Concrete iterators

public class DepthFirstIterator : IIterator<Category>
{
    private Stack<(Category Node, int Level)> _stack = new Stack<(Category, int)>();

    public DepthFirstIterator(Category root)
    {
        _stack.Push((root, 0)); // Start with the root category(0 level) and add it to the stack
    }

    public bool HasNext()
    {
        return _stack.Count > 0;
    }

    public Category Next()
    {
        var (current, level) = _stack.Pop(); // Get the current category
        // Add subcategories to the stack in reverse order
        for (int i = current.Subcategories.Count - 1; i >= 0; i--)
        {
            _stack.Push((current.Subcategories[i], level + 1)); // Add subcategory to the stack
        }
        // Print the category name
        Console.WriteLine($"{new string(' ', level * 4)}- {current.Name}");
        return current;
    }
}

public class BreadthFirstIterator : IIterator<Category>
{
    private Queue<(Category Node, int Level)> _queue = new Queue<(Category, int)>();

    public BreadthFirstIterator(Category root)
    {
        _queue.Enqueue((root, 0)); // Start with the root category(0 level)
    }

    public bool HasNext()
    {
        return _queue.Count > 0;// Check if there are elements in the queue
    }

    public Category Next()
    {
        var (current, level) = _queue.Dequeue(); // Get the current category
        // Add subcategories to the queue
        foreach (var subcategory in current.Subcategories)
        {
            _queue.Enqueue((subcategory, level + 1)); // Add subcategory to the queue
        }
        // Print the category name
        Console.WriteLine($"{new string(' ', level * 4)}- {current.Name}");
        return current;
    }
}

public class DepthFirstIteratorLines : IIterator<Category>
{
    private Stack<(Category Node, int Level, bool IsLast)> _stack = new Stack<(Category, int, bool)>();

    public DepthFirstIteratorLines(Category root)
    {
        _stack.Push((root, 0, true)); // Start with the root category (level 0, isLast = true)
    }

    public bool HasNext()
    {
        return _stack.Count > 0;
    }

    public Category Next()
    {
        var (current, level, isLast) = _stack.Pop(); // Get the current category
        // Add subcategories to the stack in reverse order
        for (int i = current.Subcategories.Count - 1; i >= 0; i--)
        {
            // Check if the current subcategory is the last one in its level
            bool isSubLast = (i == 0);
            _stack.Push((current.Subcategories[i], level + 1, isSubLast));
        }
        // Print the category name with proper indentation and symbols
        Console.WriteLine($"{GetIndentation(level, isLast)}{current.Name}");
        return current;
    }

    private string GetIndentation(int level, bool isLast)
    {
        string indentation = "";
        for (int i = 0; i < level; i++)
        {
            indentation += "    "; // 4 spaces per level
        }
        return indentation + (isLast ? "└── " : "├── ");
    }
}

public class BreadthFirstIteratorLines : IIterator<Category>
{
    private Queue<(Category Node, int Level, bool IsLast)> _queue = new Queue<(Category, int, bool)>();

    public BreadthFirstIteratorLines(Category root)
    {
        _queue.Enqueue((root, 0, true)); // Start with the root category (level 0, isLast = true)
    }

    public bool HasNext()
    {
        return _queue.Count > 0;
    }

    public Category Next()
    {
        var (current, level, isLast) = _queue.Dequeue(); // Get the current category
        // Add subcategories to the queue
        for (int i = 0; i < current.Subcategories.Count; i++)
        {
            bool isSubLast = (i == current.Subcategories.Count - 1);
            _queue.Enqueue((current.Subcategories[i], level + 1, isSubLast));
        }
        // Print the category name with proper indentation and symbols
        Console.WriteLine($"{GetIndentation(level, isLast)}{current.Name}");
        return current;
    }

    private string GetIndentation(int level, bool isLast)
    {
        string indentation = "";
        for (int i = 0; i < level; i++)
        {
            indentation += "    "; // 4 spaces per level
        }
        return indentation + (isLast ? "└── " : "├── ");
    }
}
