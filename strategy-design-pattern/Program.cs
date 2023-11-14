using strategy_design_pattern;
using strategy_design_pattern.Strategy;
using Action = strategy_design_pattern.Action;

internal class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context();

        Action action = Action.Subtraction;

        switch (action)
        {
            case Action.Addition:
                context.SetStrategy(new StrategyAdd());
                break;
            case Action.Subtraction:
                context.SetStrategy(new StrategySubtract());
                break;
            case Action.Multiplication:
                context.SetStrategy(new StrategyMultiply());
                break;
        }
        
        Console.WriteLine(context.ExecuteStrategy(2,5));
    }
}