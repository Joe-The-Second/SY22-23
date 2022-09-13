using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Practice {
    internal class Truck : Vehicle {
        public void drive() {
            Console.WriteLine("Drive");
        }
        public void stop() {
            Console.WriteLine("Boom");
        }
    }
}
