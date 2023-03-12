using System;

namespace ExplicitIntarfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] data = command.Split();
                string name = data[0];
                string country = data[1];
                int age = int.Parse(data[2]);

                Citizen human = new Citizen(name,country,age);
                IResident resident = human;
                IPerson person = human;
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
                
                command = Console.ReadLine();
            }
        }
    }
}
