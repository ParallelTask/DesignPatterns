using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.SingleInstance
{
    // Refer: http://butunclebob.com/ArticleS.UncleBob.SingletonVsJustCreateOne
    public class Program
    {
        public static void Run()
        {
            ISqlProvider sqlProvider = SqlProvider.Connection;

            sqlProvider.Insert();
        }
    }
}
