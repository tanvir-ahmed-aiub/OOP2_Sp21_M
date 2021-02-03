using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Student
    {
        string name;
        string id;
        float cgpa;
        readonly int credit;
        //properties or accessors
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public float Cgpa
        {
            get { return this.cgpa; }
        }
      

        public Student() {
            Console.WriteLine("Student default");
            credit = 145;
        }
        public Student(string name, string id)
        {
            Console.WriteLine("Student Created with 2 parameter");
            this.name = name;
            this.id = id;
           
        }

        public void ShowInfo() {
            
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Id is: " + id);
            Console.WriteLine("Cgpa is: " + cgpa);

        }

    }
}
