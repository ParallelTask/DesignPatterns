using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Factory
{
    public interface IDBFactory
    {
        IDBConnector GetDatabase(string dbType);
    }
}
