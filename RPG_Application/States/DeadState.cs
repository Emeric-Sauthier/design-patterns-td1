using RPGCombatSimulator.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.States
{
    public class DeadState : CharacterState
    {
        public DeadState(Character character) : base(character) { }

        public override bool CanAttack()
        {
            return false;
        }

        public override double GetAttackModifier()
        {
            return 0;
        }

        public override string GetStateDescription()
        {
            return "Dead";
        }

        public override void TakeDamage(int damage)
        {
            Console.WriteLine("Cannot take damage, already dead");
        }
    }
}
