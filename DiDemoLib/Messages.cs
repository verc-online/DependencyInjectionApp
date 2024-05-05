using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiDemoLib
{
    public class Messages : IMessages
    {
        public string sayHello() => "Hello Viewer";

        public string sayGoodBye() => "GoodBye, farewell and a good day!";
    }
}
