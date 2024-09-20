
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class KeyboardWarrior : IEntity, ITypeable
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

    public void BeAngry(IEntity target)
    {
        Console.WriteLine($"{Name} is frustratedly writing up a mean paragraph for {target.Name}");
    }
}
