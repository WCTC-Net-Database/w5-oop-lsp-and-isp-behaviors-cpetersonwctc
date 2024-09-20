
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class RNGesus : IEntity, IRollable
{
    public string Name { get; set; }

    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} moves forward.");
    }

    public void RollDice(IEntity target)
    {
        Console.WriteLine($"{Name} has rolled a dice for {target.Name}");
    }
}
