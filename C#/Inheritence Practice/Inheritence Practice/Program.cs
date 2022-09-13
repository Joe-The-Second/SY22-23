using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Practice {
    internal class Program {
        static void Main(string[] args) {
            Vehicle vehicle = new Vehicle();
            vehicle.drive();
            vehicle.stop();
            vehicle.fill();
            Truck truck = new Truck();
            truck.drive();
            truck.stop();
            truck.fill();
            Console.ReadLine();
        }
    }
}
