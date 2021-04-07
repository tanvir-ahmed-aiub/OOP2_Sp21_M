using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Car
    {
        public string EngineNo { get; set; }
        public string ChassisNo { get; set; }
        virtual public void ShowInfo() {
            Console.WriteLine("EngineNo: " + EngineNo);
            Console.WriteLine("ChassisNo: " + ChassisNo);
        }
    }
}
