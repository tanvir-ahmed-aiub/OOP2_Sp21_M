using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorChain
{
    class Student:Person
    {
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
           
        }
        public Student() { }
        public Student(string name, float cgpa) :base(name){
            this.cgpa = cgpa;
        }

    }
}
