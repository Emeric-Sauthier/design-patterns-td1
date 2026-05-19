using RPGCombatSimulator.Characters;
using RPGCombatSimulator.Factories;

namespace RPGCombatSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RPG Combat Simulator ===\n");

            WarriorFactory warriorFactory = new WarriorFactory();
            MageFactory mageFactory = new MageFactory();

            Character aragorn = warriorFactory.CreateCharacter("Aragorn");
            Character saruman = mageFactory.CreateCharacter("Saruman");

            Console.WriteLine("Initial Status:");
            Console.WriteLine($"\t{aragorn.GetStatus()}");
            Console.WriteLine($"\t{saruman.GetStatus()}");

            int roundCount = 1;
            while (aragorn.IsAlive() && saruman.IsAlive())
            {
                Console.WriteLine($"\n--- Round {roundCount} ---");
                
                aragorn.Attack(saruman);
                Console.WriteLine();
                saruman.Attack(aragorn);

                roundCount++;
            }

            Console.WriteLine("\n=== Combat Finished ===");
            Console.WriteLine($"{(aragorn.IsAlive() ? aragorn.Name : saruman.Name)} wins!");
        }
    }
}
