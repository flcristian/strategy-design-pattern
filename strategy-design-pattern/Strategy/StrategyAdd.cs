namespace strategy_design_pattern.Strategy;

public class StrategyAdd : IStrategy
{
    public double Execute(int x, int y)
    {
        return x + y;
    }
}