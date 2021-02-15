using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPassValRef
{
    class Program
    {
        static void Swap(ref int x ,ref int y) //10 and 12
        {
            int temp = x;
            x = y;
            y = temp;
            //Console.WriteLine("x = {0}, y = {1}", x, y); //x = 10, y = 12
        }
        static void SwapOut(out int a) {
            a = 10501;
            a = a * a;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 12;
            Console.WriteLine("x = {0}, y = {1}",x,y); //x = 10, y = 12
            Swap(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y); //x = 10, y = 12

            int a = 100;
            SwapOut(out a);
            Console.WriteLine(a);

            /*Student s1 = new Student("Tanvir","1234");
            Student s2 = new Student("Sabbir","1235");
            Student s3 = new Student("Sabbir", "1235");
            Console.WriteLine(s1.Name + " " + s2.Name+"\n");
            Console.WriteLine(Student.count);*/


        }
    }
}
