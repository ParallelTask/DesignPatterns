using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run the observable pattern output
            // Observable.Program.Run();

            // Run the chain of responsibility output
            // ChainOfResponsibility.Program.Run();

            // Run the publish subscribe pattern
            PublishSubscribe.Program.Run();

            Console.ReadLine();
        }
    }
}
