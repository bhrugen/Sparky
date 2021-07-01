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

        public int OrderTotal { get; set; }
        public string GreetMessage { get; set; }

        public string GreetAndCombineNames(string firstName, string LastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Empty First Name");
            }

            GreetMessage =  $"Hello, {firstName} {LastName}";
            Discount = 20;
            return GreetMessage;
        }

        public CustomerType GetCustomerDetails()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            return new PlatinumCustomer();
        }
    }

    public class CustomerType { }
    public class BasicCustomer :CustomerType { }
    public class PlatinumCustomer : CustomerType { }

}
