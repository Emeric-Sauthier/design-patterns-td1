using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.Strategies
{
    public class MagicStrategy : IAttackStrategy
    {
        public int CalculateDamage(int baseDamage)
        {
            return (int)(baseDamage * 1.5);
        }

        public string GetAttackDescription()
        {
            return "casts";
        }
    }
}
