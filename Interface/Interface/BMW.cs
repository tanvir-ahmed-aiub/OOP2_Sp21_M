using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class BMW:Car,IBasicCar,IRacingCar
    {
        public void NOS() { }
        public void ABS() { }
        public void Start() { }
        public void Brake() { }
        public void Accelerate() { }
        public void DoorOpen() { }
    }
}
