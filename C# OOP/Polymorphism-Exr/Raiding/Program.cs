using System;
using System.Collections.Generic;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();

            int count = 0;

            while (count != n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                if (type == "Druid")
                {
                    heroes.Add(new Druid(name));
                    count++;
                }
                else if (type == "Paladin")
                {
                    heroes.Add(new Paladin(name));
                    count++;
                }
                else if (type =="Rogue")
                {
                    heroes.Add(new Rogue(name));
                    count++;
                }
                else if (type == "Warrior")
                {
                    heroes.Add(new Warrior(name));
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }
            int bossPower = int.Parse(Console.ReadLine());

            int raidPower = 0;

            foreach (var hero in heroes)
            {
                raidPower += hero.Power;
                hero.CastAbility();
            }
            if (raidPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
