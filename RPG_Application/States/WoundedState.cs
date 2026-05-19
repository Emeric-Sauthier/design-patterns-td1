using RPGCombatSimulator.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.States
{
    public class WoundedState : CharacterState
    {
        public WoundedState(Character character) : base(character) { }

        public override bool CanAttack()
        {
            return true;
        }

        public override double GetAttackModifier()
        {
            return 0.8;
        }

        public override string GetStateDescription()
        {
            return "Wounded";
        }

        public override void TakeDamage(int damage)
        {
            _character.Health -= damage;

            if (_character.Health < _character.MaxHealth * 0.25)
            {
                _character.SetState(new CriticalState(_character));
            }
        }
    }
}
