using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthable> list = new List<IBirthable>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] data = command.Split();
                
                
                if (data[0] == "Citiza")
                {
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    string id = data[3];
                    string birth = data[4];

                    Citizen citizen = new Citizen(name, age, id,birth);
                    list.Add(citizen);
                }
                else if (data[0] == "Pet")
                {
                    string name = data[1];
                    string birth = data[2];
                    Pet pet = new Pet(name, birth);
                    list.Add(pet);
                }
                command = Console.ReadLine();
            }
            string year = Console.ReadLine();

            foreach (var item in list)
            {
                if (item.Birthdate.EndsWith(year))
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}
