using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public void Call(string number)
        {
            if (number.All(n => char.IsDigit(n)))
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            
        }
    }
}
