using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tanvir","145","12.12.2012",2.5f,145);
            //s1.ShowInfo();
            

            Person p = new Student("Sabbir","146","01.01.2101",3.5f,148);
            p.ShowInfo();

            Person p2 = new Teacher();
            p2.ShowInfo();

            Teacher t = new Teacher();
            t.ShowInfo();
            


            

        }
    }
}
