using RPGCombatSimulator.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.States
{
    public class HealthyState : CharacterState
    {
        public HealthyState(Character character) : base(character) { }

        public override bool CanAttack()
        {
            return true;
        }

        public override double GetAttackModifier()
        {
            return 1;
        }

        public override string GetStateDescription()
        {
            return "Healthy";
        }

        public override void TakeDamage(int damage)
        {
            _character.Health -= damage;

            if (_character.Health < _character.MaxHealth * 0.5)
            {
                _character.SetState(new WoundedState(_character));
            }
        }
    }
}
