using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.Strategies
{
    public class RangedStrategy : IAttackStrategy
    {
        public int CalculateDamage(int baseDamage)
        {
            return baseDamage + new Random().Next(5, 15);
        }

        public string GetAttackDescription()
        {
            return "throws";
        }
    }
}
