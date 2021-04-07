using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Toyota:Car, IBasicCar
    {
        public void Start() { }
        public void Accelerate() { }
        public void Brake() { }
        public void DoorOpen() { }
    }
}
