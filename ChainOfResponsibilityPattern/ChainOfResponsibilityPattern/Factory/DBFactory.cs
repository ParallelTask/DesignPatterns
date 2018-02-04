using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Factory
{
    public class DBFactory : IDBFactory
    {
        public IDBConnector GetDatabase(string dbType)
        {
            if (dbType == "SQL") return new SqlConnector();
            if (dbType == "ORACLE") return new OracleConnector();
            return null;
        }
    }
}
