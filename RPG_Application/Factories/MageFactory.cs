using RPGCombatSimulator.Characters;
using RPGCombatSimulator.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatSimulator.Factories
{
    public class MageFactory : CharacterFactory
    {
        public override Character CreateCharacter(string name)
        {
            return new Character(name, 80, 15, new MagicStrategy());
        }
    }
}
