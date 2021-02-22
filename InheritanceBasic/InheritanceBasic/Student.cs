using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasic
{
    class Student : Person
    {

        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student() : base("",""){
            Console.WriteLine("Student Default");
        }
        public Student(string name, string id) {
            //this.Name = name;
            //this.Id = id;
            Console.WriteLine("Student 2 Parameter");
        }
        new public void ShowInfo() {
            base.ShowInfo();
            Console.WriteLine("Cgpa: " + cgpa);
        }
        

    }
}
