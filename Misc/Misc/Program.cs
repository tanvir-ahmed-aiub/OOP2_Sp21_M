using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault());
            Console.WriteLine(i);
            if (i.HasValue)
            {
                Console.WriteLine("Has value " + i.Value);
            }
            else
            {
                Console.WriteLine("Null");
            }

            int age = 19;
            string vote = "";
            if (age >= 18)
            {
                vote = "Can cast vote";
            }
            else {
                vote = "Can not cast vote";
            }
            Console.WriteLine(vote);


            vote = age >= 18 ? "Can cast vote" : "Can not cast vote";

            var ii = "10.0";
            
            dynamic ic = "10.0";
           
        }
    }
}
