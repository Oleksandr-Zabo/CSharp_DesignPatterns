namespace Patterns_3.Iterator;

public class CategoryTree
{
    public Category Root { get; set; } // Root category

    public CategoryTree(Category root)
    {
        Root = root;
    }

    // Get the iterator for depth-first traversal
    public IIterator<Category> GetDepthFirstIterator()
    {
        return new DepthFirstIterator(Root);
    }

    // Get the iterator for breadth-first traversal
    public IIterator<Category> GetBreadthFirstIterator()
    {
        return new BreadthFirstIterator(Root);
    }
}