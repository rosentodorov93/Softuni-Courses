using MillitaryElite.Contracts;
using MillitaryElite.Enums;
using MillitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MillitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, ISoldier> soldiers = new Dictionary<int, ISoldier>();

          

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] parts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = parts[0];
                int id = int.Parse(parts[1]);
                string firstName = parts[2];
                string lastName = parts[3];


                if (type == "Private")
                {
                    decimal salary = decimal.Parse(parts[4]);
                    IPrivate @private = new Private(id, firstName, lastName, salary);
                    soldiers[id] = @private;
                }
                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(parts[4]);
                    ILieutenantGeneral lieutanant = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < parts.Length; i++)
                    {
                        int currenId = int.Parse(parts[i]);
                        var currenPrivate = (IPrivate)soldiers[currenId];
                        lieutanant.Add(currenPrivate);
                    }
                    soldiers[id] = lieutanant;
                }
                else if (type == "Engineer")
                {
                    decimal salary = decimal.Parse(parts[4]);
                    bool isCorpsValid = Enum.TryParse(parts[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                    for (int i = 6; i < parts.Length; i += 2)
                    {
                        string partName = parts[i];
                        int hours = int.Parse(parts[i + 1]);

                        IRepairs repair = new Repairs(partName, hours);
                        engineer.Add(repair);
                    }
                    soldiers[id] = engineer;
                }
                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(parts[4]);
                    bool isCorpsValid = Enum.TryParse(parts[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    ICommando commando = new Commando(id, firstName, lastName, salary, corps);
                    for (int i = 6; i < parts.Length; i+=2)
                    {
                        string codeName = parts[i];
                        bool isMissionStateValid = Enum.TryParse(parts[i + 1], out State state);

                        if (!isMissionStateValid)
                        {
                            continue;
                        }
                        IMissions mission = new Mission(codeName, state);
                        commando.Add(mission);
                    }
                    soldiers[id] = commando;
                }
                else if (type == "Spy")
                {
                    int codeNUmber = int.Parse(parts[4]);

                    ISpy spy = new Spy(id, firstName, lastName, codeNUmber);

                    soldiers[id] = spy;
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Value.ToString());
            }
        }
    }
}
