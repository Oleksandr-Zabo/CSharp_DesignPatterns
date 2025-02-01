namespace Patterns_3.Strategy;

// Context class that uses the strategy
public class FilterContext
{
    private IFilterStrategy? _strategy;

    public void SetStrategy(IFilterStrategy strategy)
    {
        _strategy = strategy;
    }

    public List<Person> ExecuteFilter(List<Person> people)
    {
        if (_strategy == null)
        {
            throw new InvalidOperationException("Strategy is not set.");
        }
        return _strategy.Filter(people);
    }
}