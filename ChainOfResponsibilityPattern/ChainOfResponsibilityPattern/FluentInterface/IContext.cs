using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.FluentInterface
{
    public interface IContext
    {
        ICustomer FirstName(string name);
        ICustomer LastName(string name);
        ICustomer Age(int age);
        string FirstName();
        string LastName();
        int Age();
    }
}
