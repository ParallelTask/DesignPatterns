using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Factory
{
    // When using a factory your code is still actually responsible for creating objects. 
    // By DI you outsource that responsibility to another class or a framework, which is separate from your code
    // Factory pattern can be called as a tool to implement DI
    // Refer: https://stackoverflow.com/questions/557742/dependency-injection-vs-factory-pattern
    // Refer: https://softwareengineering.stackexchange.com/questions/337413/what-does-it-mean-when-one-says-encapsulate-what-varies

    // the creation of one interface called IPerson and two implementations called Villager and CityPerson.
    // Based on the type passed into the Factory object, we are returning the concrete object as IPerson.
    // Refer: https://en.wikipedia.org/wiki/Factory_method_pattern
    // Refer: https://softwareengineering.stackexchange.com/questions/81838/what-is-the-difference-between-the-factory-pattern-and-abstract-factory
    public class Program
    {
        public static void Run()
        {
            IDBFactory factory = new DBFactory();
            IDBConnector sql = factory.GetDatabase("SQL");
            IDBConnector oracle = factory.GetDatabase("ORACLE");

            sql.Connect();
            oracle.Connect();
            sql.ExecuteQuery();
            oracle.ExecuteQuery();
        }
    }
}
