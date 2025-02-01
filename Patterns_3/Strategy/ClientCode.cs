namespace Patterns_3.Strategy;

public class ClientCode
{
    public void Main()
    {
        // Create a list of people
        var people = new List<Person>
        {
            new Person("John", 25, "New York"),
            new Person("Alice", 30, "Los Angeles"),
            new Person("Bob", 20, "New York"),
            new Person("Charlie", 35, "Chicago")
        };

        // Create a filter context
        var filterContext = new FilterContext();

        // Filter by age (>= 25)
        filterContext.SetStrategy(new AgeFilterStrategy(25));
        var filteredByAge = filterContext.ExecuteFilter(people);
        Console.WriteLine("Filtered by age (>= 25):");
        PrintPeople(filteredByAge);

        // Filter by name (Alice)
        filterContext.SetStrategy(new NameFilterStrategy("Alice"));
        var filteredByName = filterContext.ExecuteFilter(people);
        Console.WriteLine("\nFiltered by name (Alice):");
        PrintPeople(filteredByName);

        // Filter by city (New York)
        filterContext.SetStrategy(new CityFilterStrategy("New York"));
        var filteredByCity = filterContext.ExecuteFilter(people);
        Console.WriteLine("\nFiltered by city (New York):");
        PrintPeople(filteredByCity);
    }

    static void PrintPeople(List<Person> people)
    {
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}