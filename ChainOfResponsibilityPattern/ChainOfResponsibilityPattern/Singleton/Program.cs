using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Singleton
{
    // You should use When you need only one resource (a database connection, a socket connection …)
    // You shouldn’t use singleton for sharing data between different objects since it creates tight coupling!
    // Refer: https://stackoverflow.com/questions/137975/what-is-so-bad-about-singletons
    public class Program
    {
        public static void Run()
        {
            ISqlProvider sqlProvider = SqlProvider.GetConnection();

            sqlProvider.Insert();

        }
    }
}
