using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Factory
{
    public interface IDBConnector
    {
        void Connect();
        void ExecuteQuery();
    }
}
