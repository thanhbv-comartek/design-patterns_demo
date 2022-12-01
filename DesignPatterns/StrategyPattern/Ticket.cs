using StrategyPattern.Interfaces;

namespace StrategyPattern;
public class Ticket
{
    private IPromoteStrategy _promoteStrategy;
    public double Price { get; set; }
    public string Name { get; set; }

    public IPromoteStrategy GetPromoteStrategy()
    {
        return _promoteStrategy;
    }

    public void SetPromoteStrategy(IPromoteStrategy value)
    {
        _promoteStrategy = value;
    }

    public Ticket()
    {

    }

    public Ticket(IPromoteStrategy promoteStrategy)
    {
        _promoteStrategy = promoteStrategy;
    }

    public double GetPromotedPrice()
    {
        return _promoteStrategy.DoDiscount(Price);
    }
}
