using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Singleton
{
    // You should use When you need only one resource (a database connection, a socket connection …)
    // You shouldn’t use singleton for sharing data between different objects since it creates tight coupling!
    // Refer: http://butunclebob.com/ArticleS.UncleBob.SingletonVsJustCreateOne
    public class Program
    {
        public static void Run()
        {
            ISqlProvider sqlProvider = SqlProvider.GetConnection();

            sqlProvider.Insert();

        }
    }
}
