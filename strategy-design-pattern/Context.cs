using strategy_design_pattern.Strategy;

namespace strategy_design_pattern;

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public Context() { }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public double ExecuteStrategy(int x, int y)
    {
        return _strategy.Execute(x, y);
    }
}