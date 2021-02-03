using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace StudentAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ShowInfo();
        }
    }
}
