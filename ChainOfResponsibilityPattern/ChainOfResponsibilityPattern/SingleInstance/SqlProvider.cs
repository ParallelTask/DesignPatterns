using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SingleInstance
{
    public class SqlProvider : ISqlProvider
    {
        public static ISqlProvider Connection = new SqlProvider();

        public void Insert()
        {
            Console.WriteLine("Insert Query Executed");
        }
    }
}
