using RPGCombatSimulator.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.States
{
    public class CriticalState : CharacterState
    {
        public CriticalState(Character character) : base(character) { }

        public override bool CanAttack()
        {
            return true;
        }

        public override double GetAttackModifier()
        {
            return 0.5;
        }

        public override string GetStateDescription()
        {
            return "Critical";
        }

        public override void TakeDamage(int damage)
        {
            _character.Health -= damage;

            if (_character.Health <= 0)
            {
                _character.Health = 0;
                _character.SetState(new DeadState(_character));
            }
        }
    }
}
