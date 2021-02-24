using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorChain
{
    class UGStudent:Student
    {
        private int maxSem;

        public int MaxSem
        {
            get { return maxSem; }
            set { maxSem = value; }
        }
        public UGStudent(string name, float cgpa, int maxSem):base(name,cgpa) {
            this.maxSem = maxSem;
           
        }
    }
}
