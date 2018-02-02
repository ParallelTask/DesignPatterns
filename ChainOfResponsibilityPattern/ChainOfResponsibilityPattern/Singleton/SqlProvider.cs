using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Singleton
{
    public class SqlProvider : ISqlProvider
    {
        private static ISqlProvider _sqlProvider = new SqlProvider();

        private SqlProvider() { }

        public static ISqlProvider GetConnection()
        {
            return _sqlProvider;
        }

        public void Insert()
        {
            Console.WriteLine("Insert Query Excuted...");
        }
    }
}
