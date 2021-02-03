using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 56; //literals
            const int credit = 148;
            a = 45;

            int n; //declaration
            //Console.WriteLine("n is " + n);

            Student s1 = new Student("Tanvir","79461");

           // s1.Name = "Tanvir Ahmed";
           // s1.Id = "647679";

           // Console.WriteLine("Name : " + s1.Name);
            s1.ShowInfo();
            Console.WriteLine(s1.Cgpa);
           
  
        }
    }
}
