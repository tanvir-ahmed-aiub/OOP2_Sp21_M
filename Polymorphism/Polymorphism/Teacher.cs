using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Teacher:Person
    {
        new public void ShowInfo() {
            Console.WriteLine("Teacher showinfo");
        }
    }
}
