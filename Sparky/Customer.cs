using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public int Discount = 15;
        public string GreetMessage { get; set; }

        public string GreetAndCombineNames(string firstName, string LastName)
        {
            GreetMessage =  $"Hello, {firstName} {LastName}";
            Discount = 20;
            return GreetMessage;
        }
    }
}
