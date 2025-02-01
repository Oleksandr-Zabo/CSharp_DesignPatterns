namespace Patterns_3.Strategy;

using System.Collections.Generic;

public interface IFilterStrategy
{
    List<Person> Filter(List<Person> people);
}

// Filter strategy that filters people by city
public class AgeFilterStrategy : IFilterStrategy
{
    private readonly int _minAge;

    public AgeFilterStrategy(int minAge)
    {
        _minAge = minAge;
    }

    public List<Person> Filter(List<Person> people)
    {
        List<Person> filteredPeople = new List<Person>();
        foreach (var person in people)
        {
            if (person.Age >= _minAge)
            {
                filteredPeople.Add(person);
            }
        }
        return filteredPeople;
    }
}

// Filter strategy that filters people by name
public class NameFilterStrategy : IFilterStrategy
{
    private readonly string _name;

    public NameFilterStrategy(string name)
    {
        _name = name;
    }

    public List<Person> Filter(List<Person> people)
    {
        List<Person> filteredPeople = new List<Person>();
        foreach (var person in people)
        {
            if (person.Name.Equals(_name, StringComparison.OrdinalIgnoreCase))
            {
                filteredPeople.Add(person);
            }
        }
        return filteredPeople;
    }
}

// Filter strategy that filters people by city
public class CityFilterStrategy : IFilterStrategy
{
    private readonly string _city;

    public CityFilterStrategy(string city)
    {
        _city = city;
    }

    public List<Person> Filter(List<Person> people)
    {
        List<Person> filteredPeople = new List<Person>();
        foreach (var person in people)
        {
            if (person.City.Equals(_city, StringComparison.OrdinalIgnoreCase))
            {
                filteredPeople.Add(person);
            }
        }
        return filteredPeople;
    }
}