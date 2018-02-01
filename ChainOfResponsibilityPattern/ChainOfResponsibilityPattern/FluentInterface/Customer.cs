using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.FluentInterface
{
    public class Customer: ICustomer
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private int _age { get; set; }

        public ICustomer Age(int age)
        {
            _age = age;
            return this;
        }

        public int Age()
        {
            return _age;
        }

        public ICustomer FirstName(string name)
        {
            _firstName = name;
            return this;
        }

        public string FirstName()
        {
            return _firstName;
        }

        public ICustomer LastName(string name)
        {
            _lastName = name;
            return this;
        }

        public string LastName()
        {
            return _lastName;
        }
    }
}
