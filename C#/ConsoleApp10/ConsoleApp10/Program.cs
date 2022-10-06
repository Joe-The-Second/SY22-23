using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10 {
    class Program {
        static void Main(string[] args) {
            CarpetCalc c = new CarpetCalc();
            c.SetName("Pile");
            c.SetLength(12, 2); // 12 feet 2 inches
            c.SetWidth(14, 7); // 14 feet 7 inches
            c.SetCostPerYard(15.95m);
            c.PrintCarpet();// The output should be "Pile: $15.95 per yard. Cost:$314.45"   
            Console.ReadKey();
        }
    }
}
