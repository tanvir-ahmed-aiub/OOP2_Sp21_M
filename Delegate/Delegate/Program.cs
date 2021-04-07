using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void artimetic(int a, int b);
        public static void Add(int a, int b) {
            Console.WriteLine("Addition: " + (a + b));
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
        static void Main(string[] args)
        {
            artimetic calc = Add;
            calc(12,14);
            calc = Sub;
            calc(13, 1);
            Person p = new Person();
            calc = p.AddtoCgpa;
            calc(76,78);

            artimetic calc2 = Add;
            calc2 += Sub;
            calc2 += p.AddtoCgpa;

            calc2(78,70);
            calc2 -= p.AddtoCgpa;
            calc2(78, 70);


        }
    }
}
