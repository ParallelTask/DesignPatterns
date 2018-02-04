using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Factory
{
    public class OracleConnector : IDBConnector
    {
        public void Connect()
        {
            Console.WriteLine("Oracle Connector");
        }

        public void ExecuteQuery()
        {
            Console.WriteLine("Oracle Execute Query");
        }
    }
}
