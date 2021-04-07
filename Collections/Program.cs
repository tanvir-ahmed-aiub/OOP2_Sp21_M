using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ArrayList list = new ArrayList();
            Course c = new Course();
            Course c2 = new Course();
            Course c3 = new Course();

            list.Add(c);
          
            list.Insert(1, c2);
            bool rs = list.Contains(c3);
            int i = list.IndexOf(c2);
            Console.WriteLine("Index of c is: " + rs);

            Hashtable ages = new Hashtable();
            ages["sabbir"] = 28;
            ages["rahim"] = 21;
            ages["karim"] = 25;
            ages.Add("sagor",34);

            foreach (DictionaryEntry age in ages) {
                string a =(string) age.Key;
                int b = (int)age.Value;
                Console.WriteLine("{0} => {1}",a,b);
            }

            Console.WriteLine("Age of sabbir" + ages["sabbir"]);

            SortedList sl = new SortedList();

            sl["en-us"] = "United States";
            sl["en-uk"] = "United Kingdom";
            sl["bn"] = "Bangla";
            sl["in"] = "India";
            sl["ar"] = "Arabic";
            foreach (DictionaryEntry s in sl)
            {
                string a = (string)s.Key;
                string b = (string)s.Value;
                Console.WriteLine("{0} => {1}", a, b);
            }
            /*int k = 10;
            object box = k;
            Console.WriteLine(k.GetType());
            k = (int) box;
            Course c5 = new Course();
            object box2 = c5;
            Console.WriteLine(box.GetType());
            c5 = (Course)box;*/

        }
    }
}
