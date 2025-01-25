namespace Patterns_3.Iterator;

public class ClientCode
{
    public void Main()
    {
        // Create the category tree
        var electronics = new Category("Electronics");
        var smartphones = new Category("Smartphones");
        var apple = new Category("Apple");
        var samsung = new Category("Samsung");
        var laptops = new Category("Laptops");
        var gamingLaptops = new Category("Gaming Laptops");
        var ultrabooks = new Category("Ultrabooks");

        electronics.AddSubcategory(smartphones);
        smartphones.AddSubcategory(apple);
        smartphones.AddSubcategory(samsung);
        electronics.AddSubcategory(laptops);
        laptops.AddSubcategory(gamingLaptops);
        laptops.AddSubcategory(ultrabooks);

        var categoryTree = new CategoryTree(electronics);
        
        // Depth-First Traversal
        Console.WriteLine("Depth-First Traversal:");
        var depthFirstIterator = categoryTree.GetDepthFirstIterator();
        while (depthFirstIterator.HasNext())
        {
            depthFirstIterator.Next();
        }
        Console.WriteLine();
        
        // Breadth-First Traversal
        Console.WriteLine("\nBreadth-First Traversal:");
        var breadthFirstIterator = categoryTree.GetBreadthFirstIterator();
        while (breadthFirstIterator.HasNext())
        {
            breadthFirstIterator.Next();
        }
        Console.WriteLine();

        // Depth-First Traversal with lines
        Console.WriteLine("Depth-First Traversal with Lines:");
        var depthFirstIteratorLines = new DepthFirstIteratorLines(electronics);
        while (depthFirstIteratorLines.HasNext())
        {
            depthFirstIteratorLines.Next();
        }
        Console.WriteLine();

        // Breadth-First Traversal with lines
        Console.WriteLine("\nBreadth-First Traversal with Lines:");
        var breadthFirstIteratorLines = new BreadthFirstIteratorLines(electronics);
        while (breadthFirstIteratorLines.HasNext())
        {
            breadthFirstIteratorLines.Next();
        }
        Console.WriteLine();
        
    }
}