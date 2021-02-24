using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorChain
{
    class C:B
    {
        public C() {
            Console.WriteLine("Default : C");
        }
        public C(int a):base("") {
            Console.WriteLine("1 Parameter: C");
        }
    }
}
