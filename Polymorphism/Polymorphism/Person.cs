using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Person
    {
        public string Name { get;  }
        public string Id { get; private set; }
        public string Dob { get; set; }

        public Person() { }
        public Person(string name, string id, string dob) {
            Name = name;
            Id = id;
            Dob = dob;
        }
        virtual public void ShowInfo() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Dob: " + Dob);
        }
    }
}
