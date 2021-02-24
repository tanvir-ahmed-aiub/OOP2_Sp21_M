using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorChain
{
    class B : A
    {
        public B():this("") {
            Console.WriteLine("Default: B");
        }
        public B(string a, string b, string c) {
            Console.WriteLine("3 Parameter: B");
        }
        public B(string a):this("","","")
        {
            Console.WriteLine("1 Parameter: B");
        }
    }
}
