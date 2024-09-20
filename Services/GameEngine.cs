using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _rngesus;
        private readonly IEntity _keyboardWarrior;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity rngesus, IEntity keyboardWarrior)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _rngesus = rngesus;
            _keyboardWarrior = keyboardWarrior;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _rngesus.Name = "Dungeon Master";
            _keyboardWarrior.Name = "Twitter (AKA. 'X') user";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);
            if (_ghost is IFlyable)
            {
                ((IFlyable)_ghost).Fly();
            }

            ((RNGesus)_rngesus).RollDice(_character);

            ((KeyboardWarrior)_keyboardWarrior).BeAngry(_goblin);
        }
    }
}
