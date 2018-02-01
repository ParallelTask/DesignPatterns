using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.FluentInterface
{
    public class Context : IContext
    {
        private ICustomer _customer;

        public Context(ICustomer customer)
        {
            _customer = customer;
        }

        public ICustomer Age(int age)
        {
            _customer.Age = age;
            return _customer;
        }

        public int Age()
        {
            return _customer.Age;
        }

        public ICustomer FirstName(string name)
        {
            _customer.FirstName = name;
            return _customer;
        }

        public string FirstName()
        {
            return _customer.FirstName;
        }

        public ICustomer LastName(string name)
        {
            _customer.LastName = name;
            return _customer;
        }

        public string LastName()
        {
            return _customer.LastName;
        }
    }
}
