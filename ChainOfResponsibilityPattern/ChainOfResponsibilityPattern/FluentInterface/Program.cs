using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.FluentInterface
{
    public class Program
    {
        public static void Run()
        {
            var customer = new Customer();
            customer
                .FirstName("Parallel")
                .LastName("Task")
                .Age(25);

            Console.WriteLine($"FirstName: {customer.FirstName()}");
            Console.WriteLine($"LastName: {customer.LastName()}");
            Console.WriteLine($"Age: {customer.Age()}");
        }
    }
}
