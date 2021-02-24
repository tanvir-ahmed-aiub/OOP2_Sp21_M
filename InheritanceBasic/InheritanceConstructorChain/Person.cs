using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorChain
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }         
        }
        public Person() { }
        public Person(string name) {
            this.name = name;
        }

    }
}
