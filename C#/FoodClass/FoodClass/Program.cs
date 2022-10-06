using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodClass {
    internal class Program {
        static void Main(string[] args) {
            FoodItem orange = new FoodItem("Orange", 3, 12, 110);
            Console.WriteLine(orange);
            Console.ReadLine();
        }
    }
}
