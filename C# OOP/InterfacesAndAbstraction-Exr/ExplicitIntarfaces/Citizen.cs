using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitIntarfaces
{
    public class Citizen : IResident, IPerson
    {
        private string name;
        private string country;
        private int age;
        public Citizen(string name, string country, int age)
        {
            this.name = name;
            this.country = country;
            this.age = age;
        }

        public string Name => this.name;
        public string Country => this.country;
        public int Age => this.age;

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs " + this.Name;
        }
        string IPerson.GetName()
        {
            return this.Name;
        }

    }
}
