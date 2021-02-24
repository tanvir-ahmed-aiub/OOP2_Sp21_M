using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A a = new A(10);
            Console.WriteLine("*******");
            A b = new A();
            Console.WriteLine("*******");*/
            //B c = new B();
            C c = new C(10);

            UGStudent s1 = new UGStudent("Tanvir", 2.5f, 13);
        }
    }
}
