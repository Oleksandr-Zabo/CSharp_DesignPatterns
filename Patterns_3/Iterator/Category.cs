namespace Patterns_3.Iterator;

public class Category
{
    public string Name { get; set; } // Name of the category
    public List<Category> Subcategories { get; set; } // List of subcategories

    public Category(string name)
    {
        Name = name;
        Subcategories = new List<Category>();
    }

    // Add a subcategory to the list
    public void AddSubcategory(Category subcategory)
    {
        Subcategories.Add(subcategory);
    }
}