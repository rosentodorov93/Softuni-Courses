using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, ICanBrowze
    {
        public void Browzing(string website)
        {
            if (website.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {website}!");
            }
        }

        public void Call(string number)
        {
            if (number.All(n => char.IsDigit(n)))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            
        }
    }
}
