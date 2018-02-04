using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Factory
{
    public class SqlConnector : IDBConnector
    {
        public void Connect()
        {
            Console.WriteLine("Sql Connector");
        }

        public void ExecuteQuery()
        {
            Console.WriteLine("Sql Query Executor");
        }
    }
}
